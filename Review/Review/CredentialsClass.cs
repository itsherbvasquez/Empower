using System;
using System.Collections.Generic;
using System.Text;

namespace Review
{
    class CredentialsClass:ICredentialClass
    {
        public void Credential(int password)
        {
            int uPass = 8037;

            if (uPass == password)
            {
                Console.WriteLine("ACCEPTED");
            }
            else
            {
                Console.WriteLine("ACCESS DENIED: CREDENTIALS INVALID");
            };
            Console.ReadKey();

        }

        public int PasswordLength(string password)
        {
            Console.ReadLine();
            return password.Length;
            
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public string UserName(string username)
        {

            Console.ReadLine();
            return username.ToString();
        }
    }
}
