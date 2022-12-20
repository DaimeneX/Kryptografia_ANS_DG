using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Szyfrowanie_AES.Program;

namespace Szyfrowanie_AES.Kontrolki
{
    public partial class SzyfrowaniePliku : UserControl
    {
        public SzyfrowaniePliku()
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

        private void btn_encryptfile_Click(object sender, EventArgs e)
        {
            if (text_box_file_to_encrypt_location.Text != "" && text_box_encrypted_file_save_location.Text != "" && text_box_public_partner_key.Text != "")
            {
                string plikDoZaszyfrowania = text_box_file_to_encrypt_location.Text;
                string folderDocelowy = text_box_encrypted_file_save_location.Text;
                string kluczPublicznyPartnera = text_box_public_partner_key.Text;

                Stopwatch stopWatch = new Stopwatch();

                try
                {
                    stopWatch.Start();

                    IVKey();
                    DieffieHellmanEncryptorAES.EncryptFile(kluczPublicznyPartnera, plikDoZaszyfrowania, folderDocelowy);

                    stopWatch.Stop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    return;
                }

                MessageBox.Show("Plik został zaszyfrowany.\nCzas operacji: " + stopWatch.Elapsed.ToString(@"hh\:mm\:ss"), "Info");
            }
            else
            {
                MessageBox.Show("Wejścia nie mogą być puste!", "Uwaga");
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

        private void button_select_file_location_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                text_box_file_to_encrypt_location.Text = file;
            }
        }

        private void button_select_file_save_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath;
                text_box_encrypted_file_save_location.Text = path;
            }
        }
    }
}
