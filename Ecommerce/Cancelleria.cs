using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    internal class Cancelleria :Prodotto
    {
        private DateTime giorni;
        public Cancelleria (string id, string nome, string prod, string descr, decimal prezzo, DateTime giorni) : base(id, nome, prod, descr, prezzo)
        {
            Giorni = giorni;
            

        }
            public DateTime Giorni
        {
            get { return giorni; }
            set { giorni = value; }
        }

        public void Sconto()
        {

        }
    }
}
