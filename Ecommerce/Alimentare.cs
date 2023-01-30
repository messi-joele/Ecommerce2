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

        public Alimentare (string id, string nome, string prod, string descr, decimal prezzo, DateTime scadenza, string[] alimenti ) : base(id, nome, prod, descr, prezzo)
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

        public void Sconto()
        {
            if (DateTime.Today.DayOfWeek - scadenza.DayOfWeek < 7)
            {
                Prezzo = Prezzo * 0.5m;
            }
            
        }

        public void Carica (string a, string b, string c, string d, string e, string f, string g, string h, string i, string l)
        {
            alimenti[0]=  a;
            alimenti[1] = b;
            alimenti[2] = c;
            alimenti[3] = d;
            alimenti[4] = e;
            alimenti[5] = f;
            alimenti[6] = g;
            alimenti[7] = h;
            alimenti[8] = i;
            alimenti[9] = l;
           
        }
    }
}
