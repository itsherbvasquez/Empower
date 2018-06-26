using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("010101010101 WELCOME HACKER 010101010101");
            Console.WriteLine("");
            Console.WriteLine("Please Enter Your First Name Below:");
            var fname = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Please Enter Your Last Name Below:");
            var lname = Console.ReadLine();
            Name(fname, lname);
            var fullname = $"{fname} {lname}";
            {
                bool fullnametrue = true;
                if (fullnametrue == true) {
                    Console.WriteLine("Enter Credentials");
                };
            };
            Console.WriteLine("");
            var credentialsclass = new CredentialsClass();
            var password = Console.ReadLine();
            credentialsclass.Credential(int.Parse(password));

        }
        
        static void Name(string fname, string lname)
        {
            Console.WriteLine("");
            var nameRepeat = $" Welcome: {fname} {lname}";
            for (int x = 0; x < 1; x++)
            {
                
                Console.WriteLine(nameRepeat);
            }
            Console.WriteLine();
        }
        
    }
}
