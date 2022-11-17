using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm_oop
{
    public class ParaGonderme : IIslem2
    {
        User user = new User();
        BakiyeSorgula bkySorgula = new BakiyeSorgula();
        public void paraGonderme(double miktar, string iban)
        {
            if (ibanSorgula(iban))
            {
                if (miktar <= user.Bakiye)
                {
                    user.Bakiye -= miktar;
                    bkySorgula.bakiyeSorgulama();
                }
            }
            else
            {
                Console.WriteLine("Yanlış iban girdiniz");

            }
        }

        private bool ibanSorgula(string iban)
        {
            bool dogrula = false;
            iban = iban.Replace(" ", "");
            if (iban.StartsWith("TR") && iban.Length == 26)
            {
                dogrula = true;
            }
            return dogrula;
        }
    }
}
