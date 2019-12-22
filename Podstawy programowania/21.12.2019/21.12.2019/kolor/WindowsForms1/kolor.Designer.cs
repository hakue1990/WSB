namespace WindowsForms1
{
    partial class kolor
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
            this.btmClose = new System.Windows.Forms.Button();
            this.btmCloseApp = new System.Windows.Forms.Button();
            this.Bok = new System.Windows.Forms.Label();
            this.lblKomunikat = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btmUkryj = new System.Windows.Forms.Button();
            this.btmZmienKolor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmClose
            // 
            this.btmClose.Location = new System.Drawing.Point(62, 293);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(75, 41);
            this.btmClose.TabIndex = 0;
            this.btmClose.Text = "Zamknij okno";
            this.btmClose.UseVisualStyleBackColor = true;
            this.btmClose.Click += new System.EventHandler(this.btmClose_Click);
            // 
            // btmCloseApp
            // 
            this.btmCloseApp.Location = new System.Drawing.Point(192, 293);
            this.btmCloseApp.Name = "btmCloseApp";
            this.btmCloseApp.Size = new System.Drawing.Size(75, 41);
            this.btmCloseApp.TabIndex = 1;
            this.btmCloseApp.Text = "Zamknij aplikacje";
            this.btmCloseApp.UseVisualStyleBackColor = true;
            this.btmCloseApp.Click += new System.EventHandler(this.btmCloseApp_Click);
            // 
            // Bok
            // 
            this.Bok.AutoSize = true;
            this.Bok.Location = new System.Drawing.Point(59, 95);
            this.Bok.Name = "Bok";
            this.Bok.Size = new System.Drawing.Size(25, 13);
            this.Bok.TabIndex = 2;
            this.Bok.Text = "bok";
            // 
            // lblKomunikat
            // 
            this.lblKomunikat.AutoSize = true;
            this.lblKomunikat.BackColor = System.Drawing.SystemColors.Control;
            this.lblKomunikat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKomunikat.Location = new System.Drawing.Point(164, 32);
            this.lblKomunikat.Name = "lblKomunikat";
            this.lblKomunikat.Size = new System.Drawing.Size(0, 13);
            this.lblKomunikat.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btmUkryj
            // 
            this.btmUkryj.Location = new System.Drawing.Point(138, 148);
            this.btmUkryj.Name = "btmUkryj";
            this.btmUkryj.Size = new System.Drawing.Size(75, 23);
            this.btmUkryj.TabIndex = 5;
            this.btmUkryj.Text = "Pokaż/Ukryj";
            this.btmUkryj.UseVisualStyleBackColor = true;
            this.btmUkryj.Click += new System.EventHandler(this.btmUkryj_Click);
            // 
            // btmZmienKolor
            // 
            this.btmZmienKolor.Location = new System.Drawing.Point(138, 210);
            this.btmZmienKolor.Name = "btmZmienKolor";
            this.btmZmienKolor.Size = new System.Drawing.Size(75, 23);
            this.btmZmienKolor.TabIndex = 6;
            this.btmZmienKolor.Text = "Zmień kolor";
            this.btmZmienKolor.UseVisualStyleBackColor = true;
            this.btmZmienKolor.Click += new System.EventHandler(this.btmZmienKolor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(255, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(267, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // kolor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 381);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btmZmienKolor);
            this.Controls.Add(this.btmUkryj);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblKomunikat);
            this.Controls.Add(this.Bok);
            this.Controls.Add(this.btmCloseApp);
            this.Controls.Add(this.btmClose);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "kolor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kolor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kolor_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmClose;
        private System.Windows.Forms.Button btmCloseApp;
        private System.Windows.Forms.Label Bok;
        private System.Windows.Forms.Label lblKomunikat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btmUkryj;
        private System.Windows.Forms.Button btmZmienKolor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    }
}