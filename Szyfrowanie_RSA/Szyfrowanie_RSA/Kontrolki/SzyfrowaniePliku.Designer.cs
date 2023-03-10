namespace Szyfrowanie_RSA.Kontrolki
{
    partial class SzyfrowaniePliku
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
            this.btn_encryptfile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.text_box_private_key = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_box_file_to_encrypt_location = new System.Windows.Forms.TextBox();
            this.text_box_encrypted_file_save_location = new System.Windows.Forms.TextBox();
            this.btn_copy_private_key = new System.Windows.Forms.Button();
            this.button_select_file_location = new System.Windows.Forms.Button();
            this.button_select_file_save = new System.Windows.Forms.Button();
            this.button_copy_public_key = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.text_box_public_key = new System.Windows.Forms.TextBox();
            this.button_generate_private_key = new System.Windows.Forms.Button();
            this.button_generate_public_key = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_encryptfile
            // 
            this.btn_encryptfile.Location = new System.Drawing.Point(21, 293);
            this.btn_encryptfile.Name = "btn_encryptfile";
            this.btn_encryptfile.Size = new System.Drawing.Size(156, 27);
            this.btn_encryptfile.TabIndex = 43;
            this.btn_encryptfile.Text = "Zaszyfruj";
            this.btn_encryptfile.UseVisualStyleBackColor = true;
            this.btn_encryptfile.Click += new System.EventHandler(this.btn_encryptfile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Klucz prywatny";
            // 
            // text_box_private_key
            // 
            this.text_box_private_key.Location = new System.Drawing.Point(21, 264);
            this.text_box_private_key.Name = "text_box_private_key";
            this.text_box_private_key.Size = new System.Drawing.Size(550, 23);
            this.text_box_private_key.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 30);
            this.label3.TabIndex = 34;
            this.label3.Text = "Szyfrowanie pliku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ścieżka zapisu pliku zaszyfrowanego";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ścieżka do pliku do zaszyfrowania";
            // 
            // text_box_file_to_encrypt_location
            // 
            this.text_box_file_to_encrypt_location.Location = new System.Drawing.Point(21, 87);
            this.text_box_file_to_encrypt_location.Name = "text_box_file_to_encrypt_location";
            this.text_box_file_to_encrypt_location.Size = new System.Drawing.Size(441, 23);
            this.text_box_file_to_encrypt_location.TabIndex = 45;
            // 
            // text_box_encrypted_file_save_location
            // 
            this.text_box_encrypted_file_save_location.Location = new System.Drawing.Point(21, 143);
            this.text_box_encrypted_file_save_location.Name = "text_box_encrypted_file_save_location";
            this.text_box_encrypted_file_save_location.Size = new System.Drawing.Size(441, 23);
            this.text_box_encrypted_file_save_location.TabIndex = 46;
            // 
            // btn_copy_private_key
            // 
            this.btn_copy_private_key.Location = new System.Drawing.Point(114, 242);
            this.btn_copy_private_key.Name = "btn_copy_private_key";
            this.btn_copy_private_key.Size = new System.Drawing.Size(52, 23);
            this.btn_copy_private_key.TabIndex = 67;
            this.btn_copy_private_key.Text = "Kopiuj";
            this.btn_copy_private_key.UseVisualStyleBackColor = true;
            this.btn_copy_private_key.Click += new System.EventHandler(this.btn_copy_private_key_Click);
            // 
            // button_select_file_location
            // 
            this.button_select_file_location.Location = new System.Drawing.Point(468, 87);
            this.button_select_file_location.Name = "button_select_file_location";
            this.button_select_file_location.Size = new System.Drawing.Size(103, 23);
            this.button_select_file_location.TabIndex = 69;
            this.button_select_file_location.Text = "Wybierz plik";
            this.button_select_file_location.UseVisualStyleBackColor = true;
            this.button_select_file_location.Click += new System.EventHandler(this.button_select_file_location_Click);
            // 
            // button_select_file_save
            // 
            this.button_select_file_save.Location = new System.Drawing.Point(468, 143);
            this.button_select_file_save.Name = "button_select_file_save";
            this.button_select_file_save.Size = new System.Drawing.Size(103, 23);
            this.button_select_file_save.TabIndex = 70;
            this.button_select_file_save.Text = "Zapisz w";
            this.button_select_file_save.UseVisualStyleBackColor = true;
            this.button_select_file_save.Click += new System.EventHandler(this.button_select_file_save_Click);
            // 
            // button_copy_public_key
            // 
            this.button_copy_public_key.Location = new System.Drawing.Point(114, 186);
            this.button_copy_public_key.Name = "button_copy_public_key";
            this.button_copy_public_key.Size = new System.Drawing.Size(52, 23);
            this.button_copy_public_key.TabIndex = 73;
            this.button_copy_public_key.Text = "Kopiuj";
            this.button_copy_public_key.UseVisualStyleBackColor = true;
            this.button_copy_public_key.Click += new System.EventHandler(this.btn_copy_public_key_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 72;
            this.label4.Text = "Klucz publiczny";
            // 
            // text_box_public_key
            // 
            this.text_box_public_key.Location = new System.Drawing.Point(21, 208);
            this.text_box_public_key.Name = "text_box_public_key";
            this.text_box_public_key.Size = new System.Drawing.Size(550, 23);
            this.text_box_public_key.TabIndex = 71;
            // 
            // button_generate_private_key
            // 
            this.button_generate_private_key.Location = new System.Drawing.Point(172, 242);
            this.button_generate_private_key.Name = "button_generate_private_key";
            this.button_generate_private_key.Size = new System.Drawing.Size(101, 23);
            this.button_generate_private_key.TabIndex = 75;
            this.button_generate_private_key.Text = "Generuj";
            this.button_generate_private_key.UseVisualStyleBackColor = true;
            this.button_generate_private_key.Click += new System.EventHandler(this.button_generate_private_key_Click);
            // 
            // button_generate_public_key
            // 
            this.button_generate_public_key.Location = new System.Drawing.Point(172, 186);
            this.button_generate_public_key.Name = "button_generate_public_key";
            this.button_generate_public_key.Size = new System.Drawing.Size(101, 23);
            this.button_generate_public_key.TabIndex = 74;
            this.button_generate_public_key.Text = "Generuj";
            this.button_generate_public_key.UseVisualStyleBackColor = true;
            this.button_generate_public_key.Click += new System.EventHandler(this.button_generate_public_key_Click);
            // 
            // SzyfrowaniePliku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_generate_private_key);
            this.Controls.Add(this.button_generate_public_key);
            this.Controls.Add(this.button_copy_public_key);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_box_public_key);
            this.Controls.Add(this.button_select_file_save);
            this.Controls.Add(this.button_select_file_location);
            this.Controls.Add(this.btn_copy_private_key);
            this.Controls.Add(this.text_box_encrypted_file_save_location);
            this.Controls.Add(this.text_box_file_to_encrypt_location);
            this.Controls.Add(this.btn_encryptfile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_box_private_key);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SzyfrowaniePliku";
            this.Size = new System.Drawing.Size(594, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_encryptfile;
        private Label label5;
        private TextBox text_box_private_key;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox text_box_file_to_encrypt_location;
        private TextBox text_box_encrypted_file_save_location;
        private Button btn_copy_private_key;
        private Button button_select_file_location;
        private Button button_select_file_save;
        private Button button_copy_public_key;
        private Label label4;
        private TextBox text_box_public_key;
        private Button button_generate_private_key;
        private Button button_generate_public_key;
    }
}
