using AR_Winform.Application.Interfaces;
using AR_Winform.Application.Services;
using AR_Winform.Domain.Entities;
using AR_Winform.Shared.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AR_Winform.Presentation.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IAuthenticationServices _authService;
        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthenticationServices();
            passwordTB.UseSystemPasswordChar = true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var validation = new Validation();

            if (!validation.IsValidEmail(emailTB.Text))
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }

            if (!validation.IsValidPassword(passwordTB.Text))
            {
                MessageBox.Show("Mật khẩu phải >=6 ký tự, gồm chữ và số!");
                return;
            }

            var success = _authService.Login(emailTB.Text.Trim(), passwordTB.Text.Trim());

            if (!success)
            {
                MessageBox.Show("Sai Email/SĐT hoặc mật khẩu!");
                return;
            }


            MessageBox.Show($"Xin chào: {Program.LoggedInUser.FullName}",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                    // Chuyển sang MainForm
             BookingForm mainForm = new BookingForm();
             mainForm.Show();
             this.Hide();
        }

        private void registerLB_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
            this.Hide();
        }

        private void backPicture_Click(object sender, EventArgs e)
        {
            BookingForm form = new BookingForm();
            form.Show();
            this.Hide();
        }

        private void eyePicture_Click(object sender, EventArgs e)
        {
            if (seePasswordLB.Text == "Hide")
            {
                // Đổi sang Unhide
                seePasswordLB.Text = "Unhide";
                eyePicture.Image = Properties.Resources.unhide;
                passwordTB.UseSystemPasswordChar = false; // hiện mật khẩu
            }
            else
            {
                // Đổi sang Hide
                seePasswordLB.Text = "Hide";
                eyePicture.Image = Properties.Resources.hide;
                passwordTB.UseSystemPasswordChar = true; // ẩn mật khẩu
            }
        }
    }
}
