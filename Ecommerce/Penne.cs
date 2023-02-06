using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    internal class Penne : Cancelleria
    {
        public string tipo;
        public Penne(string id, string nome, string prod, string descr, decimal prezzo, string tipo) : base(id, nome, prod, descr, prezzo)
        {
            this.tipo = tipo;
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
