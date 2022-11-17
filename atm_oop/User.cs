using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm_oop
{
    internal class User
    {
        private string sifre = "1234";
        private string kartNo = "123456";
        private double bakiye = 20000;

        public double Bakiye
        {
            get { return bakiye; }
            set { value = this.bakiye; }
        }

        public string KartNo
        { get { return kartNo; } }

        public string Sifre
        {
            get { return sifre; }
            set { value = this.sifre; }
        }

        public User(string sifre, string kartNo)
        {
            this.sifre = sifre;
            this.kartNo = kartNo;
        }

        public User()
        {
        }
    }
}
