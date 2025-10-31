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
    public partial class PromotionCard : UserControl
    {
        private string _promoCode;

        public PromotionCard()
        {
            InitializeComponent();
        }

        public void SetData(string code, string description, decimal discount, DateTime start, DateTime end)
        {
            _promoCode = code;
            promoCodeLB.Text = code;
            descLB.Text = description;
            discountLB.Text = $"{Math.Round(discount)}%";
            dateLB.Text = $"{start:dd/MM/yyyy} - {end:dd/MM/yyyy}";
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(_promoCode);
            MessageBox.Show($"Copied: {_promoCode}", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
