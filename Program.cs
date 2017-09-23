using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookDumperForFFBE
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Shalzuth's FFBE ID + Token dumper");
            Console.WriteLine("E-mail?");
            var email = Console.ReadLine();
            Console.WriteLine("Password?");
            var password = Console.ReadLine();
            Console.WriteLine("Working - please wait.");
            var fb = new Facebook();
            fb.Login(email, password);
            if (fb.TwoFactorAuth)
            {
                Console.WriteLine("Two Factor Auth Recovery Code?");
                var code = Console.ReadLine();
                fb.FinishTwoFactorAuth(code);
            }
            fb.AllowFFBE();
            Console.WriteLine("id : " + fb.Id);
            Clipboard.SetText(fb.Id);
            Console.WriteLine("fbid copied to clipboard, press Enter to continue to token");
            Console.ReadLine();
            Console.WriteLine("token : " + fb.AccessToken);
            Clipboard.SetText(fb.AccessToken);
            Console.WriteLine("fbtoken copied to clipboard, press Enter to exit");
            Console.ReadLine();
        }
    }
}
