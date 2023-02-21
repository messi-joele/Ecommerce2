namespace Ecommerce
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.idTxt = new System.Windows.Forms.TextBox();
            this.prezzoTxt = new System.Windows.Forms.TextBox();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.NomeTxt = new System.Windows.Forms.TextBox();
            this.prodTxt = new System.Windows.Forms.TextBox();
            this.ciccio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inserisci = new System.Windows.Forms.Button();
            this.mostra = new System.Windows.Forms.Button();
            this.cancTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancella = new System.Windows.Forms.Button();
            this.TIPOLOGIA = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(36, 71);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(100, 20);
            this.idTxt.TabIndex = 0;
            // 
            // prezzoTxt
            // 
            this.prezzoTxt.Location = new System.Drawing.Point(36, 223);
            this.prezzoTxt.Name = "prezzoTxt";
            this.prezzoTxt.Size = new System.Drawing.Size(100, 20);
            this.prezzoTxt.TabIndex = 3;
            // 
            // descTxt
            // 
            this.descTxt.Location = new System.Drawing.Point(180, 157);
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(100, 20);
            this.descTxt.TabIndex = 4;
            // 
            // NomeTxt
            // 
            this.NomeTxt.Location = new System.Drawing.Point(180, 71);
            this.NomeTxt.Name = "NomeTxt";
            this.NomeTxt.Size = new System.Drawing.Size(100, 20);
            this.NomeTxt.TabIndex = 5;
            // 
            // prodTxt
            // 
            this.prodTxt.Location = new System.Drawing.Point(36, 157);
            this.prodTxt.Name = "prodTxt";
            this.prodTxt.Size = new System.Drawing.Size(100, 20);
            this.prodTxt.TabIndex = 6;
            // 
            // ciccio
            // 
            this.ciccio.AutoSize = true;
            this.ciccio.Location = new System.Drawing.Point(65, 25);
            this.ciccio.Name = "ciccio";
            this.ciccio.Size = new System.Drawing.Size(18, 13);
            this.ciccio.TabIndex = 7;
            this.ciccio.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "SCADENZA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "PREZZO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "DESCRIZIONE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PRODUTTORE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "NOME";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(27, 270);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(349, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(333, 294);
            this.dataGridView1.TabIndex = 14;
            // 
            // inserisci
            // 
            this.inserisci.Location = new System.Drawing.Point(376, 337);
            this.inserisci.Name = "inserisci";
            this.inserisci.Size = new System.Drawing.Size(75, 23);
            this.inserisci.TabIndex = 15;
            this.inserisci.Text = "INSERISCI";
            this.inserisci.UseVisualStyleBackColor = true;
            this.inserisci.Click += new System.EventHandler(this.inserisci_Click);
            // 
            // mostra
            // 
            this.mostra.Location = new System.Drawing.Point(497, 337);
            this.mostra.Name = "mostra";
            this.mostra.Size = new System.Drawing.Size(75, 23);
            this.mostra.TabIndex = 16;
            this.mostra.Text = "MOSTRA";
            this.mostra.UseVisualStyleBackColor = true;
            this.mostra.Click += new System.EventHandler(this.mostra_Click);
            // 
            // cancTxt
            // 
            this.cancTxt.Location = new System.Drawing.Point(376, 411);
            this.cancTxt.Name = "cancTxt";
            this.cancTxt.Size = new System.Drawing.Size(123, 20);
            this.cancTxt.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "CANCELLA PRODOTTO";
            // 
            // cancella
            // 
            this.cancella.Location = new System.Drawing.Point(514, 408);
            this.cancella.Name = "cancella";
            this.cancella.Size = new System.Drawing.Size(75, 23);
            this.cancella.TabIndex = 19;
            this.cancella.Text = "CANCELLA";
            this.cancella.UseVisualStyleBackColor = true;
            this.cancella.Click += new System.EventHandler(this.cancella_Click);
            // 
            // TIPOLOGIA
            // 
            this.TIPOLOGIA.AutoSize = true;
            this.TIPOLOGIA.Location = new System.Drawing.Point(192, 198);
            this.TIPOLOGIA.Name = "TIPOLOGIA";
            this.TIPOLOGIA.Size = new System.Drawing.Size(64, 13);
            this.TIPOLOGIA.TabIndex = 20;
            this.TIPOLOGIA.Text = "TIPOLOGIA";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Alimentare",
            "Elettronico",
            "Cancelleria (Penna)",
            "Cancelleria (Foglio di Carta)"});
            this.comboBox1.Location = new System.Drawing.Point(180, 222);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TIPOLOGIA);
            this.Controls.Add(this.cancella);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancTxt);
            this.Controls.Add(this.mostra);
            this.Controls.Add(this.inserisci);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ciccio);
            this.Controls.Add(this.prodTxt);
            this.Controls.Add(this.NomeTxt);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.prezzoTxt);
            this.Controls.Add(this.idTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox prezzoTxt;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.TextBox NomeTxt;
        private System.Windows.Forms.TextBox prodTxt;
        private System.Windows.Forms.Label ciccio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button inserisci;
        private System.Windows.Forms.Button mostra;
        private System.Windows.Forms.TextBox cancTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancella;
        private System.Windows.Forms.Label TIPOLOGIA;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}