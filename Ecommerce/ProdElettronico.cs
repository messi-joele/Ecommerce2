using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class ProdElettronico : Prodotto
    {
        private string _codice;
        private decimal _prezzoscont;


        public ProdElettronico(string id, string nome, string prod, string descr, decimal prezzo, string codice, decimal prezzoscont): base(id,nome, prod, descr, prezzo)
        {
            Codice = codice;
            Prezzoscont = prezzoscont;
        }

        public string Codice {
            get { return _codice; }
            set { _codice = value; }

            }

        public decimal Prezzoscont
        {
            get { return _prezzoscont; }
            set { _prezzoscont = value; }   
        }

        public void Sconto ( ){


            

            if(DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                Prezzo =  Prezzo * 0.95m;
            }
            
        }
    }

}   
