using AR_Winform.Presentation.Forms;
using AR_Winform.Presentation.Forms.User;
using AR_Winform.Presentation.Forms.UserForm;
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
    public partial class HeaderCntrol : UserControl
    {
        public event EventHandler OnCloseParent;
        public HeaderCntrol()
        {
            InitializeComponent();
        }

        public void UpdateLoginState()
        {
            if (Program.LoggedInUser == null)
            {
                // Chưa login
                loginBtn.Text = "Login";
                loginBtn.TextAlign = HorizontalAlignment.Center;
                loginBtn.Image = Properties.Resources.enter;
                loginBtn.ImageAlign = HorizontalAlignment.Center;
                pointPicture.Image = null;  // ảnh login
                pointPicture.Visible = false;
            }
            else
            {
                // Đã login
                string shortEmail = Program.LoggedInUser.Email.Length > 9
                    ? Program.LoggedInUser.Email.Substring(0, 9)
                    : Program.LoggedInUser.Email;

                loginBtn.Text = $"{shortEmail} |          0 Point";
                loginBtn.TextAlign = HorizontalAlignment.Left;
                loginBtn.Image = Properties.Resources.user;
                loginBtn.ImageAlign = HorizontalAlignment.Left;
                pointPicture.Image = Properties.Resources.coin;
                pointPicture.Visible = true;
            }
        }

        public void loginBtn_Click(object sender, EventArgs e)
        {
            if (Program.LoggedInUser == null)
            {
                // Chưa login -> mở form login
                OnCloseParent?.Invoke(this, EventArgs.Empty);
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

            }
            else
            {
                // Đã login -> mở profile
                OnCloseParent?.Invoke(this, EventArgs.Empty);
                UserProfile userProfile = new UserProfile();
                userProfile.Show();
            }

        }

        private void HeaderCntrol_Load(object sender, EventArgs e)
        {
            UpdateLoginState();
        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu Form hiện tại KHÔNG phải BookingForm
            if (!(this.FindForm() is BookingStatusForm))
            {
                // Đóng form hiện tại (nếu cần)
                OnCloseParent?.Invoke(this, EventArgs.Empty);

                BookingStatusForm form = new BookingStatusForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("Bạn đang ở BookingForm",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void supportBtn_Click(object sender, EventArgs e)
        {
            if (!(this.FindForm() is SupportForm))
            {
                // Đóng form hiện tại (nếu cần)
                OnCloseParent?.Invoke(this, EventArgs.Empty);

                SupportForm form = new SupportForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("Bạn đang ở SupportForm",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void promotionBtn_Click(object sender, EventArgs e)
        {
            if (!(this.FindForm() is PromotionForm))
            {
                // Đóng form hiện tại (nếu cần)
                OnCloseParent?.Invoke(this, EventArgs.Empty);

                PromotionForm form = new PromotionForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("Bạn đang ở PromotionForm",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
