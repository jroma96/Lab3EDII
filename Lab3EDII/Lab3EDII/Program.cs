using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Lab3EDII
{
    class Program
    {
        static void Main(string[] args)
        {
            const int keySize = 1024;
            string publicAndPrivateKey;
            string publicKey;

            EncriptadoASM.GenerateKeys(keySize, out publicKey, out publicAndPrivateKey);

            string text = "text for encryption";
            string encrypted = EncriptadoASM.EncryptText(text, keySize, publicKey);
            string decrypted = EncriptadoASM.DecryptText(encrypted, keySize, publicAndPrivateKey);
            Console.WriteLine("Encrypted: {0}", encrypted);
            Console.WriteLine("Decrypted: {0}", decrypted);
            Console.ReadKey();
        }
    }
}
