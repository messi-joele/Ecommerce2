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
        

        public ProdElettronico(string id, string nome, string prod, string descr, decimal prezzo, string codice): base(id,nome, prod, descr, prezzo)
        {
            Codice = codice;
            
        }

        public string Codice {
            get { return _codice; }
            set { _codice = value; }

            }

        public override string ToString()
        {
            return base.ToString() + " codice:" + Codice;
        }


        public override decimal ScontaProd ( ){
            

            

            if(DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
               Prezzo -=Prezzo * 0.05m;
                return Prezzo;
            }
           return base.ScontaProd( );
        }
    }

}   
