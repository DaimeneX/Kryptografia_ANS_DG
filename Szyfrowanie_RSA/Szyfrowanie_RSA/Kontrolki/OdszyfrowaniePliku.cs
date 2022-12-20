
using static Szyfrowanie_RSA.Program;

namespace Szyfrowanie_RSA.Kontrolki
{
    public partial class OdszyfrowaniePliku : UserControl
    {
        RSAEncryptor enc;
        string fileToDecryptPath;
        string decryptedFilePath;
        string privateKeyString;

        public OdszyfrowaniePliku()
        {
            InitializeComponent();
            enc = new RSAEncryptor();
        }

        private void button_select_file_location_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                text_box_file_location_to_decrypt.Text = file;
            }
        }

        private void button_select_file_save_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath;
                text_box_decrypted_file_save_location.Text = path;
            }
        }

        private void btn_decryptfile_Click(object sender, EventArgs e)
        {
            if (text_box_file_location_to_decrypt.Text != "" && text_box_private_key.Text != "" && text_box_decrypted_file_save_location.Text != "")
            {
                fileToDecryptPath = text_box_file_location_to_decrypt.Text;
                decryptedFilePath = text_box_decrypted_file_save_location.Text;
                privateKeyString = text_box_private_key.Text;
                try
                {
                    enc.DecryptFile(fileToDecryptPath, decryptedFilePath, privateKeyString);
                }
                finally { }
            }
            else
            {
                MessageBox.Show("Plik do odszyfrowania ścieżki wejściowej, folderu docelowego i klucza prywatnego nie może być pusty!", "Uwaga");
            }
        }
    }
}
