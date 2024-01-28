using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

namespace Stump.Core.Extensions
{
    public static class StringExtensions
    {
        private static readonly string XmlKey = Properties.Resources._public;
        private static readonly string XmlPrivateKey = Properties.Resources.privatepublic;
        private const string key = "3Smb1nAAwbj1sN7qTiT3SZD27PVA0wWV";
        public static string ConcatCopy(this string str, int times)
        {
            StringBuilder builder = new StringBuilder(str.Length * times);
            for (int i = 0; i < times; i++)
            {
                builder.Append(str);
            }
            return builder.ToString();
        }

        public static string DeleteLastLetter(this string str)
        {
            if (str.Length < 2)
            {
                return str;
            }
            return str.Substring(0, str.Length - 1);
        }
        public static int CountOccurences(this string str, char chr)
        {
            return str.CountOccurences(chr, 0, str.Length);
        }
        public static string GetMD5(this string encryptString)
        {
            byte[] bytes = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(encryptString));
            return bytes.ByteArrayToString();
        }
        public static string GetSHA512(this string encryptString)
        {
            using (var sha512 = SHA512.Create())
            {
                byte[] bytes = sha512.ComputeHash(Encoding.UTF8.GetBytes(encryptString));
                return bytes.ByteArrayToString();
            }
        }
        public static string GetRSA(this string encryptString)
        {
            const int keySize = 1024;

            string result = AsymmetricEncryption.EncryptText(encryptString, keySize, XmlKey);

            return result;
        }

        public static string SetRSA(this string encryptString)
        {
            const int keySize = 1024;

            string result = AsymmetricEncryption.DecryptText(encryptString, keySize, XmlPrivateKey);
            
            return result;
        }

        public static List<T> Splice<T>(this List<T> Source, int Start, int Size)
        {
            var retVal = Source.Skip(Start).Take(Size).ToList();
            Source.RemoveRange(Start, Size);
            return retVal;
        }

        public static string EncryptAES(this string plainText)
        {
            var aes = new RijndaelManaged
            {
                KeySize = 256,
                BlockSize = 128,
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC,
                Key = Encoding.Default.GetBytes(key)
            };

            aes.GenerateIV();

            var aesEncrypt = aes.CreateEncryptor(aes.Key, aes.IV);
            var buffer = Encoding.ASCII.GetBytes(plainText);

            var encryptedText = Convert.ToBase64String(Encoding.Default.GetBytes(Encoding.Default.GetString(aesEncrypt.TransformFinalBlock(buffer, 0, buffer.Length))));

            string mac;
            using (var hmacsha256 = new HMACSHA256(Encoding.Default.GetBytes(key)))
            {
                hmacsha256.ComputeHash(Encoding.Default.GetBytes(Convert.ToBase64String(aes.IV) + encryptedText));

                mac = ByteToString(hmacsha256.Hash);
            }

            var keyValues = new Dictionary<string, object>
            {
                {"iv", "pLJJ0RkSC5JPZiJk1QsBbg=="},
                {"value", encryptedText},
                {"mac", mac},
            };
            var serializer = new JavaScriptSerializer();
            var result = Convert.ToBase64String(Encoding.ASCII.GetBytes(serializer.Serialize(keyValues)));
            return result;
        }

        private static string ByteToString(IEnumerable<byte> buff)
        {
            return buff.Aggregate("", (current, t) => current + t.ToString("X2"));
        }


