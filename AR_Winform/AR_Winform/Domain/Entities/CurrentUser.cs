using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR_Winform.Domain.Entities
{
    public class CurrentUser
    {
        public  int UserId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public  string Email { get; set; } = string.Empty;
        public  string Phone { get; set; } = string.Empty;
        public  Role Role { get; set; }
        public  int RoleID { get; set; }
    }
}
