using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookDumperForFFBE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shalzuth's FFBE ID + Token dumper");
            Console.WriteLine("E-mail?");
            var email = Console.ReadLine();
            Console.WriteLine("Password?");
            var password = Console.ReadLine();
            Console.WriteLine("Working - please wait.");
            var fb = new Facebook(email, password);
            Console.WriteLine("id : " + fb.Id);
            Console.WriteLine("token : " + fb.AccessToken);
            Console.WriteLine("Press any key to exit.");
            Console.Read();
        }
    }
}
