namespace Szyfrowanie_RSA.Kontrolki
{
    partial class OdszyfrowaniePliku
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
            this.text_box_decrypted_file_save_location = new System.Windows.Forms.TextBox();
            this.text_box_file_location_to_decrypt = new System.Windows.Forms.TextBox();
            this.btn_decryptfile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_select_file_location = new System.Windows.Forms.Button();
            this.button_select_file_save = new System.Windows.Forms.Button();
            this.text_box_private_key = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // text_box_decrypted_file_save_location
            // 
            this.text_box_decrypted_file_save_location.Location = new System.Drawing.Point(23, 143);
            this.text_box_decrypted_file_save_location.Name = "text_box_decrypted_file_save_location";
            this.text_box_decrypted_file_save_location.Size = new System.Drawing.Size(459, 23);
            this.text_box_decrypted_file_save_location.TabIndex = 61;
            // 
            // text_box_file_location_to_decrypt
            // 
            this.text_box_file_location_to_decrypt.Location = new System.Drawing.Point(23, 87);
            this.text_box_file_location_to_decrypt.Name = "text_box_file_location_to_decrypt";
            this.text_box_file_location_to_decrypt.Size = new System.Drawing.Size(459, 23);
            this.text_box_file_location_to_decrypt.TabIndex = 60;
            // 
            // btn_decryptfile
            // 
            this.btn_decryptfile.Location = new System.Drawing.Point(23, 324);
            this.btn_decryptfile.Name = "btn_decryptfile";
            this.btn_decryptfile.Size = new System.Drawing.Size(156, 27);
            this.btn_decryptfile.TabIndex = 58;
            this.btn_decryptfile.Text = "Odszyfruj";
            this.btn_decryptfile.UseVisualStyleBackColor = true;
            this.btn_decryptfile.Click += new System.EventHandler(this.btn_decryptfile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 54;
            this.label5.Text = "Klucz prywatny";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 30);
            this.label3.TabIndex = 49;
            this.label3.Text = "Odszyfrowanie pliku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 15);
            this.label2.TabIndex = 48;
            this.label2.Text = "Ścieżka zapisu pliku odszyfrowanego";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "Ścieżka do pliku do odszyfrowania";
            // 
            // button_select_file_location
            // 
            this.button_select_file_location.Location = new System.Drawing.Point(488, 87);
            this.button_select_file_location.Name = "button_select_file_location";
            this.button_select_file_location.Size = new System.Drawing.Size(91, 23);
            this.button_select_file_location.TabIndex = 63;
            this.button_select_file_location.Text = "Wybierz plik";
            this.button_select_file_location.UseVisualStyleBackColor = true;
            this.button_select_file_location.Click += new System.EventHandler(this.button_select_file_location_Click);
            // 
            // button_select_file_save
            // 
            this.button_select_file_save.Location = new System.Drawing.Point(488, 143);
            this.button_select_file_save.Name = "button_select_file_save";
            this.button_select_file_save.Size = new System.Drawing.Size(91, 23);
            this.button_select_file_save.TabIndex = 64;
            this.button_select_file_save.Text = "Zapisz w";
            this.button_select_file_save.UseVisualStyleBackColor = true;
            this.button_select_file_save.Click += new System.EventHandler(this.button_select_file_save_Click);
            // 
            // text_box_private_key
            // 
            this.text_box_private_key.Location = new System.Drawing.Point(23, 199);
            this.text_box_private_key.Name = "text_box_private_key";
            this.text_box_private_key.Size = new System.Drawing.Size(550, 119);
            this.text_box_private_key.TabIndex = 73;
            this.text_box_private_key.Text = "";
            // 
            // OdszyfrowaniePliku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.text_box_private_key);
            this.Controls.Add(this.button_select_file_save);
            this.Controls.Add(this.button_select_file_location);
            this.Controls.Add(this.text_box_decrypted_file_save_location);
            this.Controls.Add(this.text_box_file_location_to_decrypt);
            this.Controls.Add(this.btn_decryptfile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OdszyfrowaniePliku";
            this.Size = new System.Drawing.Size(594, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox text_box_decrypted_file_save_location;
        private TextBox text_box_file_location_to_decrypt;
        private Button btn_decryptfile;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_select_file_location;
        private Button button_select_file_save;
        private RichTextBox text_box_private_key;
    }
}
