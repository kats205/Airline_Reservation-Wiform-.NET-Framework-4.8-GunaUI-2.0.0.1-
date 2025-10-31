using AR_Winform.Application.DTOs;
using AR_Winform.Application.DTOs;
using AR_Winform.Application.Interfaces;
using AR_Winform.Application.Services;
using AR_Winform.Domain.Entities;
using AR_Winform.Presentation.UControls;
using AR_Winform.Presentation.UControls.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AR_Winform.Presentation.Forms
{
    public partial class BookingForm : Form
    {
        private Timer rotateTimer;
        private int currentAngle = 0;
        private int targetAngle = 180;
        private Image originalImage;
        private AirportSelector fromSelector;
        private AirportSelector toSelector;
        private TypeTicket typeTicketControl;
        private DepartureDate departureDate;
        private ReturnDate returnDate;

        public BookingForm()
        {
            InitializeComponent();

            headerCntrol1.OnCloseParent += (s, e) => this.Hide();

            // lưu ảnh gốc để xoay
            originalImage = (Image)swapBtn.Image.Clone();
            rotateTimer = new Timer();
            rotateTimer.Interval = 15; // ms, càng nhỏ càng mượt
            rotateTimer.Tick += RotateTimer_Tick;

        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            // Set default values
            DateTime today = DateTime.Today;
            // Departure mặc định hôm nay
            deDateBtn.Text = today.ToString("dd MMM yyyy",
                System.Globalization.CultureInfo.InvariantCulture);

            // Return mặc định sau 2 ngày
            DateTime returnDay = today.AddDays(2);
            reDateBtn.Text = returnDay.ToString("dd MMM yyyy",
                System.Globalization.CultureInfo.InvariantCulture);

            // đồng bộ ReturnDateUC
            if (returnDate != null)
            {
                returnDate.DepartureDate = today;
                returnDate.RefreshCalendar();
            }

            if (departureDate != null)
            {
                departureDate.RefreshCalendar();
            }


            // Load seat classes
            var seatClasses = new List<SeatClass>
            {
                new SeatClass {ClassID = 1, ClassName = "Economy"},
                new SeatClass {ClassID = 2, ClassName = "Premium Economy"},
                new SeatClass {ClassID = 3, ClassName = "Business" },
                new SeatClass {ClassID = 4, ClassName = "First"}
            };

            seatClassCB.DataSource = seatClasses;
            seatClassCB.DisplayMember = "ClassName";
            seatClassCB.ValueMember = "ClassID";

            // FromSelector
            var fromAirportRepo = new AirportRepositoryADO.AirportRepository();
            fromSelector = new AirportSelector();
            fromSelector.Visible = false;
            fromSelector.AutoSize = true;
            fromSelector.Location = new Point(33, 393); // vị trí tuyệt đối
            fromSelector.Init(fromAirportRepo); // Gọi Init cho fromSelector
            fromSelector.AirportSelected += (s, airport) =>
            {
                fromAirportBtn.Text = $"{airport.CityName} ({airport.AirportCode})";
                fromSelector.Visible = false;
                // loại sân bay đã chọn khỏi ToSelector
                toSelector.ExcludeCode = airport.AirportCode;
            };
            this.Controls.Add(fromSelector);

            // ToSelector
            var toAirportRepo = new AirportRepositoryADO.AirportRepository();
            toSelector = new AirportSelector();
            toSelector.Visible = false;
            toSelector.AutoSize = true;
            toSelector.Location = new Point(303, 393); // vị trí tuyệt đối
            toSelector.Init(toAirportRepo); // Gọi Init cho toSelector
            toSelector.AirportSelected += (s, airport) =>
            {
                toAirportBtn.Text = $"{airport.CityName} ({airport.AirportCode})";
                toSelector.Visible = false;

                // loại sân bay đã chọn khỏi FromSelector
                fromSelector.ExcludeCode = airport.AirportCode;
            };
            this.Controls.Add(toSelector);

            // Load TypeTicket
            typeTicketControl = new TypeTicket();
            typeTicketControl.Visible = false;
            typeTicketControl.Location = new Point(598, 276);
            this.Controls.Add(typeTicketControl);
            typeTicketControl.DoneClicked += (s, data) =>
            {
                string text = $"{data.Adult} Adult, {data.Child} Child, {data.Infant} Infant (on lap)";
                typeTicketBtn.Text = text;
            };

            // Load Departure Canlender
            departureDate = new DepartureDate();
            departureDate.Visible = false;
            departureDate.Location = new Point(595, 393);
            this.Controls.Add(departureDate);
            departureDate.DaySelected += (s, date) =>
            {
                deDateBtn.Text = date.ToString("dd MMM yyyy"); // gắn giá trị
                departureDate.Visible = false; // ẩn sau khi chọn

                if (returnDate != null)
                {
                    returnDate.DepartureDate = date;
                    returnDate.RefreshCalendar();
                }
            };

            // Load Return Canlender
            returnDate = new ReturnDate();
            returnDate.Visible = false;
            returnDate.Location = new Point(595, 393);
            this.Controls.Add(returnDate);

            returnDate.DaySelected += (s, date) =>
            {
                reDateBtn.Text = date.ToString("dd MMM yyyy");
                returnDate.Visible = false;
            };


            // Load promotions
            var promoRepo = new PromotionRepositoryADO();
            var promos = promoRepo.GetRandomPromotions(4);

            var panels = new[] { promo1, promo2, promo3, promo4 };

            for (int i = 0; i < promos.Count; i++)
            {
                var card = new PromotionCard();
                card.Dock = DockStyle.Fill;
                panels[i].Controls.Clear();
                panels[i].Controls.Add(card);

                card.SetData(promos[i].PromoCode, promos[i].Description,
                             promos[i].DiscountPercent,
                             promos[i].StartDate, promos[i].EndDate);
            }


            headerCntrol1.UpdateLoginState();
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            if (rotateTimer.Enabled) return;

            currentAngle = 0;         // reset góc
            targetAngle = 180;        // xoay 180°
            rotateTimer.Start();

            string temp = fromAirportBtn.Text.Trim();
            fromAirportBtn.Text = toAirportBtn.Text.Trim();
            toAirportBtn.Text = temp;
        }

        private void RotateTimer_Tick(object sender, EventArgs e)
        {
            currentAngle += 10; // bước xoay, tăng nhỏ hơn thì mượt hơn
            if (currentAngle >= targetAngle)
            {
                currentAngle = targetAngle;
                rotateTimer.Stop();
            }

            // vẽ ảnh xoay
            swapBtn.Image = RotateImage(originalImage, currentAngle);
        }

        private Bitmap RotateImage(Image img, float angle)
        {

            Bitmap bmp = new Bitmap(img.Width, img.Height);
            bmp.SetResolution(img.HorizontalResolution, img.VerticalResolution);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.TranslateTransform(img.Width / 2, img.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-img.Width / 2, -img.Height / 2);
                g.DrawImage(img, new Point(0, 0));
            }

            return bmp;
        }

        private void fromAirportBtn_Click(object sender, EventArgs e)
        {
            fromSelector.Visible = !fromSelector.Visible;
            toSelector.Visible = false;
            typeTicketControl.Visible = false;
            departureDate.Visible = false;
            fromSelector.BringToFront();
        }

        private void toAirportBtn_Click(object sender, EventArgs e)
        {
            toSelector.Visible = !toSelector.Visible;
            fromSelector.Visible = false;
            typeTicketControl.Visible = false;
            departureDate.Visible = false;
            returnDate.Visible = false;
            toSelector.BringToFront();
        }

        private void typeTicketBtn_Click(object sender, EventArgs e)
        {
            typeTicketControl.Visible = !typeTicketControl.Visible;
            fromSelector.Visible = false;
            toSelector.Visible = false;
            departureDate.Visible = false;
            returnDate.Visible = false;
            typeTicketControl.BringToFront();
        }

        private void deDateBtn_Click(object sender, EventArgs e)
        {
            departureDate.Visible = !departureDate.Visible;
            fromSelector.Visible = false;
            toSelector.Visible = false;
            typeTicketControl.Visible = false;
            returnDate.Visible = false;
            departureDate.BringToFront();
        }

        private void reDateBtn_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(deDateBtn.Text, out var dep))
            {
                returnDate.DepartureDate = dep;
            }
            else
            {
                returnDate.DepartureDate = DateTime.Today;
            }

            returnDate.Visible = !returnDate.Visible;
            fromSelector.Visible = false;
            toSelector.Visible = false;
            typeTicketControl.Visible = false;
            departureDate.Visible = false;
            returnDate.BringToFront();
        }

        private void roundtripRBtn_CheckedChanged(object sender, EventArgs e)
        {
            returnDate.Visible = false;
            fromSelector.Visible = false;
            toSelector.Visible = false;
            typeTicketControl.Visible = false;
            departureDate.Visible = false;

            if (roundtripRBtn.Checked)
            {
                // Enable ReturnDate
                reDateBtn.Enabled = true;

                // Checkbox luôn tích, không cho bỏ tích
                reDateChB.Checked = true;
                reDateChB.Enabled = false;

                // Đổi icon nút thành calendar
                reDateBtn.Image = Properties.Resources.calendar;
            }
            else
            {
                // Disable ReturnDate
                reDateBtn.Enabled = false;

                // Checkbox luôn off, disable
                reDateChB.Checked = false;
                reDateChB.Enabled = false;

                // Đổi icon nút thành calendar-unchecked
                reDateBtn.Image = Properties.Resources.calendar_unchecked;
            }
        }

        private void onewayRBtn_CheckedChanged(object sender, EventArgs e)
        {
            returnDate.Visible = false;
            fromSelector.Visible = false;
            toSelector.Visible = false;
            typeTicketControl.Visible = false;
            departureDate.Visible = false;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ UI
            string fromCode = fromAirportBtn.Text.Split('(').Last().TrimEnd(')');
            string fromCity = fromAirportBtn.Text.Split('(').First().Trim();
            string toCode = toAirportBtn.Text.Split('(').Last().TrimEnd(')');
            string toCity = toAirportBtn.Text.Split('(').First().Trim();
            DateTime depDate = DateTime.Parse(deDateBtn.Text);
            DateTime? retDate = null;
            if (roundtripRBtn.Checked)
            {
                retDate = DateTime.Parse(reDateBtn.Text);
            } 
            string typeTicket = typeTicketBtn.Text;
            string seatClass = seatClassCB.Text;

            // Tạo DTO để truyền dữ liệu
            var repo = new FlightsRepositoryADO(ConfigurationManager.ConnectionStrings["MyDbContext"].ConnectionString);
            var flights = repo.GetFlights(fromCode, toCode, depDate);

            // Mở FilterForm để hiển thị
            FilterForm filterForm  = new FilterForm(flights);

            filterForm.fromAirportLB.Text = fromCity;
            filterForm.toAirportLB.Text = toCity;
            filterForm.deDateLB.Text = depDate.ToString("dd MMM yyyy");
            int adult = 0, child = 0, infant = 0;
            string[] parts = typeTicket.Split(',');
            foreach (string part in parts)
            {
                if (part.Contains("Adult"))
                    int.TryParse(new string(part.Where(char.IsDigit).ToArray()), out adult);
                else if (part.Contains("Child"))
                    int.TryParse(new string(part.Where(char.IsDigit).ToArray()), out child);
                else if (part.Contains("Infant"))
                    int.TryParse(new string(part.Where(char.IsDigit).ToArray()), out infant);
            }
            int totalPassengers = adult + child + infant;
            filterForm.ticketLB.Text = $"{totalPassengers} passenger(s)";
            filterForm.seatClassLB.Text = seatClass;

            // Giả định bạn có AirportRepository để lấy tên thành phố
            var airportRepo = new AirportRepositoryADO.AirportRepository();
            var fromAirport = airportRepo.GetByCode(fromCode);
            var toAirport = airportRepo.GetByCode(toCode);

            if (fromAirport != null)
                filterForm.fromCityLB.Text = "(" + fromAirport.IATA + ")" ;
            if (toAirport != null)
                filterForm.toCityLB.Text = "(" + toAirport.IATA + ")";

            // Cập nhật phần bên trái UI (sidebar)
            filterForm.fromAirportLeftLB.Text = fromCity;
            filterForm.toAirportLeftLB.Text = toCity;
            filterForm.deDateLeftLB.Text = depDate.ToString("dd MMM yyyy");

            // Nếu round-trip
            if (roundtripRBtn.Checked && retDate.HasValue)
            {
                filterForm.reDateLeftLB.Text = retDate.Value.ToString("dd MMM yyyy");
                filterForm.fromAirportReLeftLB.Text = toCity;  // chuyến về thì đảo chiều
                filterForm.toAirportReLeftLB.Text = fromCity;
            }
            else
            {
                // Nếu là one-way thì ẩn nhóm Return
                filterForm.reDateLeftLB.Visible = false;
                filterForm.fromAirportReLeftLB.Visible = false;
                filterForm.toAirportReLeftLB.Visible = false;
                filterForm.leftIcon.Visible = false;
                filterForm.reLeftPicture.Visible = false;
            }

            filterForm.Show();
            this.Hide();
        }
    }
}
