using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Carta: Cancelleria
    {
        public int grammatura;
        public Carta (string id, string nome, string prod, string descr, decimal prezzo, int grammatura) : base(id, nome, prod, descr, prezzo)
        {
            this.grammatura = grammatura;
        }

        public int Grammaura
        {
            get { return grammatura; }
            set { grammatura = value; } 
        }
    }
}
