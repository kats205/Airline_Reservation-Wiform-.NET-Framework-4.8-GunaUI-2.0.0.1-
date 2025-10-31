using AR_Winform.Domain.Entities;
using AR_Winform.Shared.Utils;
using AR_Winform.Presentation.Forms;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            passwordTB.UseSystemPasswordChar = true;
        } 
        
        private void registerBtn_Click(object sender, EventArgs e)
        {
            var validation = new Validation();

            if (!validation.IsValidEmail(emailTB.Text))
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }

            if (!validation.IsValidPhone(phoneTB.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return;
            }

            if (!validation.IsValidPassword(passwordTB.Text))
            {
                MessageBox.Show("Mật khẩu phải >=6 ký tự, gồm chữ và số!");
                return;
            }

            try
            {
                using (var db = new MyDbContext())
                {

                    var user = new Domain.Entities.User
                    {
                        Email = emailTB.Text.ToLower().Trim(),
                        Phone = phoneTB.Text.Trim(),
                        PasswordHash = passwordTB.Text.Trim(),  
                        RoleID = 1,                     
                        Status = "Active",        
                        CreatedAt = DateTime.Now
                    };

                    // 2. Thêm vào DbSet
                    db.Users.Add(user);

                    // 3. Lưu thay đổi
                    db.SaveChanges();

                    MessageBox.Show("Đăng ký thành công!");

                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void loginLB_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void backPicture_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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
