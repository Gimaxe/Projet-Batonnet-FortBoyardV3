using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BATONNETS_DE_FORT_BOYARD
{
    internal class HashPassword
    {
        public static string Hash(string password)
        {
            // Crée une instance de l'algorithme SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Hache le mot de passe en octets
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convertit le hachage en une chaîne hexadécimale
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    
    }
}
