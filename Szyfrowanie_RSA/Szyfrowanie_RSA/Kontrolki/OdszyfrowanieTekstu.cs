using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Szyfrowanie_RSA.Program;

namespace Szyfrowanie_RSA.Kontrolki
{
    public partial class OdszyfrowanieTekstu : UserControl
    {
        string? textToDecrypt;
        string? decryptedText;
        RSAEncryptor enc;
        public OdszyfrowanieTekstu()
        {
            InitializeComponent();
            enc = new RSAEncryptor();
        }

        private void btn_decrypttext_Click(object sender, EventArgs e)
        {
            if (text_box_encrypted_text.Text != "" && text_box_private_key.Text != "")
            {
                textToDecrypt = text_box_encrypted_text.Text;
                enc.privateKeyString = text_box_private_key.Text;
                decryptedText = enc.DecryptText(textToDecrypt, enc.privateKeyString);
                text_box_decrypted_text.Text = decryptedText;
            }
            else
            {
                MessageBox.Show("Tekst do odszyfrowania danych wejściowych i klucz prywatny nie może być pusty!", "Uwaga");
            }
        }
        private void btn_copy_decrypted_text_Click(object sender, EventArgs e)
        {
            if (text_box_decrypted_text.Text != null)
            {
                Clipboard.SetText(text_box_decrypted_text.Text);
            }
        }
    }
}
