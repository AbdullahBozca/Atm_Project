using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm_oop
{
    public class BakiyeSorgula
    {
        User user = new User();
        Menu menu = new Menu(); 
        public void bakiyeSorgulama()
        {
            Console.WriteLine("BAKİYENİZ: " + user.Bakiye);
            menu.menu();
        }
    }
}
