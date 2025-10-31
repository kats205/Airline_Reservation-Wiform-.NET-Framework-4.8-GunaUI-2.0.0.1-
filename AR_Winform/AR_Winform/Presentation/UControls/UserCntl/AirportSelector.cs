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

namespace AR_Winform.Presentation.UControls.User
{
    public partial class AirportSelector : UserControl
    {
        private AirportRepositoryADO.AirportRepository _repo;
        private string _excludeCode;

        public event EventHandler<Airport> AirportSelected;

        public AirportSelector()
        {
            InitializeComponent();
            flowAirports.Dock = DockStyle.Fill;
            flowAirports.FlowDirection = FlowDirection.TopDown;
            flowAirports.WrapContents = false;
            flowAirports.AutoScroll = true;
        }

        public void Init(AirportRepositoryADO.AirportRepository repo)
        {
            _repo = repo;
            LoadAirports();
        }

        public string ExcludeCode
        {
            get => _excludeCode;
            set
            {
                _excludeCode = value;
                LoadAirports(); // reload danh sách khi set exclude
            }
        }

        private void LoadAirports()
        {
            if (_repo == null) return;

            var airports = _repo.GetAirports(1, int.MaxValue, _excludeCode);
            flowAirports.Controls.Clear();

            foreach (var ap in airports)
            {
                var item = new AirportItem();
                item.SetData(ap);

                item.AirportClicked += (s, airport) =>
                {
                    AirportSelected?.Invoke(this, airport);
                };

                flowAirports.Controls.Add(item);
            }
        }
    }

}
