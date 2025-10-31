using AR_Winform.Application.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AR_Winform.Presentation.UControls
{
    public partial class AirportItem : UserControl
    {
        private Airport _airport;
        public AirportItem()
        {
            InitializeComponent();

            this.Cursor = Cursors.Hand;

            // click toàn bộ control
            foreach (Control c in this.Controls)
                c.Click += Item_Click;

            this.Click += Item_Click;
        }

        public void SetData(Airport airport)
        {
            _airport = airport;
            airportNameLB.Text = airport.AirportName;
            airportCodeLB.Text = airport.AirportCode;
            cityLB.Text = airport.CityName;
            countyLB.Text = airport.Country;
        }

        public event EventHandler<Airport> AirportClicked;

        private void Item_Click(object sender, EventArgs e)
        {
            AirportClicked?.Invoke(this, _airport);
        }
    }
}
