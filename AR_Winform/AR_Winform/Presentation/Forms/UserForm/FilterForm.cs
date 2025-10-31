using AR_Winform.Application.DTOs;
using AR_Winform.Domain.Entities;
using AR_Winform.Presentation.UControls.UserCntl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AR_Winform.Presentation.Forms
{
    public partial class FilterForm : Form
    {
        private List<(Flight flight, AR_Winform.Domain.Entities.Airport from, AR_Winform.Domain.Entities.Airport to)> _flights;
        private string[] sortOptions = {
            "Earliest departure",
            "Latest departure",
            "Earliest arrival",
            "Latest arrival"
        };
        private bool _isRoundTrip = false;

        public FilterForm(List<(Flight flight, AR_Winform.Domain.Entities.Airport from, AR_Winform.Domain.Entities.Airport to)> flights)
        {
            InitializeComponent();
            _flights = flights;

            headerCntrol1.OnCloseParent += (s, e) => this.Hide();

            // Gắn "Others" làm mặc định
            sortCB.Items.Add("Others");
            sortCB.SelectedIndex = 0;

            if (flights == null || flights.Count == 0)
            {
                Label lbl = new Label
                {
                    Text = "Không có chuyến bay phù hợp!",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                allFlightsPN.Controls.Add(lbl);
                return;
            }

            // --- Tính giá thấp nhất & thời gian ngắn nhất ---
            var lowestPrice = flights.Min(f => f.flight.BasePrice);
            var shortestDuration = flights.Min(f =>
                (f.flight.ArrivalTime - f.flight.DepartureTime).TotalMinutes);

            int hours = (int)(shortestDuration / 60);
            int minutes = (int)(shortestDuration % 60);

            lowestPriceLB.Text = $"{lowestPrice:N0} VND";
            shortestDurationLB.Text = $"{hours}h {minutes}m";

            // --- chuyến rẻ nhất (hiển thị riêng) ---
            var cheapest = flights.OrderBy(f => f.flight.BasePrice).First();
            var ucBest = new AllFlights();
            ucBest.LoadFlightData(cheapest.flight, cheapest.from, cheapest.to);
            ucBest.Tag = cheapest.flight;
            bestFlightPN.Controls.Add(ucBest);

            // --- tất cả chuyến bay (bao gồm cả chuyến rẻ nhất) ---
            DisplayAllFlights(flights);

            // Gắn sự kiện cho các nút lọc thời gian
            InitTimeFilterEvents();
        }

        // ====== HIỂN THỊ DANH SÁCH GỐC ======
        private void DisplayAllFlights(IEnumerable<(Flight flight, AR_Winform.Domain.Entities.Airport from, AR_Winform.Domain.Entities.Airport to)> flights)
        {
            allFlightsPN.Controls.Clear();
            allFlightsPN.FlowDirection = FlowDirection.TopDown;
            allFlightsPN.WrapContents = false;
            allFlightsPN.AutoScroll = true;

            foreach (var (flight, from, to) in flights)
            {
                var uc = new AllFlights();
                uc.LoadFlightData(flight, from, to);
                uc.Tag = flight;
                allFlightsPN.Controls.Add(uc);
            }
        }

        // ====== NÚT THAY ĐỔI TÌM KIẾM ======
        private void changeSearchBtn_Click(object sender, EventArgs e)
        {
            if (!searchPN.Controls.OfType<Searching>().Any())
            {
                var searchControl = new Searching();
                searchControl.Dock = DockStyle.Fill;
                searchPN.Controls.Clear();
                searchPN.Controls.Add(searchControl);
                searchControl.BringToFront();
                searchPN.BringToFront();
                searchPN.Visible = true;

                searchControl.CloseClicked += (s, args) =>
                {
                    searchPN.Visible = false;
                };
            }
            else
            {
                searchPN.Visible = true;
            }
        }

        // ====== KHỞI TẠO SỰ KIỆN CÁC NÚT LỌC ======
        private void InitTimeFilterEvents()
        {
            // Departure time
            deBtn1.Click += (s, e) => FilterByTime("dep", 0, 8);
            deBtn2.Click += (s, e) => FilterByTime("dep", 8, 12);
            deBtn3.Click += (s, e) => FilterByTime("dep", 12, 18);
            deBtn4.Click += (s, e) => FilterByTime("dep", 18, 24);

            // Arrival time (chỉ nếu vé khứ hồi)
            reBtn1.Click += (s, e) => FilterByTime("arr", 0, 8);
            reBtn2.Click += (s, e) => FilterByTime("arr", 8, 12);
            reBtn3.Click += (s, e) => FilterByTime("arr", 12, 18);
            reBtn4.Click += (s, e) => FilterByTime("arr", 18, 24);

            // Reset button
            resetBtn.Click += (s, e) => DisplayAllFlights(_flights);
        }

        // ====== HÀM LỌC THEO KHOẢNG THỜI GIAN ======
        private void FilterByTime(string mode, int startHour, int endHour)
        {
            if (_flights == null || _flights.Count == 0)
                return;

            IEnumerable<(Flight flight, AR_Winform.Domain.Entities.Airport from, AR_Winform.Domain.Entities.Airport to)> filtered = _flights;

            if (mode == "dep")
            {
                filtered = _flights.Where(f =>
                    f.flight.DepartureTime.Hour >= startHour &&
                    f.flight.DepartureTime.Hour < endHour);
            }
            else if (mode == "arr" && _isRoundTrip)
            {
                filtered = _flights.Where(f =>
                    f.flight.ArrivalTime.Hour >= startHour &&
                    f.flight.ArrivalTime.Hour < endHour);
            }

            DisplayAllFlights(filtered);
        }



        // ====== COMBOBOX SORT MỞ DANH SÁCH ======
        private void sortCB_DropDown(object sender, EventArgs e)
        {
            if (sortCB.Items.Contains("Others"))
            {
                sortCB.Items.Clear();
                sortCB.Items.AddRange(sortOptions);
            }
        }

        private void sortCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_flights == null || _flights.Count == 0) return;

            List<(Flight flight, AR_Winform.Domain.Entities.Airport from, AR_Winform.Domain.Entities.Airport to)> sorted = _flights;

            switch (sortCB.SelectedItem.ToString())
            {
                case "Earliest departure":
                    sorted = _flights.OrderBy(f => f.flight.DepartureTime).ToList();
                    break;
                case "Latest departure":
                    sorted = _flights.OrderByDescending(f => f.flight.DepartureTime).ToList();
                    break;
                case "Earliest arrival":
                    sorted = _flights.OrderBy(f => f.flight.ArrivalTime).ToList();
                    break;
                case "Latest arrival":
                    sorted = _flights.OrderByDescending(f => f.flight.ArrivalTime).ToList();
                    break;
                default:
                    sorted = _flights;
                    break;
            }

            DisplayAllFlights(sorted);
        }

        // ====== SẮP XẾP THEO GIÁ ======
        private void lowestPricePN_Click(object sender, EventArgs e)
        {
            if (_flights == null || _flights.Count == 0)
                return;

            var sorted = _flights.OrderBy(f => f.flight.BasePrice).ToList();
            DisplayAllFlights(sorted);

            lowestPricePN.FillColor = Color.FromArgb(220, 240, 255);
            Task.Delay(150).ContinueWith(_ =>
            {
                Invoke(new Action(() => lowestPricePN.FillColor = Color.White));
            });
        }

        // ====== SẮP XẾP THEO THỜI GIAN BAY ======
        private void shortestdurationPN_Click(object sender, EventArgs e)
        {
            if (_flights == null || _flights.Count == 0)
                return;

            var sorted = _flights
                .OrderBy(f => (f.flight.ArrivalTime - f.flight.DepartureTime).TotalMinutes)
                .ToList();

            DisplayAllFlights(sorted);

            shortestdurationPN.FillColor = Color.FromArgb(220, 240, 255);
            Task.Delay(150).ContinueWith(_ =>
            {
                Invoke(new Action(() => shortestdurationPN.FillColor = Color.White));
            });
        }

        // ====== HIỂN THỊ LẠI TẤT CẢ ======
        private void showAllBtn_Click(object sender, EventArgs e)
        {
            DisplayAllFlights(_flights);
        }
    }
}
