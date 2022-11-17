using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm_oop
{
    internal class ParaYatirma : IIslem1
    {
        User user = new User();
        BakiyeSorgula bkySorgula = new BakiyeSorgula();
        public void paraYatirmaCekme(double miktar)
        {

            user.Bakiye = user.Bakiye + miktar;
            bkySorgula.bakiyeSorgulama();

        }
    }
}
