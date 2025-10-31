using AR_Winform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AR_Winform.Presentation.UControls.UserCntl
{
    public partial class AllFlights : UserControl
    {

        // Event khi người dùng click Choose
        public event EventHandler ChooseClicked;
        public AllFlights()
        {
            InitializeComponent();
        }

        // Gán dữ liệu chuyến bay
        public void LoadFlightData(Flight flight, Airport from, Airport to)
        {
            // Hãng bay (tạm thời fix, sau này join Airline)
            lblAirlineName.Text = "VietJet Air";

            // Thời gian
            lblDepartureTime.Text = flight.DepartureTime.ToString("HH:mm");
            lblArrivalTime.Text = flight.ArrivalTime.ToString("HH:mm");

            TimeSpan duration = flight.ArrivalTime - flight.DepartureTime;
            lblDuration.Text = $"{duration.Hours}h {duration.Minutes}m";

            // Sân bay
            lblFromAirport.Text = from.City + " (" + from.IATA + ")";
            lblToAirport.Text = to.City + "(" + from.IATA + ")";

            lblFlightType.Text = "__Direct__";
            lblBaggage.Text = "0kg";

            // Giá
            decimal basePrice = flight.BasePrice;
            decimal tax = basePrice * 0.1m;
            decimal finalPrice = basePrice - tax;

            lblPrice.Text = $"{flight.BasePrice:N0} VND";
            lblPriceLabel.Text = $"{finalPrice:N0} VND /pax";
            lblPriceLabel.ForeColor = Color.Red;
        }



        private void btnChoose_Click_1(object sender, EventArgs e)
        {
            ChooseClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
