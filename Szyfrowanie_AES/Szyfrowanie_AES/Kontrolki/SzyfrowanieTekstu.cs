using static Szyfrowanie_AES.Program;

namespace Szyfrowanie_AES.Kontrolki
{
    public partial class SzyfrowanieTekstu : UserControl
    {
        public SzyfrowanieTekstu()
        {
            InitializeComponent();
            KluczPubliczny();
            IVKey();
        }

        public void KluczPubliczny()
        {
            string base64MyPublicKey = Convert.ToBase64String(DieffieHellmanEncryptorAES.publicKey);
            text_box_public_key.Text = base64MyPublicKey;
        }

        public void IVKey()
        {
            string base64MyIV = Convert.ToBase64String(DieffieHellmanEncryptorAES.GetIV());
            text_box_iv.Text = base64MyIV;
        }
        private void btn_encrypttext_Click(object sender, EventArgs e)
        {
            if (text_box_text_to_encrypt.Text != "" && text_box_public_partner_key.Text != "")
            {
                string tekstDoZaszyfrowania = text_box_text_to_encrypt.Text;
                string kluczPublicznyPartnera = text_box_public_partner_key.Text;
                string tekstZaszyfrowany = "";
                IVKey();
                tekstZaszyfrowany = DieffieHellmanEncryptorAES.EncryptText(kluczPublicznyPartnera, tekstDoZaszyfrowania);
                text_box_encrypted_text.Text = tekstZaszyfrowany;
            }
            else
            {
                MessageBox.Show("Trzeba wprowadzić tekst do zaszyfrowania i klucz publiczny partnera!", "Uwaga!");
            }
        }
        private void btn_copy_my_iv_Click(object sender, EventArgs e)
        {
            if (text_box_iv.Text != null)
            {
                Clipboard.SetText(text_box_iv.Text);
            }
        }
        private void btn_copy_my_public_key_Click(object sender, EventArgs e)
        {
            if (text_box_public_key.Text != null)
            {
                Clipboard.SetText(text_box_public_key.Text);
            }
        }
        private void btn_copy_encrypted_text_Click(object sender, EventArgs e)
        {
            if (text_box_encrypted_text.Text != null)
            {
                Clipboard.SetText(text_box_encrypted_text.Text);
            }
        }
    }
}
