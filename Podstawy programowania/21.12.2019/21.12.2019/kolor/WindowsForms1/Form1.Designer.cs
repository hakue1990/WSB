namespace WindowsForms1
{
    partial class Pole_i_obwód
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btmClear = new System.Windows.Forms.Button();
            this.btmClose = new System.Windows.Forms.Button();
            this.lblBok = new System.Windows.Forms.Label();
            this.lblPole = new System.Windows.Forms.Label();
            this.lblObwod = new System.Windows.Forms.Label();
            this.Bok = new System.Windows.Forms.TextBox();
            this.Pole = new System.Windows.Forms.TextBox();
            this.Obwod = new System.Windows.Forms.TextBox();
            this.lblKomunikat = new System.Windows.Forms.Label();
            this.btmKolor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmClear
            // 
            this.btmClear.Location = new System.Drawing.Point(47, 339);
            this.btmClear.Name = "btmClear";
            this.btmClear.Size = new System.Drawing.Size(75, 23);
            this.btmClear.TabIndex = 0;
            this.btmClear.Text = "Clear";
            this.btmClear.UseVisualStyleBackColor = true;
            this.btmClear.Click += new System.EventHandler(this.btmClear_Click);
            // 
            // btmClose
            // 
            this.btmClose.Location = new System.Drawing.Point(199, 339);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(75, 23);
            this.btmClose.TabIndex = 1;
            this.btmClose.Text = "Close";
            this.btmClose.UseVisualStyleBackColor = true;
            this.btmClose.Click += new System.EventHandler(this.btmClose_Click);
            // 
            // lblBok
            // 
            this.lblBok.AutoSize = true;
            this.lblBok.Location = new System.Drawing.Point(44, 20);
            this.lblBok.Name = "lblBok";
            this.lblBok.Size = new System.Drawing.Size(26, 13);
            this.lblBok.TabIndex = 2;
            this.lblBok.Text = "Bok";
            // 
            // lblPole
            // 
            this.lblPole.AutoSize = true;
            this.lblPole.Location = new System.Drawing.Point(44, 102);
            this.lblPole.Name = "lblPole";
            this.lblPole.Size = new System.Drawing.Size(28, 13);
            this.lblPole.TabIndex = 3;
            this.lblPole.Text = "Pole";
            // 
            // lblObwod
            // 
            this.lblObwod.AutoSize = true;
            this.lblObwod.Location = new System.Drawing.Point(44, 188);
            this.lblObwod.Name = "lblObwod";
            this.lblObwod.Size = new System.Drawing.Size(41, 13);
            this.lblObwod.TabIndex = 4;
            this.lblObwod.Text = "Obwód";
            // 
            // Bok
            // 
            this.Bok.Location = new System.Drawing.Point(159, 17);
            this.Bok.Name = "Bok";
            this.Bok.Size = new System.Drawing.Size(100, 20);
            this.Bok.TabIndex = 5;
            this.Bok.AcceptsTabChanged += new System.EventHandler(this.Bok_AcceptsTabChanged_1);
            this.Bok.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Pole
            // 
            this.Pole.Location = new System.Drawing.Point(159, 95);
            this.Pole.Name = "Pole";
            this.Pole.ReadOnly = true;
            this.Pole.Size = new System.Drawing.Size(100, 20);
            this.Pole.TabIndex = 6;
            this.Pole.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Obwod
            // 
            this.Obwod.Location = new System.Drawing.Point(159, 181);
            this.Obwod.Name = "Obwod";
            this.Obwod.ReadOnly = true;
            this.Obwod.Size = new System.Drawing.Size(100, 20);
            this.Obwod.TabIndex = 7;
            // 
            // lblKomunikat
            // 
            this.lblKomunikat.AutoSize = true;
            this.lblKomunikat.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblKomunikat.ForeColor = System.Drawing.Color.Red;
            this.lblKomunikat.Location = new System.Drawing.Point(335, 41);
            this.lblKomunikat.MinimumSize = new System.Drawing.Size(50, 20);
            this.lblKomunikat.Name = "lblKomunikat";
            this.lblKomunikat.Size = new System.Drawing.Size(50, 20);
            this.lblKomunikat.TabIndex = 8;
            // 
            // btmKolor
            // 
            this.btmKolor.Location = new System.Drawing.Point(128, 257);
            this.btmKolor.Name = "btmKolor";
            this.btmKolor.Size = new System.Drawing.Size(75, 23);
            this.btmKolor.TabIndex = 9;
            this.btmKolor.Text = "kolor";
            this.btmKolor.UseVisualStyleBackColor = true;
            this.btmKolor.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pole_i_obwód
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 398);
            this.Controls.Add(this.btmKolor);
            this.Controls.Add(this.lblKomunikat);
            this.Controls.Add(this.Obwod);
            this.Controls.Add(this.Pole);
            this.Controls.Add(this.Bok);
            this.Controls.Add(this.lblObwod);
            this.Controls.Add(this.lblPole);
            this.Controls.Add(this.lblBok);
            this.Controls.Add(this.btmClose);
            this.Controls.Add(this.btmClear);
            this.Name = "Pole_i_obwód";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmClear;
        private System.Windows.Forms.Button btmClose;
        private System.Windows.Forms.Label lblBok;
        private System.Windows.Forms.Label lblPole;
        private System.Windows.Forms.Label lblObwod;
        private System.Windows.Forms.TextBox Bok;
        private System.Windows.Forms.TextBox Pole;
        private System.Windows.Forms.TextBox Obwod;
        private System.Windows.Forms.Label lblKomunikat;
        private System.Windows.Forms.Button btmKolor;
    }
}

