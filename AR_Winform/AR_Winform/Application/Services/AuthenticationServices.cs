using AR_Winform.Application.Interfaces;
using AR_Winform.Domain.Entities;
using AR_Winform.Presentation.UControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR_Winform.Application.Services
{
    internal class AuthenticationServices : IAuthenticationServices
    {
        public bool Login(string email, string password)
        {
            using (var db = new MyDbContext())
            {
                var user = db.Users
                             .FirstOrDefault(u =>
                                 (u.Email.ToLower() == email.ToLower()
                                 || u.Phone == email)
                                 && u.PasswordHash == password);

                if (user == null)
                    return false;

                // Lưu vào Program.LoggedInUser
                Program.LoggedInUser = new CurrentUser
                {   
                    UserId = user.UserID,
                    RoleID = user.RoleID,
                    FullName = user.FullName,
                    Password = user.PasswordHash,
                    Gender = user.Gender,
                    Email = user.Email,
                    Phone = user.Phone,
                    Role = user.Role
                };

                return true;
            }
        }

        public void logout()
        {
            Program.LoggedInUser = null;
        }
    }
}
