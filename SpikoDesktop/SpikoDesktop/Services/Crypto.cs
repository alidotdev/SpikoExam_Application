using SpikoDesktop.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace SpikoDesktop.Services
{
    class Crypto
    {
        private static Crypto _instance;
        private Crypto() { }

        public static Crypto GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Crypto();
            }
            return _instance;
        }

        public Image Base64ToImage(String base64Text)
        {
            Logger.log.Info("Converting base64 to image");
            byte[] imageBytes = Convert.FromBase64String(base64Text);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Logger.log.Info("After conversion image is returning");
            return Image.FromStream(ms, true);
        }

        public String ImageToBase64(Bitmap image)
        {
            Logger.log.Info("Converting image to base 64");
            ImageConverter converter = new ImageConverter();
            byte[] imageArray = (byte[])converter.ConvertTo(image, typeof(byte[]));
            //byte[] imageArray = System.IO.File.ReadAllBytes(dialog.FileName);

            // byte[] FILE = image.;
            Logger.log.Info("Returning base 64 code of image");
            return Convert.ToBase64String(imageArray);
        }

        public static string SerializeJsonObject<T>(T dataObject)
        {
            Logger.log.Info("Object to json conversion");
            if (dataObject == null)
            {
                Logger.log.Info("Passed object for serialization to json is null");
                return string.Empty;
            }
            try
            {
                Logger.log.Info("Trying to serialize an object to json");
                return Newtonsoft.Json.JsonConvert.SerializeObject(dataObject, Newtonsoft.Json.Formatting.Indented);
            }
            catch (Exception)
            {
                Logger.log.Error("Error in serialization of object");
                return string.Empty;
            }
        }

        public static T DeserializeJsonObject<T>(string json)
         where T : new()
        {
            Logger.log.Info("Deserializing json object to class object");
            if (string.IsNullOrEmpty(json))
            {
                Logger.log.Info("Passed json object is empty");
                return new T();
            }
            try
            {
                Logger.log.Info("Trying to deserialize json object");
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception e)
            {
                Logger.log.Error("Error occured in deserializing the object");
                //MessageBox.Show(e.StackTrace);
                return new T();
            }
        }

        public T FromXml<T>(String fileName)
        {
            T returnedXmlClass = default(T);

            try
            {
                Logger.log.Info("Deserializing xml object");
                FileStream fs = new FileStream(fileName, FileMode.Open);
                XmlDictionaryReader reader =
                    XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
                DataContractSerializer ser = new DataContractSerializer(typeof(T));

                // Deserialize the data and read it from the instance.
                T deserializedObj =
                    (T)ser.ReadObject(reader, true);
                reader.Close();
                fs.Close();
                returnedXmlClass = deserializedObj;
            }
            catch (Exception)
            {
                Logger.log.Error("Error occured in deserizing xml object");
            }
            return returnedXmlClass;
        }

        public static string SerializeObject<T>(T dataObject)
        {
            Logger.log.Info("Serializing xml object");
            if (dataObject == null)
            {
                Logger.log.Info("Passed obect xml srialization is null");
                return string.Empty;
            }
            try
            {
                Logger.log.Info("Trying xml serialization");
                var serializer = new DataContractSerializer(typeof(T));
                string xmlString;
                using (var sw = new StringWriter())
                {
                    using (var writer = new XmlTextWriter(sw))
                    {
                        writer.Formatting = Formatting.Indented; // indent the Xml so it's human readable
                        serializer.WriteObject(writer, dataObject);
                        writer.Flush();
                        xmlString = sw.ToString();
                    }
                }
                return xmlString;
            }
            catch (Exception ex)
            {
                Logger.log.Error("Error occured in xml serialization");
                //MessageBox.Show(ex.StackTrace);
                return string.Empty;
            }
        }

        public byte[] Key = new byte[16];

        private void GenKey()
        {
            Logger.log.Info("Generating key for AES Encryption");
            var rand = new RNGCryptoServiceProvider();
            rand.GetBytes(Key);
        }

        public byte[] EncryptStringToBytes_Aes(string plainText)
        {
            GenKey();
            byte[] encrypted;
            byte[] IV;
            Logger.log.Info("Encrypting string to AES encryption");
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.GenerateIV();
                IV = aesAlg.IV;
                aesAlg.Mode = CipherMode.CBC;
                var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption. 
                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            var combinedIvCt = new byte[IV.Length + encrypted.Length];
            Array.Copy(IV, 0, combinedIvCt, 0, IV.Length);
            Array.Copy(encrypted, 0, combinedIvCt, IV.Length, encrypted.Length);

            // Return the encrypted bytes from the memory stream. 
            Logger.log.Info("Returning AES encrypted data");
            return combinedIvCt;
        }

        public static string DecryptStringFromBytes_Aes(byte[] cipherTextCombined, byte[] Key)
        {
            Logger.log.Info("Decrypting AES to string");
            string plaintext;
            // Create an Aes object 
            // with the specified key and IV. 
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;

                byte[] IV = new byte[aesAlg.BlockSize / 8];
                byte[] cipherText = new byte[cipherTextCombined.Length - IV.Length];

                Array.Copy(cipherTextCombined, IV, IV.Length);
                Array.Copy(cipherTextCombined, IV.Length, cipherText, 0, cipherText.Length);

                aesAlg.IV = IV;

                aesAlg.Mode = CipherMode.CBC;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption. 
                using (var msDecrypt = new MemoryStream(cipherText))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }
            Logger.log.Info("Returning string after decrypting from AES");
            return plaintext;
        }
    }
}
