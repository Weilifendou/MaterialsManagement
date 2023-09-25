using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;


namespace MaterialsManagement
{
    public static class Common
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="plainStr"></param>
        /// <returns></returns>
        public static string MD5EncryptStr(string plainStr)
        {
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                byte[] fromData = Encoding.Default.GetBytes(plainStr);
                byte[] toData = md5.ComputeHash(fromData);
                return Convert.ToBase64String(toData);
            }
        }

        /// <summary>

        /// AES加密

        /// </summary>

        /// <param name="plainStr">明文字符串</param>

        /// <returns>密文</returns>

        private static string Key
        {
            get { return "TDYGTDYGTDYGTDYGTDYGTDYGTDYGTDYG"; }
        }
        private static string IV
        {
            get { return @"tdygtdygtdygtdyg"; }
        }
        public static string AESEncryptStr(string plainStr)
        {

            byte[] bKey = Encoding.Default.GetBytes(Key);
            byte[] bIV = Encoding.Default.GetBytes(IV);
            byte[] byteArray = Encoding.Default.GetBytes(plainStr);
            string encrypt = "";
            Rijndael aes = Rijndael.Create();
            using (MemoryStream mStream = new MemoryStream())
            {
                using (CryptoStream cStream = new CryptoStream(mStream, aes.CreateEncryptor(bKey, bIV), CryptoStreamMode.Write))
                {
                    cStream.Write(byteArray, 0, byteArray.Length);
                    cStream.FlushFinalBlock();
                    encrypt = Convert.ToBase64String(mStream.ToArray());

                }
            }
            aes.Clear();
            return encrypt;
        }

        public static string AESDecryptStr(string encryptStr)
        {
            byte[] bKey = Encoding.Default.GetBytes(Key);
            byte[] bIV = Encoding.Default.GetBytes(IV);
            byte[] byteArray = Convert.FromBase64String(encryptStr);
            string decrypt = "";
            Rijndael aes = Rijndael.Create();
            // 开辟一块内存流
            try
            {
                using (MemoryStream mStream = new MemoryStream())
                {
                    // 把内存流对象包装成加密流对象
                    using (CryptoStream cStream = new CryptoStream(mStream, aes.CreateDecryptor(bKey, bIV), CryptoStreamMode.Write))
                    {
                        // 明文数据写入加密流
                        cStream.Write(byteArray, 0, byteArray.Length);
                        cStream.FlushFinalBlock();
                        decrypt = Encoding.Default.GetString(mStream.ToArray());
                    }
                }
                aes.Clear();

            }
            catch (Exception e)
            {
            }
            return decrypt;
        }

    }
}
