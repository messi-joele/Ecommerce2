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
        
       

        public override decimal ScontaProd()
        {




            if (DateTime.Today.Day % 2 == 0)
            {
                Prezzo -= Prezzo * 0.05m;
                return Prezzo;
            }
            return base.ScontaProd();
        }
    }
}
