namespace TBP_Skladiste
{
    partial class WarehouseNoviArtikl
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
            this.inputPotvrdiUnos = new System.Windows.Forms.Button();
            this.inputOdustani = new System.Windows.Forms.Button();
            this.outputPopisArtikalaNaSkladistu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.inputNazivArtikla = new System.Windows.Forms.TextBox();
            this.inputTrenutnoStanje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputMinimalnaKolicina = new System.Windows.Forms.TextBox();
            this.inputMaksimalnaKolicina = new System.Windows.Forms.TextBox();
            this.inputDostavljen = new System.Windows.Forms.DateTimePicker();
            this.inputRokTrajanja = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inputOsvjeziPrikaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outputPopisArtikalaNaSkladistu)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPotvrdiUnos
            // 
            this.inputPotvrdiUnos.Location = new System.Drawing.Point(47, 277);
            this.inputPotvrdiUnos.Name = "inputPotvrdiUnos";
            this.inputPotvrdiUnos.Size = new System.Drawing.Size(75, 23);
            this.inputPotvrdiUnos.TabIndex = 0;
            this.inputPotvrdiUnos.Text = "Dodaj artikl";
            this.inputPotvrdiUnos.UseVisualStyleBackColor = true;
            this.inputPotvrdiUnos.Click += new System.EventHandler(this.inputPotvrdiUnos_Click);
            // 
            // inputOdustani
            // 
            this.inputOdustani.Location = new System.Drawing.Point(277, 277);
            this.inputOdustani.Name = "inputOdustani";
            this.inputOdustani.Size = new System.Drawing.Size(75, 23);
            this.inputOdustani.TabIndex = 1;
            this.inputOdustani.Text = "Odustani";
            this.inputOdustani.UseVisualStyleBackColor = true;
            this.inputOdustani.Click += new System.EventHandler(this.inputOdustani_Click);
            // 
            // outputPopisArtikalaNaSkladistu
            // 
            this.outputPopisArtikalaNaSkladistu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputPopisArtikalaNaSkladistu.Location = new System.Drawing.Point(492, 66);
            this.outputPopisArtikalaNaSkladistu.Name = "outputPopisArtikalaNaSkladistu";
            this.outputPopisArtikalaNaSkladistu.Size = new System.Drawing.Size(302, 234);
            this.outputPopisArtikalaNaSkladistu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(492, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trenutno stanje skladista";
            // 
            // inputNazivArtikla
            // 
            this.inputNazivArtikla.Location = new System.Drawing.Point(152, 67);
            this.inputNazivArtikla.Name = "inputNazivArtikla";
            this.inputNazivArtikla.Size = new System.Drawing.Size(100, 20);
            this.inputNazivArtikla.TabIndex = 4;
            // 
            // inputTrenutnoStanje
            // 
            this.inputTrenutnoStanje.Location = new System.Drawing.Point(152, 94);
            this.inputTrenutnoStanje.Name = "inputTrenutnoStanje";
            this.inputTrenutnoStanje.Size = new System.Drawing.Size(100, 20);
            this.inputTrenutnoStanje.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Naziv artikla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trenutna kolicina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Minimalna kolicina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Maksimalna kolicina";
            // 
            // inputMinimalnaKolicina
            // 
            this.inputMinimalnaKolicina.Location = new System.Drawing.Point(152, 120);
            this.inputMinimalnaKolicina.Name = "inputMinimalnaKolicina";
            this.inputMinimalnaKolicina.Size = new System.Drawing.Size(100, 20);
            this.inputMinimalnaKolicina.TabIndex = 10;
            // 
            // inputMaksimalnaKolicina
            // 
            this.inputMaksimalnaKolicina.Location = new System.Drawing.Point(152, 147);
            this.inputMaksimalnaKolicina.Name = "inputMaksimalnaKolicina";
            this.inputMaksimalnaKolicina.Size = new System.Drawing.Size(100, 20);
            this.inputMaksimalnaKolicina.TabIndex = 11;
            // 
            // inputDostavljen
            // 
            this.inputDostavljen.Location = new System.Drawing.Point(152, 174);
            this.inputDostavljen.Name = "inputDostavljen";
            this.inputDostavljen.Size = new System.Drawing.Size(200, 20);
            this.inputDostavljen.TabIndex = 12;
            // 
            // inputRokTrajanja
            // 
            this.inputRokTrajanja.Location = new System.Drawing.Point(152, 201);
            this.inputRokTrajanja.Name = "inputRokTrajanja";
            this.inputRokTrajanja.Size = new System.Drawing.Size(200, 20);
            this.inputRokTrajanja.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Datum dostave";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Rok trajanja";
            // 
            // inputOsvjeziPrikaz
            // 
            this.inputOsvjeziPrikaz.Location = new System.Drawing.Point(718, 39);
            this.inputOsvjeziPrikaz.Name = "inputOsvjeziPrikaz";
            this.inputOsvjeziPrikaz.Size = new System.Drawing.Size(75, 23);
            this.inputOsvjeziPrikaz.TabIndex = 16;
            this.inputOsvjeziPrikaz.Text = "Osvjezi prikaz";
            this.inputOsvjeziPrikaz.UseVisualStyleBackColor = true;
            this.inputOsvjeziPrikaz.Click += new System.EventHandler(this.inputOsvjeziPrikaz_Click);
            // 
            // WarehouseNoviArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 461);
            this.Controls.Add(this.inputOsvjeziPrikaz);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputRokTrajanja);
            this.Controls.Add(this.inputDostavljen);
            this.Controls.Add(this.inputMaksimalnaKolicina);
            this.Controls.Add(this.inputMinimalnaKolicina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputTrenutnoStanje);
            this.Controls.Add(this.inputNazivArtikla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputPopisArtikalaNaSkladistu);
            this.Controls.Add(this.inputOdustani);
            this.Controls.Add(this.inputPotvrdiUnos);
            this.Name = "WarehouseNoviArtikl";
            this.Text = "WarehouseNoviArtikl";
            ((System.ComponentModel.ISupportInitialize)(this.outputPopisArtikalaNaSkladistu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputPotvrdiUnos;
        private System.Windows.Forms.Button inputOdustani;
        private System.Windows.Forms.DataGridView outputPopisArtikalaNaSkladistu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNazivArtikla;
        private System.Windows.Forms.TextBox inputTrenutnoStanje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputMinimalnaKolicina;
        private System.Windows.Forms.TextBox inputMaksimalnaKolicina;
        private System.Windows.Forms.DateTimePicker inputDostavljen;
        private System.Windows.Forms.DateTimePicker inputRokTrajanja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button inputOsvjeziPrikaz;
    }
}