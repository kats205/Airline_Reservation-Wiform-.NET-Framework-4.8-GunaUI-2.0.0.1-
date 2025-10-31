using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR_Winform.Application.Interfaces
{
    internal interface IAuthenticationServices
    {
        bool Login(string email, string password);
        void logout();
    }
}
