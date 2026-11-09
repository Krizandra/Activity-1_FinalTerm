using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Activity1_FinalTerm
{
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            byte[] salt = new byte[16];

            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            const int iterations = 10000;

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                byte[] hash = pbkdf2.GetBytes(32);
                return $"PBKDF2${iterations}${Convert.ToBase64String(salt)}${Convert.ToBase64String(hash)}";
            }
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            try
            {
                string[] parts = hashedPassword.Split('$');

                if (parts.Length != 4 || parts[0] != "PBKDF2")
                {
                    return false;
                }

                int i = int.Parse(parts[1]);
                byte[] salt = Convert.FromBase64String(parts[2]);
                byte[] origHash = Convert.FromBase64String(parts[3]);

                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, i))
                {
                    byte[] newHash = pbkdf2.GetBytes(32);

                    if (newHash.Length != origHash.Length)
                    {
                        return false;
                    }

                    int diff = 0;

                    for (int j = 0; j < newHash.Length; j++)
                    {
                        diff |= newHash[j] ^ origHash[j];
                    }

                    return diff == 0;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}