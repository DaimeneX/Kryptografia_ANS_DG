using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Szyfrowanie_AES.Program;

namespace Szyfrowanie_AES.Kontrolki
{
    public partial class OdszyfrowanieTekstu : UserControl
    {
        public OdszyfrowanieTekstu()
        {
            InitializeComponent();
            KluczPubliczny();
        }

        public void KluczPubliczny()
        {
            string base64MyPublicKey = Convert.ToBase64String(DieffieHellmanEncryptorAES.publicKey);
            text_box_public_key.Text = base64MyPublicKey;
        }

        private void btn_decrypttext_Click(object sender, EventArgs e)
        {
            if (text_box_encrypted_text.Text != "" && text_box_public_partner_key.Text != "" && text_box_partner_iv.Text != "")
            {
                string tekstDoOdszyfrowania = text_box_encrypted_text.Text;
                string kluczPublicznyPartnera = text_box_public_partner_key.Text;
                string IVPartnera = text_box_partner_iv.Text;
                string tekstOdszyfrowany = "";
                tekstOdszyfrowany = DieffieHellmanEncryptorAES.DecryptText(kluczPublicznyPartnera, IVPartnera, tekstDoOdszyfrowania);
                text_box_decrypted_text.Text = tekstOdszyfrowany;
            }
            else
            {
                MessageBox.Show("Tekst do odszyfrowania nie może być pusty!", "Uwaga");
            }
        }
        private void btn_copy_my_public_key_Click(object sender, EventArgs e)
        {
            if (text_box_public_key.Text != null)
            {
                Clipboard.SetText(text_box_public_key.Text);
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
