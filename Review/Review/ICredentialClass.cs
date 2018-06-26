using System;
using System.Collections.Generic;
using System.Text;

namespace Review
{
    interface ICredentialClass
    {
        void Print();
        int PasswordLength(string password);
        string UserName(string username);
    }
}
