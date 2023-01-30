using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Cancelleria :Prodotto
    {
       
        public Cancelleria (string id, string nome, string prod, string descr, decimal prezzo) : base(id, nome, prod, descr, prezzo)
        {
           
            

        }
        

        public  void Sconto()
        {
            if( DateTime.Today.Day % 2 == 0)
            {
                Prezzo -= Prezzo * 0.03m;
            }
        }
    }
}
