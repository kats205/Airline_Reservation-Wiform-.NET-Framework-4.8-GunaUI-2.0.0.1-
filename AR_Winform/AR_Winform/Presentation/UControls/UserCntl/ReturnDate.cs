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
    public partial class ReturnDate : UserControl
    {
        private DateTime currentMonth;  // tháng đang hiển thị
        private DateTime today = DateTime.Today;
        private List<Guna.UI2.WinForms.Guna2Button> dayButtons;

        public event EventHandler<DateTime> DaySelected;
        public DateTime DepartureDate { get; set; }

        public ReturnDate()
        {
            InitializeComponent();
            layout.Dock = DockStyle.Fill;
            dayButtons = new List<Guna.UI2.WinForms.Guna2Button>
            {
                guna2Button1, guna2Button2, guna2Button3, guna2Button4, guna2Button5,
                guna2Button6, guna2Button7, guna2Button8, guna2Button9, guna2Button10,
                guna2Button11, guna2Button12, guna2Button13, guna2Button14, guna2Button15,
                guna2Button16, guna2Button17, guna2Button18, guna2Button19, guna2Button20,
                guna2Button21, guna2Button22, guna2Button23, guna2Button24, guna2Button25,
                guna2Button26, guna2Button27, guna2Button28, guna2Button29, guna2Button30,
                guna2Button31, guna2Button32, guna2Button33, guna2Button34, guna2Button35
            };

            currentMonth = DateTime.Today;
            RenderCalendar();
        }

        private void RenderCalendar()
        {
            DateTime firstDay = new DateTime(currentMonth.Year, currentMonth.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month);
            int startDayOfWeek = (int)firstDay.DayOfWeek;
            if (startDayOfWeek == 0) startDayOfWeek = 7; // Chủ nhật

            // Ngày nhỏ nhất có thể chọn
            DateTime minSelectable = DepartureDate != DateTime.MinValue
                ? (DepartureDate.Date > today ? DepartureDate.Date : today)
                : today;

            for (int i = 0; i < 35; i++)
            {
                var btn = dayButtons[i];
                int day = i - (startDayOfWeek - 1) + 1;

                if (day < 1 || day > daysInMonth)
                {
                    btn.Visible = false;
                }
                else
                {
                    DateTime current = new DateTime(currentMonth.Year, currentMonth.Month, day);
                    btn.Visible = true;
                    btn.Text = day.ToString();
                    btn.Tag = current;

                    if (current < minSelectable)
                    {
                        btn.Enabled = false;
                        btn.FillColor = Color.LightGray;
                    }
                    else
                    {
                        btn.Enabled = true;
                        btn.FillColor = Color.RoyalBlue;
                    }

                    btn.Click -= Day_Click;
                    btn.Click += Day_Click;
                }
            }

            dateLB.Text = $"{firstDay:MMMM yyyy}";
        }

        public void RefreshCalendar()
        {
            RenderCalendar();
        }

        private void Day_Click(object sender, EventArgs e)
        {
            var btn = sender as Guna.UI2.WinForms.Guna2Button;
            if (btn == null || !btn.Enabled) return;

            if (btn.Tag is DateTime date)
                DaySelected?.Invoke(this, date);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(1);
            RenderCalendar();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(-1);
            RenderCalendar();
        }
    }
}
