namespace TBP_Skladiste
{
    partial class GlavnaStatistikaSkladista
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.inputOdustani = new System.Windows.Forms.Button();
            this.inputPocetakNarudzbi = new System.Windows.Forms.Button();
            this.outputKupac = new System.Windows.Forms.DataGridView();
            this.Brojac = new System.Windows.Forms.Timer(this.components);
            this.inputZaustavi = new System.Windows.Forms.Button();
            this.outputNarudzbe = new System.Windows.Forms.TextBox();
            this.inputPopuniSkladiste = new System.Windows.Forms.Button();
            this.dgvPrikazUProcesu = new System.Windows.Forms.DataGridView();
            this.dgvKrajNarudzbe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prikazStanjaSkladista = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.outputUProcesu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.outputZavrsene = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.outputKupac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazUProcesu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKrajNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikazStanjaSkladista)).BeginInit();
            this.SuspendLayout();
            // 
            // inputOdustani
            // 
            this.inputOdustani.Location = new System.Drawing.Point(383, 12);
            this.inputOdustani.Name = "inputOdustani";
            this.inputOdustani.Size = new System.Drawing.Size(75, 23);
            this.inputOdustani.TabIndex = 0;
            this.inputOdustani.Text = "Odustani";
            this.inputOdustani.UseVisualStyleBackColor = true;
            this.inputOdustani.Click += new System.EventHandler(this.inputOdustani_Click);
            // 
            // inputPocetakNarudzbi
            // 
            this.inputPocetakNarudzbi.Location = new System.Drawing.Point(12, 12);
            this.inputPocetakNarudzbi.Name = "inputPocetakNarudzbi";
            this.inputPocetakNarudzbi.Size = new System.Drawing.Size(126, 23);
            this.inputPocetakNarudzbi.TabIndex = 1;
            this.inputPocetakNarudzbi.Text = "Zapocni narudzbe";
            this.inputPocetakNarudzbi.UseVisualStyleBackColor = true;
            this.inputPocetakNarudzbi.Click += new System.EventHandler(this.inputPocetakNarudzbi_Click);
            // 
            // outputKupac
            // 
            this.outputKupac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputKupac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputKupac.Location = new System.Drawing.Point(12, 305);
            this.outputKupac.Name = "outputKupac";
            this.outputKupac.Size = new System.Drawing.Size(464, 218);
            this.outputKupac.TabIndex = 2;
            // 
            // Brojac
            // 
            this.Brojac.Interval = 500;
            this.Brojac.Tick += new System.EventHandler(this.Brojac_Tick);
            // 
            // inputZaustavi
            // 
            this.inputZaustavi.Location = new System.Drawing.Point(145, 12);
            this.inputZaustavi.Name = "inputZaustavi";
            this.inputZaustavi.Size = new System.Drawing.Size(127, 23);
            this.inputZaustavi.TabIndex = 4;
            this.inputZaustavi.Text = "Zaustavi narudzbe";
            this.inputZaustavi.UseVisualStyleBackColor = true;
            this.inputZaustavi.Click += new System.EventHandler(this.inputZaustavi_Click);
            // 
            // outputNarudzbe
            // 
            this.outputNarudzbe.Location = new System.Drawing.Point(12, 42);
            this.outputNarudzbe.Multiline = true;
            this.outputNarudzbe.Name = "outputNarudzbe";
            this.outputNarudzbe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputNarudzbe.Size = new System.Drawing.Size(464, 228);
            this.outputNarudzbe.TabIndex = 5;
            this.outputNarudzbe.TextChanged += new System.EventHandler(this.outputNarudzbe_TextChanged);
            // 
            // inputPopuniSkladiste
            // 
            this.inputPopuniSkladiste.Location = new System.Drawing.Point(278, 12);
            this.inputPopuniSkladiste.Name = "inputPopuniSkladiste";
            this.inputPopuniSkladiste.Size = new System.Drawing.Size(99, 23);
            this.inputPopuniSkladiste.TabIndex = 6;
            this.inputPopuniSkladiste.Text = "Popuni skladiste";
            this.inputPopuniSkladiste.UseVisualStyleBackColor = true;
            this.inputPopuniSkladiste.Click += new System.EventHandler(this.inputPopuniSkladiste_Click);
            // 
            // dgvPrikazUProcesu
            // 
            this.dgvPrikazUProcesu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazUProcesu.Location = new System.Drawing.Point(595, 42);
            this.dgvPrikazUProcesu.Name = "dgvPrikazUProcesu";
            this.dgvPrikazUProcesu.Size = new System.Drawing.Size(346, 227);
            this.dgvPrikazUProcesu.TabIndex = 7;
            // 
            // dgvKrajNarudzbe
            // 
            this.dgvKrajNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKrajNarudzbe.Location = new System.Drawing.Point(961, 42);
            this.dgvKrajNarudzbe.Name = "dgvKrajNarudzbe";
            this.dgvKrajNarudzbe.Size = new System.Drawing.Size(346, 227);
            this.dgvKrajNarudzbe.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Narudzbe u procesu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(961, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gotove narudzbe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ukupne narudzbe";
            // 
            // prikazStanjaSkladista
            // 
            chartArea3.Name = "ChartArea1";
            this.prikazStanjaSkladista.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.prikazStanjaSkladista.Legends.Add(legend3);
            this.prikazStanjaSkladista.Location = new System.Drawing.Point(598, 305);
            this.prikazStanjaSkladista.Name = "prikazStanjaSkladista";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Minimalnakolicina";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Trenutnakolicina";
            this.prikazStanjaSkladista.Series.Add(series5);
            this.prikazStanjaSkladista.Series.Add(series6);
            this.prikazStanjaSkladista.Size = new System.Drawing.Size(823, 218);
            this.prikazStanjaSkladista.TabIndex = 12;
            this.prikazStanjaSkladista.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Broj narudzbi u procesu";
            // 
            // outputUProcesu
            // 
            this.outputUProcesu.Location = new System.Drawing.Point(15, 547);
            this.outputUProcesu.Name = "outputUProcesu";
            this.outputUProcesu.Size = new System.Drawing.Size(118, 20);
            this.outputUProcesu.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 574);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Broj zavrsenih narudzbi";
            // 
            // outputZavrsene
            // 
            this.outputZavrsene.Location = new System.Drawing.Point(15, 591);
            this.outputZavrsene.Name = "outputZavrsene";
            this.outputZavrsene.Size = new System.Drawing.Size(118, 20);
            this.outputZavrsene.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Stanje na skladistu";
            // 
            // GlavnaStatistikaSkladista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1433, 616);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.outputZavrsene);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outputUProcesu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prikazStanjaSkladista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKrajNarudzbe);
            this.Controls.Add(this.dgvPrikazUProcesu);
            this.Controls.Add(this.inputPopuniSkladiste);
            this.Controls.Add(this.outputNarudzbe);
            this.Controls.Add(this.inputZaustavi);
            this.Controls.Add(this.outputKupac);
            this.Controls.Add(this.inputPocetakNarudzbi);
            this.Controls.Add(this.inputOdustani);
            this.Name = "GlavnaStatistikaSkladista";
            this.Text = "GlavnaStatistikaSkladista";
            ((System.ComponentModel.ISupportInitialize)(this.outputKupac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazUProcesu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKrajNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikazStanjaSkladista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputOdustani;
        private System.Windows.Forms.Button inputPocetakNarudzbi;
        private System.Windows.Forms.DataGridView outputKupac;
        private System.Windows.Forms.Timer Brojac;
        private System.Windows.Forms.Button inputZaustavi;
        private System.Windows.Forms.TextBox outputNarudzbe;
        private System.Windows.Forms.Button inputPopuniSkladiste;
        private System.Windows.Forms.DataGridView dgvPrikazUProcesu;
        private System.Windows.Forms.DataGridView dgvKrajNarudzbe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart prikazStanjaSkladista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outputUProcesu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox outputZavrsene;
        private System.Windows.Forms.Label label6;
    }
}