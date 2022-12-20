using static Szyfrowanie_RSA.Program;

namespace Szyfrowanie_RSA.Kontrolki
{
    public partial class SzyfrowaniePliku : UserControl
    {
        string fileToEncryptPath;
        string encryptedFilePath;
        string publicKeyString;
        RSAEncryptor enc;

        public SzyfrowaniePliku()
        {
            InitializeComponent();
            enc = new RSAEncryptor();
        }

        private void btn_encryptfile_Click(object sender, EventArgs e)
        {
            if (text_box_file_to_encrypt_location.Text != "" && text_box_public_key.Text != "" && text_box_encrypted_file_save_location.Text != "")
            {
                fileToEncryptPath = text_box_file_to_encrypt_location.Text;
                encryptedFilePath = text_box_encrypted_file_save_location.Text;
                publicKeyString = text_box_public_key.Text;
                try
                {
                    enc.EncryptFile(fileToEncryptPath, encryptedFilePath, publicKeyString);
                }
                finally { }
            }
            else
            {
                MessageBox.Show("Pola pliku do zaszyfrowania, lokacji zapisu i klucza publicznego nie mogą być puste!", "Uwaga");
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

        private void button_generate_private_key_Click(object sender, EventArgs e)
        {
            enc.GeneratePrivateKey();
            text_box_private_key.Text = enc.privateKeyString;
        }

        private void button_generate_public_key_Click(object sender, EventArgs e)
        {
            enc.GeneratePublicKey();
            text_box_public_key.Text = enc.publicKeyString;
        }

        private void btn_copy_public_key_Click(object sender, EventArgs e)
        {
            if (text_box_public_key.Text != null)
            {
                Clipboard.SetText(text_box_public_key.Text);
            }
        }

        private void btn_copy_private_key_Click(object sender, EventArgs e)
        {
            if (text_box_private_key.Text != null)
            {
                Clipboard.SetText(text_box_private_key.Text);
            }
        }
    }
}
