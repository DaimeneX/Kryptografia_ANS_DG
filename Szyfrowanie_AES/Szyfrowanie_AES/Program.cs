using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using Szyfrowanie_AES;

namespace Szyfrowanie_AES
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
            DieffieHellmanEncryptorAES.InitializeEncryptor();
            Application.Run(new Form1());
        }

        public static class DieffieHellmanEncryptorAES
        {
            private static Aes aes;
            private static ECDiffieHellmanCng diffieHellman;

            public static byte[] publicKey;

            public static void InitializeEncryptor()
            {
                aes = Aes.Create();
                diffieHellman = new ECDiffieHellmanCng();
                diffieHellman.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                diffieHellman.HashAlgorithm = CngAlgorithm.Sha256;
                publicKey = diffieHellman.PublicKey.ToByteArray();
            }

            public static byte[] GetIV()
            {
                return aes.IV;
            }

            public static string EncryptText(string base64OtherPartyPublicKey, string textToEncrypt)
            {
                string base64encryptedText;
                byte[] otherPartyPublicKey = Convert.FromBase64String(base64OtherPartyPublicKey);
                CngKey key = CngKey.Import(otherPartyPublicKey, CngKeyBlobFormat.EccPublicBlob);
                byte[] derivedKey = diffieHellman.DeriveKeyMaterial(key); // Common secret

                aes.Key = derivedKey;

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(textToEncrypt);
                        }
                        byte[] encryptedBytes = msEncrypt.ToArray();
                        base64encryptedText = Convert.ToBase64String(encryptedBytes);
                    }
                }
                return base64encryptedText;
            }

            public static string DecryptText(string base64OtherPartyPublicKey, string base64OtherPartyIV, string base64TextToDecrypt)
            {
                string decryptedText;
                byte[] otherPartyPublicKey = Convert.FromBase64String(base64OtherPartyPublicKey);
                byte[] textToDecrypt = Convert.FromBase64String(base64TextToDecrypt);
                byte[] otherPartyIV = Convert.FromBase64String(base64OtherPartyIV);

                CngKey key = CngKey.Import(otherPartyPublicKey, CngKeyBlobFormat.EccPublicBlob);
                byte[] derivedKey = diffieHellman.DeriveKeyMaterial(key); // Common secret

                aes.Key = derivedKey;
                aes.IV = otherPartyIV;

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(textToDecrypt))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            decryptedText = srDecrypt.ReadToEnd();
                        }
                    }
                }
                return decryptedText;
            }

            public static void EncryptFile(string base64OtherPartyPublicKey, string fileToEncryptPath, string destinationFolder)
            {
                byte[] otherPartyPublicKey = Convert.FromBase64String(base64OtherPartyPublicKey);
                CngKey key = CngKey.Import(otherPartyPublicKey, CngKeyBlobFormat.EccPublicBlob);
                byte[] derivedKey = diffieHellman.DeriveKeyMaterial(key); // Common secret

                FileInfo srcFile = new FileInfo(fileToEncryptPath);
                string outFilePath = Path.Combine(destinationFolder, srcFile.Name + ".enc");

                aes.Key = derivedKey;

                using (FileStream outFsEncrypt = new FileStream(outFilePath, FileMode.Create))
                {
                    using (CryptoStream csEncrypt = new CryptoStream(outFsEncrypt, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        int count = 0;
                        int offset = 0;
                        int blockSizeBytes = aes.BlockSize / 8;
                        byte[] data = new byte[blockSizeBytes];
                        int bytesRead = 0;

                        using (FileStream inFsEncrypt = new FileStream(srcFile.FullName, FileMode.Open))
                        {
                            do
                            {
                                count = inFsEncrypt.Read(data, 0, blockSizeBytes);
                                offset += count;
                                csEncrypt.Write(data, 0, count);
                                bytesRead += blockSizeBytes;
                            } while (count > 0);
                        }
                        csEncrypt.FlushFinalBlock();
                    }
                }
            }

            public static void DecryptFile(string base64OtherPartyPublicKey, string base64OtherPartyIV, string fileToDecryptPath, string destinationFolder)
            {
                byte[] otherPartyPublicKey = Convert.FromBase64String(base64OtherPartyPublicKey);
                byte[] otherPartyIV = Convert.FromBase64String(base64OtherPartyIV);

                CngKey key = CngKey.Import(otherPartyPublicKey, CngKeyBlobFormat.EccPublicBlob);
                byte[] derivedKey = diffieHellman.DeriveKeyMaterial(key); // Common secret

                FileInfo srcFile = new FileInfo(fileToDecryptPath);
                string outFilePath = Path.Combine(destinationFolder, "decrypted_" + Path.ChangeExtension(srcFile.Name, ""));

                aes.Key = derivedKey;
                aes.IV = otherPartyIV;

                using (FileStream inFsDecrypt = new FileStream(srcFile.FullName, FileMode.Open))
                {
                    using (FileStream outFsDecrypt = new FileStream(outFilePath, FileMode.Create))
                    {
                        int count = 0;
                        int offset = 0;

                        int blockSizeBytes = aes.BlockSize / 8;
                        byte[] data = new byte[blockSizeBytes];

                        using (CryptoStream csDecrypt = new CryptoStream(outFsDecrypt, aes.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            do
                            {
                                count = inFsDecrypt.Read(data, 0, blockSizeBytes);
                                offset += count;
                                csDecrypt.Write(data, 0, count);
                            } while (count > 0);

                            csDecrypt.FlushFinalBlock();
                        }
                    }
                }
            }
        }
    }
}