        public static string Decrypt(this string cipherText)
        {
            var aes = new RijndaelManaged
            {
                KeySize = 256,
                BlockSize = 128,
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC,
                Key = Encoding.Default.GetBytes(key)
            };


            dynamic payload = GetJsonPayload(cipherText);

            aes.IV = Convert.FromBase64String(payload["iv"]);

            var aesDecrypt = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] buffer = Convert.FromBase64String(payload["value"]);
            var result = Encoding.Default.GetString(aesDecrypt.TransformFinalBlock(buffer, 0, buffer.Length));
            return result;
        }

        private static dynamic GetJsonPayload(string cipherText)
        {
            var jss = new JavaScriptSerializer();

            var result = jss.Deserialize<Dictionary<string, object>>(Encoding.ASCII.GetString(Convert.FromBase64String(cipherText)));
            return result;
        }

        public static int CountOccurences(this string str, char chr, int startIndex, int count)
        {
            int occurences = 0;
            for (int i = startIndex; i < startIndex + count; i++)
            {
                if (str[i] == chr)
                {
                    occurences++;
                }
            }
            return occurences;
        }

        public static string EscapeString(this string str)
        {
            var str1 = str == null ? null : Regex.Replace(str, "[\\r\\n\\x00\\x1a\\\\'\"]", "\\$0");
            return str1;
        }

        public static string FirstLetterUpper(this string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                return string.Empty;
            }
            char[] chArray = source.ToCharArray();
            chArray[0] = char.ToUpper(chArray[0]);
            return new string(chArray);
        }

        public static string HtmlEntities(this string str)
        {
            str = str.Replace("&", "&amp;");
            str = str.Replace("<", "&lt;");
            str = str.Replace(">", "&gt;");
            return str;
        }

        public static string RandomString(this Random random, int size)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                stringBuilder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))));
            }
            return stringBuilder.ToString();
        }

        public static string[] SplitAdvanced(this string expression, string delimiter)
        {
            return expression.SplitAdvanced(delimiter, string.Empty, false);
        }

        public static string[] SplitAdvanced(this string expression, string delimiter, string qualifier)
        {
            return expression.SplitAdvanced(delimiter, qualifier, false);
        }

        public static string[] SplitAdvanced(this string expression, string delimiter, string qualifier, bool ignoreCase)
        {
            bool qualifierState = false;
            int startIndex = 0;
            ArrayList values = new ArrayList();
            for (int charIndex = 0; charIndex < expression.Length - 1; charIndex++)
            {
                if (qualifier != null)
                {
                    if (string.Compare(expression.Substring(charIndex, qualifier.Length), qualifier, ignoreCase) == 0)
                    {
                        qualifierState = !qualifierState;
                    }
                    else if (!qualifierState & delimiter != null & string.Compare(expression.Substring(charIndex, delimiter.Length), delimiter, ignoreCase) == 0)
                    {
                        values.Add(expression.Substring(startIndex, charIndex - startIndex));
                        startIndex = charIndex + 1;
                    }
                }
            }
            if (startIndex < expression.Length)
            {
                values.Add(expression.Substring(startIndex, expression.Length - startIndex));
            }
            string[] returnValues = new string[values.Count];
            values.CopyTo(returnValues);
            return returnValues;
        }
    }

    public static class AsymmetricEncryption
    {
        private static bool _optimalAsymmetricEncryptionPadding = false;

        public static void GenerateKeys(int keySize, out string publicKey, out string publicAndPrivateKey)
        {
            using (var provider = new RSACryptoServiceProvider())
            {
                publicKey = provider.ToXmlString(false);
                publicAndPrivateKey = provider.ToXmlString(true);
            }
        }

        public static string EncryptText(string text, int keySize, string publicKeyXml)
        {
            var encrypted = Encrypt(Encoding.UTF8.GetBytes(text), keySize, publicKeyXml);
            return Convert.ToBase64String(encrypted);
        }

        public static byte[] Encrypt(byte[] data, int keySize, string publicKeyXml)
        {
            if (data == null || data.Length == 0) throw new ArgumentException("Data are empty", "data");
            int maxLength = GetMaxDataLength(keySize);
            if (data.Length > maxLength) throw new ArgumentException(String.Format("Maximum data length is {0}", maxLength), "data");
            if (!IsKeySizeValid(keySize)) throw new ArgumentException("Key size is not valid", "keySize");
            if (String.IsNullOrEmpty(publicKeyXml)) throw new ArgumentException("Key is null or empty", "publicKeyXml");

            using (var provider = new RSACryptoServiceProvider())
            {
                provider.FromXmlString(publicKeyXml);
                return provider.Encrypt(data, _optimalAsymmetricEncryptionPadding);
            }
        }

        public static string DecryptText(string text, int keySize, string publicAndPrivateKeyXml)
        {
            var decrypted = Decrypt(Convert.FromBase64String(text), keySize, publicAndPrivateKeyXml);
            return Encoding.UTF8.GetString(decrypted);
        }

        public static byte[] Decrypt(byte[] data, int keySize, string publicAndPrivateKeyXml)
        {
            if (data == null || data.Length == 0) throw new ArgumentException("Data are empty", "data");
            if (!IsKeySizeValid(keySize)) throw new ArgumentException("Key size is not valid", "keySize");
            if (String.IsNullOrEmpty(publicAndPrivateKeyXml)) throw new ArgumentException("Key is null or empty", "publicAndPrivateKeyXml");

            using (var provider = new RSACryptoServiceProvider())
            {
                provider.FromXmlString(publicAndPrivateKeyXml);
                return provider.Decrypt(data, _optimalAsymmetricEncryptionPadding);
            }
        }

        public static int GetMaxDataLength(int keySize)
        {
            if (_optimalAsymmetricEncryptionPadding)
            {
                return ((keySize - 384) / 8) + 7;
            }
            return ((keySize - 384) / 8) + 37;
        }

        public static bool IsKeySizeValid(int keySize)
        {
            return keySize >= 384 &&
                    keySize <= 16384 &&
                    keySize % 8 == 0;
        }
        public static string RemoveWhitespace(this string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}