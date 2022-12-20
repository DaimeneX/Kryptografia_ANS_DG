namespace Szyfrowanie_AES
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.szyfTekstu = new System.Windows.Forms.Button();
            this.szyfPliku = new System.Windows.Forms.Button();
            this.OdszyfTekstu = new System.Windows.Forms.Button();
            this.OdszyfPliku = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.odszyfrowaniePliku1 = new Szyfrowanie_AES.Kontrolki.OdszyfrowaniePliku();
            this.odszyfrowanieTekstu1 = new Szyfrowanie_AES.Kontrolki.OdszyfrowanieTekstu();
            this.szyfrowaniePliku1 = new Szyfrowanie_AES.Kontrolki.SzyfrowaniePliku();
            this.szyfrowanieTekstu1 = new Szyfrowanie_AES.Kontrolki.SzyfrowanieTekstu();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // szyfTekstu
            // 
            this.szyfTekstu.Location = new System.Drawing.Point(12, 12);
            this.szyfTekstu.Name = "szyfTekstu";
            this.szyfTekstu.Size = new System.Drawing.Size(177, 36);
            this.szyfTekstu.TabIndex = 0;
            this.szyfTekstu.Text = "Szyfrowanie Tekstu";
            this.szyfTekstu.UseVisualStyleBackColor = true;
            this.szyfTekstu.Click += new System.EventHandler(this.szyfTekstu_Click);
            // 
            // szyfPliku
            // 
            this.szyfPliku.Location = new System.Drawing.Point(12, 54);
            this.szyfPliku.Name = "szyfPliku";
            this.szyfPliku.Size = new System.Drawing.Size(177, 36);
            this.szyfPliku.TabIndex = 1;
            this.szyfPliku.Text = "Szyfrowanie Pliku";
            this.szyfPliku.UseVisualStyleBackColor = true;
            this.szyfPliku.Click += new System.EventHandler(this.szyfPliku_Click);
            // 
            // OdszyfTekstu
            // 
            this.OdszyfTekstu.Location = new System.Drawing.Point(12, 96);
            this.OdszyfTekstu.Name = "OdszyfTekstu";
            this.OdszyfTekstu.Size = new System.Drawing.Size(177, 36);
            this.OdszyfTekstu.TabIndex = 2;
            this.OdszyfTekstu.Text = "Odszyfrowanie Tekstu";
            this.OdszyfTekstu.UseVisualStyleBackColor = true;
            this.OdszyfTekstu.Click += new System.EventHandler(this.OdszyfTekstu_Click);
            // 
            // OdszyfPliku
            // 
            this.OdszyfPliku.Location = new System.Drawing.Point(12, 138);
            this.OdszyfPliku.Name = "OdszyfPliku";
            this.OdszyfPliku.Size = new System.Drawing.Size(177, 36);
            this.OdszyfPliku.TabIndex = 3;
            this.OdszyfPliku.Text = "Odszyfrowanie Pliku";
            this.OdszyfPliku.UseVisualStyleBackColor = true;
            this.OdszyfPliku.Click += new System.EventHandler(this.OdszyfPliku_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OdszyfPliku);
            this.panel1.Controls.Add(this.OdszyfTekstu);
            this.panel1.Controls.Add(this.szyfPliku);
            this.panel1.Controls.Add(this.szyfTekstu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // odszyfrowaniePliku1
            // 
            this.odszyfrowaniePliku1.Location = new System.Drawing.Point(206, 0);
            this.odszyfrowaniePliku1.Name = "odszyfrowaniePliku1";
            this.odszyfrowaniePliku1.Size = new System.Drawing.Size(594, 450);
            this.odszyfrowaniePliku1.TabIndex = 1;
            // 
            // odszyfrowanieTekstu1
            // 
            this.odszyfrowanieTekstu1.Location = new System.Drawing.Point(206, 0);
            this.odszyfrowanieTekstu1.Name = "odszyfrowanieTekstu1";
            this.odszyfrowanieTekstu1.Size = new System.Drawing.Size(594, 450);
            this.odszyfrowanieTekstu1.TabIndex = 2;
            // 
            // szyfrowaniePliku1
            // 
            this.szyfrowaniePliku1.Location = new System.Drawing.Point(206, 0);
            this.szyfrowaniePliku1.Name = "szyfrowaniePliku1";
            this.szyfrowaniePliku1.Size = new System.Drawing.Size(594, 450);
            this.szyfrowaniePliku1.TabIndex = 3;
            // 
            // szyfrowanieTekstu1
            // 
            this.szyfrowanieTekstu1.Location = new System.Drawing.Point(206, 0);
            this.szyfrowanieTekstu1.Name = "szyfrowanieTekstu1";
            this.szyfrowanieTekstu1.Size = new System.Drawing.Size(594, 450);
            this.szyfrowanieTekstu1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(206, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 450);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.szyfrowanieTekstu1);
            this.Controls.Add(this.szyfrowaniePliku1);
            this.Controls.Add(this.odszyfrowanieTekstu1);
            this.Controls.Add(this.odszyfrowaniePliku1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Program Szyfrowania AES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button szyfTekstu;
        private Button szyfPliku;
        private Button OdszyfTekstu;
        private Button OdszyfPliku;
        private Panel panel1;
        private Kontrolki.OdszyfrowaniePliku odszyfrowaniePliku1;
        private Kontrolki.OdszyfrowanieTekstu odszyfrowanieTekstu1;
        private Kontrolki.SzyfrowaniePliku szyfrowaniePliku1;
        private Kontrolki.SzyfrowanieTekstu szyfrowanieTekstu1;
        private Panel panel2;
    }
}