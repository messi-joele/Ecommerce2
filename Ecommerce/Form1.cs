using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ecommerce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            carica();
            
        }

        
        Carrello carrello1 = new Carrello("C123");
        Prodotto PennaBic = new Penne("P1", "Penna", "Bic", "Penna della Bic", 1, "stilografica");
        Prodotto FoglioA4 = new Carta("P2", "Foglio", "Fabbriano", "Foglio A4", 0,5);
        Prodotto Laptop = new ProdElettronico("P10", "Laptop", "Intel", "Laptop potente", 1000, "fi2n32");
        Prodotto[] lista = new Prodotto[10];
        public void carica()
        {
            domainUpDown1.Items.Add(PennaBic.Nome);
            domainUpDown1.Items.Add(FoglioA4.Nome);
            domainUpDown1.Items.Add(Laptop.Nome);
            lista[0] = PennaBic;
            lista[1] = FoglioA4;
            
            lista[2] = Laptop;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string a = Convert.ToString(domainUpDown1.SelectedItem);
                carrello1.Aggiungi(prod(a));
                aggiorna();
            }
            catch (Exception eccezione)
            {
                MessageBox.Show(eccezione.Message);
            }
        }
        public Prodotto prod(string a)
        {
            Prodotto p;
            for (int i = 0; i < 99; i++)
            {
                if (lista[i].Nome == a)
                {
                    p = lista[i];
                    return p;
                }
            }
            return null;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string a = Convert.ToString(domainUpDown1.SelectedItem);
                carrello1.Rimuovi(prod(a));
                aggiorna();
            }
            catch(Exception eccezione)
            {
                MessageBox.Show(eccezione.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sicuro di voler eliminare?", "Attenzione", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                carrello1.Svuota();
                aggiorna();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            aggiorna();
        }
        public void aggiorna()
        {
            listView1.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (carrello1.Cerca(carrello1.getProdotto(i)) != -1)
                {
                    Prodotto p = carrello1.getProdotto(i);
                    if (p != null)
                    {
                        ListViewItem itm;
                        itm = new ListViewItem(p.ToString());
                        listView1.Items.Add(itm);
                    }
                        
                }          
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             string[] Alimenti = new string[10];
            Prodotto Salame = new Alimentare("P3", "Salame", "Salumiere", "Salame di maiale", 12, new DateTime(2023, 12, 31), Alimenti);
        }
    }
}