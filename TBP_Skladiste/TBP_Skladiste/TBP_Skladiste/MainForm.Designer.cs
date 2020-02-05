namespace TBP_Skladiste
{
    partial class MainForm
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
            this.inputDodajNoviArtikl = new System.Windows.Forms.Button();
            this.unosGlavnaStatistika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputDodajNoviArtikl
            // 
            this.inputDodajNoviArtikl.Location = new System.Drawing.Point(13, 13);
            this.inputDodajNoviArtikl.Name = "inputDodajNoviArtikl";
            this.inputDodajNoviArtikl.Size = new System.Drawing.Size(100, 37);
            this.inputDodajNoviArtikl.TabIndex = 2;
            this.inputDodajNoviArtikl.Text = "Dodaj artikl na skladiste";
            this.inputDodajNoviArtikl.UseVisualStyleBackColor = true;
            this.inputDodajNoviArtikl.Click += new System.EventHandler(this.inputDodajNoviArtikl_Click);
            // 
            // unosGlavnaStatistika
            // 
            this.unosGlavnaStatistika.Location = new System.Drawing.Point(374, 217);
            this.unosGlavnaStatistika.Name = "unosGlavnaStatistika";
            this.unosGlavnaStatistika.Size = new System.Drawing.Size(218, 99);
            this.unosGlavnaStatistika.TabIndex = 3;
            this.unosGlavnaStatistika.Text = "Glavna statistika skladista";
            this.unosGlavnaStatistika.UseVisualStyleBackColor = true;
            this.unosGlavnaStatistika.Click += new System.EventHandler(this.unosGlavnaStatistika_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 556);
            this.Controls.Add(this.unosGlavnaStatistika);
            this.Controls.Add(this.inputDodajNoviArtikl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button inputDodajNoviArtikl;
        private System.Windows.Forms.Button unosGlavnaStatistika;
    }
}

