using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce
{
    public partial class Form1 : Form
    {
        public List<Prodotto> elenco = new List<Prodotto>();
        public Prodotto p1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void inserisci_Click(object sender, EventArgs e)
        {
            Prodotto NuovoProdotto = new Prodotto(idTxt.Text,NomeTxt.Text,prodTxt.Text,descTxt.Text,decimal.Parse(prezzoTxt.Text));
            elenco.Add(NuovoProdotto);
        }

        private void mostra_Click(object sender, EventArgs e)
        {
            var ele = elenco.Select(p =>
          new
          {
              ID = p.Id,
              NOME = p.Nome,
              PRODUTTORE = p.Produttore,
              DESCRIZIONE = p.Descrizione,
              PREZZO = p.Prezzo,




          });
            dataGridView1.DataSource = ele.ToList();
        }

        private void cancella_Click(object sender, EventArgs e)
        {
            int K = elenco.RemoveAll(y => y.Id == cancTxt.Text);
            MessageBox.Show($"è stato cancellato {K} voto");
            
        }
    }
}
