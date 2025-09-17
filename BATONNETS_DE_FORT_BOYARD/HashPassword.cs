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
        // La taille du sel en octets
        private const int SaltSize = 16;

        // Le nombre d'itérations pour l'algorithme PBKDF2
        private const int Iterations = 10000;

        /// <summary>
        /// Hache un mot de passe en texte clair de manière sécurisée.
        /// </summary>
        /// <param name="password">Le mot de passe en texte clair.</param>
        /// <returns>Le mot de passe haché (incluant le sel) sous forme de chaîne Base64.</returns>
        public static string Hash(string password)
        {
            // Génération d'un sel aléatoire pour chaque mot de passe
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

            // Utilisation de l'algorithme PBKDF2 pour hacher le mot de passe
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(20);

            // Combinaison du sel et du hachage pour un stockage facile
            byte[] hashBytes = new byte[SaltSize + 20];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, 20);

            // Conversion en chaîne de caractères pour la base de données
            return Convert.ToBase64String(hashBytes);
        }

        /// <summary>
        /// Vérifie si un mot de passe en texte clair correspond à un hachage stocké.
        /// </summary>
        /// <param name="password">Le mot de passe en texte clair à vérifier.</param>
        /// <param name="hashedPassword">Le hachage stocké dans la base de données.</param>
        /// <returns>True si le mot de passe est correct, sinon False.</returns>
        public static bool Verify(string password, string hashedPassword)
        {
            // Conversion de la chaîne hachée en tableau d'octets
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);

            // Extraction du sel du tableau d'octets
            byte[] salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            // Extraction du hachage du tableau d'octets
            byte[] storedHash = new byte[20];
            Array.Copy(hashBytes, SaltSize, storedHash, 0, 20);

            // Hachage du mot de passe fourni avec le sel récupéré
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
            byte[] newHash = pbkdf2.GetBytes(20);

            // Comparaison des deux hachages pour vérifier la correspondance
            int diff = 0;
            for (int i = 0; i < 20; i++)
            {
                diff |= (storedHash[i] ^ newHash[i]);
            }

            return diff == 0;
        }
    }
}
