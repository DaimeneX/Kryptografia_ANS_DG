namespace Szyfrowanie_RSA.Kontrolki
{
    partial class SzyfrowanieTekstu
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
            this.text_box_text_to_encrypt = new System.Windows.Forms.RichTextBox();
            this.text_box_encrypted_text = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_box_my_public_key = new System.Windows.Forms.TextBox();
            this.text_box_my_private_key = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_encrypttext = new System.Windows.Forms.Button();
            this.btn_copy_my_public_key = new System.Windows.Forms.Button();
            this.btn_copy_encrypted_text = new System.Windows.Forms.Button();
            this.btn_copy_my_private_key = new System.Windows.Forms.Button();
            this.button_generate_private_key = new System.Windows.Forms.Button();
            this.button_generate_public_key = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_box_text_to_encrypt
            // 
            this.text_box_text_to_encrypt.Location = new System.Drawing.Point(23, 87);
            this.text_box_text_to_encrypt.Name = "text_box_text_to_encrypt";
            this.text_box_text_to_encrypt.Size = new System.Drawing.Size(254, 96);
            this.text_box_text_to_encrypt.TabIndex = 0;
            this.text_box_text_to_encrypt.Text = "";
            // 
            // text_box_encrypted_text
            // 
            this.text_box_encrypted_text.Location = new System.Drawing.Point(319, 87);
            this.text_box_encrypted_text.Name = "text_box_encrypted_text";
            this.text_box_encrypted_text.ReadOnly = true;
            this.text_box_encrypted_text.Size = new System.Drawing.Size(254, 96);
            this.text_box_encrypted_text.TabIndex = 1;
            this.text_box_encrypted_text.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tekst do zaszyfrowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tekst zaszyfrowany";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Szyfrowanie Tekstu";
            // 
            // text_box_my_public_key
            // 
            this.text_box_my_public_key.Location = new System.Drawing.Point(23, 217);
            this.text_box_my_public_key.Name = "text_box_my_public_key";
            this.text_box_my_public_key.ReadOnly = true;
            this.text_box_my_public_key.Size = new System.Drawing.Size(550, 23);
            this.text_box_my_public_key.TabIndex = 5;
            // 
            // text_box_my_private_key
            // 
            this.text_box_my_private_key.Location = new System.Drawing.Point(23, 273);
            this.text_box_my_private_key.Name = "text_box_my_private_key";
            this.text_box_my_private_key.ReadOnly = true;
            this.text_box_my_private_key.Size = new System.Drawing.Size(550, 23);
            this.text_box_my_private_key.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Klucz publiczny";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Klucz prywatny";
            // 
            // btn_encrypttext
            // 
            this.btn_encrypttext.Location = new System.Drawing.Point(23, 302);
            this.btn_encrypttext.Name = "btn_encrypttext";
            this.btn_encrypttext.Size = new System.Drawing.Size(156, 27);
            this.btn_encrypttext.TabIndex = 13;
            this.btn_encrypttext.Text = "Zaszyfruj";
            this.btn_encrypttext.UseVisualStyleBackColor = true;
            this.btn_encrypttext.Click += new System.EventHandler(this.btn_encrypttext_Click);
            // 
            // btn_copy_my_public_key
            // 
            this.btn_copy_my_public_key.Location = new System.Drawing.Point(118, 195);
            this.btn_copy_my_public_key.Name = "btn_copy_my_public_key";
            this.btn_copy_my_public_key.Size = new System.Drawing.Size(52, 23);
            this.btn_copy_my_public_key.TabIndex = 68;
            this.btn_copy_my_public_key.Text = "Kopiuj";
            this.btn_copy_my_public_key.UseVisualStyleBackColor = true;
            this.btn_copy_my_public_key.Click += new System.EventHandler(this.btn_copy_my_public_key_Click);
            // 
            // btn_copy_encrypted_text
            // 
            this.btn_copy_encrypted_text.Location = new System.Drawing.Point(431, 65);
            this.btn_copy_encrypted_text.Name = "btn_copy_encrypted_text";
            this.btn_copy_encrypted_text.Size = new System.Drawing.Size(52, 23);
            this.btn_copy_encrypted_text.TabIndex = 70;
            this.btn_copy_encrypted_text.Text = "Kopiuj";
            this.btn_copy_encrypted_text.UseVisualStyleBackColor = true;
            this.btn_copy_encrypted_text.Click += new System.EventHandler(this.btn_copy_encrypted_text_Click);
            // 
            // btn_copy_my_private_key
            // 
            this.btn_copy_my_private_key.Location = new System.Drawing.Point(118, 251);
            this.btn_copy_my_private_key.Name = "btn_copy_my_private_key";
            this.btn_copy_my_private_key.Size = new System.Drawing.Size(52, 23);
            this.btn_copy_my_private_key.TabIndex = 71;
            this.btn_copy_my_private_key.Text = "Kopiuj";
            this.btn_copy_my_private_key.UseVisualStyleBackColor = true;
            this.btn_copy_my_private_key.Click += new System.EventHandler(this.btn_copy_my_private_key_Click);
            // 
            // button_generate_private_key
            // 
            this.button_generate_private_key.Location = new System.Drawing.Point(176, 251);
            this.button_generate_private_key.Name = "button_generate_private_key";
            this.button_generate_private_key.Size = new System.Drawing.Size(101, 23);
            this.button_generate_private_key.TabIndex = 73;
            this.button_generate_private_key.Text = "Generuj";
            this.button_generate_private_key.UseVisualStyleBackColor = true;
            this.button_generate_private_key.Click += new System.EventHandler(this.button_generate_private_key_Click);
            // 
            // button_generate_public_key
            // 
            this.button_generate_public_key.Location = new System.Drawing.Point(176, 195);
            this.button_generate_public_key.Name = "button_generate_public_key";
            this.button_generate_public_key.Size = new System.Drawing.Size(101, 23);
            this.button_generate_public_key.TabIndex = 72;
            this.button_generate_public_key.Text = "Generuj";
            this.button_generate_public_key.UseVisualStyleBackColor = true;
            this.button_generate_public_key.Click += new System.EventHandler(this.button_generate_public_key_Click);
            // 
            // SzyfrowanieTekstu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_generate_private_key);
            this.Controls.Add(this.button_generate_public_key);
            this.Controls.Add(this.btn_copy_my_private_key);
            this.Controls.Add(this.btn_copy_encrypted_text);
            this.Controls.Add(this.btn_copy_my_public_key);
            this.Controls.Add(this.btn_encrypttext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_box_my_private_key);
            this.Controls.Add(this.text_box_my_public_key);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_box_encrypted_text);
            this.Controls.Add(this.text_box_text_to_encrypt);
            this.Name = "SzyfrowanieTekstu";
            this.Size = new System.Drawing.Size(594, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox text_box_text_to_encrypt;
        private RichTextBox text_box_encrypted_text;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox text_box_my_public_key;
        private TextBox text_box_my_private_key;
        private Label label4;
        private Label label5;
        private Button btn_encrypttext;
        private Button btn_copy_my_public_key;
        private Button btn_copy_encrypted_text;
        private Button btn_copy_my_private_key;
        private Button button_generate_private_key;
        private Button button_generate_public_key;
    }
}
