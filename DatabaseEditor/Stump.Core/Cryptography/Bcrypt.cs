//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using BCrypt.Net;

//namespace Stump.Core.Cryptography
//{
//    public static class BcryptEncrypt
//    {
//        private static string GenerateSalt()
//        {
//            return BCrypt.Net.BCrypt.GenerateSalt(12);
//        }

//        public static string Encrypt(this string contraseña)
//        {
//            return BCrypt.Net.BCrypt.HashPassword(contraseña, GenerateSalt());
//        }

//        public static bool ValidateHash(this string contraseña, string hash)
//        {
//            return BCrypt.Net.BCrypt.Verify(contraseña, hash);
//        }
//    }
//}
