using static Szyfrowanie_RSA.Program;

namespace Szyfrowanie_RSA.Kontrolki
{
    public partial class SzyfrowanieTekstu : UserControl
    {

        string? textToEncrypt;
        string? encryptedText;
        RSAEncryptor enc;

        public SzyfrowanieTekstu()
        {
            InitializeComponent();
            enc = new RSAEncryptor();
        }
        private void btn_copy_my_public_key_Click(object sender, EventArgs e)
        {
            if (text_box_my_public_key.Text != null)
            {
                Clipboard.SetText(text_box_my_public_key.Text);
            }
        }
        private void btn_copy_encrypted_text_Click(object sender, EventArgs e)
        {
            if (text_box_encrypted_text.Text != null)
            {
                Clipboard.SetText(text_box_encrypted_text.Text);
            }
        }

        private void btn_copy_my_private_key_Click(object sender, EventArgs e)
        {
            if (text_box_my_private_key.Text != null)
            {
                Clipboard.SetText(text_box_my_private_key.Text);
            }
        }

        private void button_generate_private_key_Click(object sender, EventArgs e)
        {
            enc.GeneratePrivateKey();
            text_box_my_private_key.Text = enc.privateKeyString;
        }

        private void button_generate_public_key_Click(object sender, EventArgs e)
        {
            enc.GeneratePublicKey();
            text_box_my_public_key.Text = enc.publicKeyString;
        }
        private void btn_encrypttext_Click(object sender, EventArgs e)
        {
            if (text_box_text_to_encrypt.Text != "" && text_box_my_public_key.Text != "")
            {
                textToEncrypt = text_box_text_to_encrypt.Text;
                enc.publicKeyString = text_box_my_public_key.Text;
                encryptedText = enc.EncryptText(textToEncrypt, enc.publicKeyString);
                text_box_encrypted_text.Text = encryptedText;
            }
            else
            {
                MessageBox.Show("Pola z tekstem do zaszyfrowania i kluczem publicznym nie mogą być puste!", "Uwaga");
            }
        }
    }
}
