using System;
using System.IO;
using System.Security.Cryptography;



namespace ques_6
{
    class Copy_File
    {

        static void Main()
        {
            // Copy contents from file1 to file2
            File.Copy("nisha.txt", "nisha_enycrpt.txt");



            // Display file2 contents
            Console.WriteLine(File.ReadAllText("nisha_enycrpt.txt"));
            var allText = File.ReadAllText(@"C:\Users\nisha.hiremani\source\repos\evalutionC#\Ques_6_\Ques_6_\bin\Debug\nisha_enycrpt.txt");
            EncryptFileString(allText);
        }
        //In brief I would like to explain, we are using System.Security.Cryptography.
        //Rijndael symmetric encryption algorithm.
        //We will be Encrypting the string to an array of bytes and then decrypting bytes into string again.


        public static void EncryptFileString(string original)
        {

            using (Rijndael myEncryp = Rijndael.Create())
            {
                // Encrypt the string to an array of bytes.
                byte[] encrypted = EncryptStringToBytes(original, myEncryp.Key, myEncryp.IV);



                // Decrypt the bytes to a string.
                string roundtrip = DecryptStringFromBytes(encrypted, myEncryp.Key, myEncryp.IV);



                //Display the original data and the decrypted data.
                Console.WriteLine("Original Text from file: {0}", original);
                Console.WriteLine("After Encryption and Decryption: {0}", roundtrip);
            }
        }



        private static string DecryptStringFromBytes(byte[] encrypted, byte[] key, byte[] IV)
        {
            // the decrypted text.
            string plaintext = null;



            // Create an Rijndael object
            // with the specified key and IV.
            using (Rijndael myDecrpt = Rijndael.Create())
            {
                myDecrpt.Key = key;
                myDecrpt.IV = IV;



                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = myDecrpt.CreateDecryptor(myDecrpt.Key, myDecrpt.IV);



                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(encrypted))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }



            return plaintext;



        }



        private static byte[] EncryptStringToBytes(string original, byte[] key, byte[] IV)
        {
            byte[] encrypted;
            // Create an Rijndael object with the specified key and IV.
            using (Rijndael rijAlg = Rijndael.Create())
            {
                rijAlg.Key = key;
                rijAlg.IV = IV;



                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);



                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {



                            //Write all data to the stream.
                            swEncrypt.Write(original);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }



            return encrypted;
        }
    }
}