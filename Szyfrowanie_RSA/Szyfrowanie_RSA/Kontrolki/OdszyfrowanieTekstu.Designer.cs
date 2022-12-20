namespace Szyfrowanie_RSA.Kontrolki
{
    partial class OdszyfrowanieTekstu
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_decrypttext = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_box_decrypted_text = new System.Windows.Forms.RichTextBox();
            this.text_box_encrypted_text = new System.Windows.Forms.RichTextBox();
            this.btn_copy_decrypted_text = new System.Windows.Forms.Button();
            this.text_box_private_key = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_decrypttext
            // 
            this.btn_decrypttext.Location = new System.Drawing.Point(22, 340);
            this.btn_decrypttext.Name = "btn_decrypttext";
            this.btn_decrypttext.Size = new System.Drawing.Size(156, 27);
            this.btn_decrypttext.TabIndex = 28;
            this.btn_decrypttext.Text = "Odszyfruj";
            this.btn_decrypttext.UseVisualStyleBackColor = true;
            this.btn_decrypttext.Click += new System.EventHandler(this.btn_decrypttext_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Klucz prywatny";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "Odszyfrowanie Tekstu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tekst odszyfrowany";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tekst do odszyfrowania";
            // 
            // text_box_decrypted_text
            // 
            this.text_box_decrypted_text.Location = new System.Drawing.Point(318, 87);
            this.text_box_decrypted_text.Name = "text_box_decrypted_text";
            this.text_box_decrypted_text.ReadOnly = true;
            this.text_box_decrypted_text.Size = new System.Drawing.Size(254, 96);
            this.text_box_decrypted_text.TabIndex = 16;
            this.text_box_decrypted_text.Text = "";
            // 
            // text_box_encrypted_text
            // 
            this.text_box_encrypted_text.Location = new System.Drawing.Point(22, 87);
            this.text_box_encrypted_text.Name = "text_box_encrypted_text";
            this.text_box_encrypted_text.Size = new System.Drawing.Size(254, 96);
            this.text_box_encrypted_text.TabIndex = 15;
            this.text_box_encrypted_text.Text = "";
            // 
            // btn_copy_decrypted_text
            // 
            this.btn_copy_decrypted_text.Location = new System.Drawing.Point(433, 65);
            this.btn_copy_decrypted_text.Name = "btn_copy_decrypted_text";
            this.btn_copy_decrypted_text.Size = new System.Drawing.Size(52, 23);
            this.btn_copy_decrypted_text.TabIndex = 71;
            this.btn_copy_decrypted_text.Text = "Kopiuj";
            this.btn_copy_decrypted_text.UseVisualStyleBackColor = true;
            this.btn_copy_decrypted_text.Click += new System.EventHandler(this.btn_copy_decrypted_text_Click);
            // 
            // text_box_private_key
            // 
            this.text_box_private_key.Location = new System.Drawing.Point(22, 215);
            this.text_box_private_key.Name = "text_box_private_key";
            this.text_box_private_key.Size = new System.Drawing.Size(550, 119);
            this.text_box_private_key.TabIndex = 72;
            this.text_box_private_key.Text = "";
            // 
            // OdszyfrowanieTekstu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.text_box_private_key);
            this.Controls.Add(this.btn_copy_decrypted_text);
            this.Controls.Add(this.btn_decrypttext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_box_decrypted_text);
            this.Controls.Add(this.text_box_encrypted_text);
            this.Name = "OdszyfrowanieTekstu";
            this.Size = new System.Drawing.Size(594, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_decrypttext;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox text_box_decrypted_text;
        private RichTextBox text_box_encrypted_text;
        private Button btn_copy_decrypted_text;
        private RichTextBox text_box_private_key;
    }
}
