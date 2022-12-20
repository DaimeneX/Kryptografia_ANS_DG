using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace Szyfrowanie_RSA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


        }

        public static byte[] CopySlice(byte[] source, int index, int length)
        {
            byte[]? slice = null;
            int n = length;

            if (source.Length < index + length)
            {
                n = source.Length - index;
            }

            if (slice == null) slice = new byte[n];
            Buffer.BlockCopy(source, index, slice, 0, n);
            return slice;
        }
        public class RSAEncryptor
        {
            private RSACryptoServiceProvider cryptoServiceProvider;
            private RSAParameters publicKey;
            private RSAParameters privateKey;
            public string? publicKeyString;
            public string? privateKeyString;

            public RSAEncryptor()
            {
                cryptoServiceProvider = new RSACryptoServiceProvider(2048);
            }
            public void GeneratePublicKey()
            {
                publicKey = cryptoServiceProvider.ExportParameters(false);
                publicKeyString = GetKeyString(publicKey);
            }
            public void GeneratePrivateKey()
            {
                privateKey = cryptoServiceProvider.ExportParameters(true);
                privateKeyString = GetKeyString(privateKey);
            }
            private string GetKeyString(RSAParameters publicKey)
            {
                var stringWriter = new System.IO.StringWriter();
                var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                xmlSerializer.Serialize(stringWriter, publicKey);
                return stringWriter.ToString();
            }

            public string EncryptText(string textToEncrypt, string publicKeyString)
            {
                var bytesToEncrypt = Encoding.UTF8.GetBytes(textToEncrypt);

                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    try
                    {
                        rsa.FromXmlString(publicKeyString.ToString());
                        var encryptedData = rsa.Encrypt(bytesToEncrypt, true);
                        var base64Encrypted = Convert.ToBase64String(encryptedData);
                        return base64Encrypted;
                    }
                    catch (System.Security.Cryptography.CryptographicException e)
                    {
                        MessageBox.Show("Niepoprawny format klucza publicznego!", "Error");
                        return "";
                    }
                    catch (System.FormatException e)
                    {
                        MessageBox.Show("Niepoprawny format klucza publicznego!", "Error");
                        return "";
                    }
                    finally
                    {
                        rsa.PersistKeyInCsp = false;
                    }
                }
            }
            public string DecryptText(string textToDecrypt, string privateKeyString)
            {
                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    try
                    {
                        rsa.FromXmlString(privateKeyString.ToString());
                        var resultBytes = Convert.FromBase64String(textToDecrypt);
                        Debug.WriteLine(resultBytes.Length);
                        var decryptedBytes = rsa.Decrypt(resultBytes, true);
                        var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                        return decryptedData.ToString();
                    }
                    catch (System.Security.Cryptography.CryptographicException e)
                    {
                        MessageBox.Show("Niepoprawny format klucza prywatnego!", "Error");
                        return "";
                    }
                    catch (System.FormatException e)
                    {
                        MessageBox.Show("Niepoprawny format klucza prywatnego!", "Error");
                        return "";
                    }
                    finally
                    {
                        rsa.PersistKeyInCsp = false;
                    }
                }
            }
            public void EncryptFile(string filePath, string destinationFolder, string publicKeyString)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                FileInfo srcFile = new FileInfo(filePath);
                string outFilePath = Path.Combine(destinationFolder, srcFile.Name + ".enc");
                string encryptedText = "";


                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    rsa.FromXmlString(publicKeyString.ToString());
                    int maxBlockSize = ((rsa.KeySize - 384) / 8) + 6;
                    int numBytesToRead = (int)srcFile.Length;
                    int numBytesRead = 0;
                    byte[] encryptedFile = new byte[numBytesToRead];
                    string allFileData = "";

                    try
                    {
                        using (FileStream readStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                        {
                            byte[] bytes = new byte[maxBlockSize];
                            File.Delete(outFilePath);

                            while (numBytesToRead > 0)
                            {
                                int n = readStream.Read(bytes, 0, maxBlockSize);
                                if (n < maxBlockSize)
                                {
                                    byte[] tmp = new byte[n];
                                    Array.Copy(bytes, tmp, n);
                                    bytes = tmp;
                                }

                                if (n == 0) break;

                                byte[] encryptedBytes = new byte[214];
                                encryptedBytes = rsa.Encrypt(bytes, true);
                                string base64Encrypted = Convert.ToBase64String(encryptedBytes) + Environment.NewLine;
                                encryptedText += base64Encrypted;

                                numBytesRead += n;
                                numBytesToRead -= n;
                            }
                            File.WriteAllText(outFilePath, encryptedText, Encoding.UTF8);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                        return;
                    }
                    stopWatch.Stop();
                    MessageBox.Show("Plik zosta³ zaszyfrowany.\nCzas operacji: " + stopWatch.Elapsed.ToString(@"hh\:mm\:ss"), "Info");
                }
            }
            public void DecryptFile(string filePath, string destinationFolder, string privateKeyString)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                FileInfo srcFile = new FileInfo(filePath);
                string outFilePath = Path.Combine(destinationFolder, "decrypted_" + Path.ChangeExtension(srcFile.Name, ""));
                byte[]? result = null;

                try
                {
                    using (var rsa = new RSACryptoServiceProvider(2048))
                    {
                        rsa.FromXmlString(privateKeyString.ToString());
                        const Int32 BufferSize = 128;
                        using (Stream source = File.OpenRead(filePath))
                        {
                            using (var streamReader = new StreamReader(source, Encoding.UTF8, true, BufferSize))
                            {
                                String line;
                                while ((line = streamReader.ReadLine()) != null)
                                {
                                    byte[] resultBytes = Convert.FromBase64String(line);
                                    byte[] decryptedBytes = rsa.Decrypt(resultBytes, true);
                                    if (result == null)
                                    {
                                        result = decryptedBytes;
                                    }
                                    else
                                    {
                                        var a1 = result;
                                        var a2 = decryptedBytes;
                                        result = new byte[a1.Length + a2.Length];
                                        Buffer.BlockCopy(a1, 0, result, 0, a1.Length);
                                        Buffer.BlockCopy(a2, 0, result, a1.Length, a2.Length);
                                    }
                                }
                            }
                            source.Close();
                        }

                        File.WriteAllBytes(outFilePath, result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    return;
                }
                stopWatch.Stop();
                MessageBox.Show("Plik zosta³ zaszyfrowany.\nCzas operacji: " + stopWatch.Elapsed.ToString(@"hh\:mm\:ss"), "Info");
            }
        }
    }
}