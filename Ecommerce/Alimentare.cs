using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    internal class Alimentare : Prodotto
    {
        private DateTime scadenza;
        string[] alimenti = new string[10];
        

        public Alimentare (string id, string nome, string prod, string descr, decimal prezzo, DateTime scadenza, string[] alimenti) : base(id, nome, prod, descr, prezzo)
        {
            Scadenza = scadenza;
            Alimenti = alimenti;
        }

        public DateTime Scadenza { 
        
            get { return scadenza; }
            set { scadenza = value; }
        }

        public string[] Alimenti
        {
            get { return alimenti; }
            set { alimenti = value; }
        }

       
        
        public override decimal ScontaProd()
        {

            if (DateTime.Today.DayOfWeek - scadenza.DayOfWeek < 7)
            {
                Prezzo -= Prezzo * 0.05m;
                return Prezzo;
            }
            return base.ScontaProd();
        }

        
    }
}
