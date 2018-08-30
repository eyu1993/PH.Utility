using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PH.Utility.Encrypt
{
    /// <summary>
    /// MD5加密
    /// </summary>
    public class MD5Helper
    {
        /// <summary>
        /// 获取字符串的MD5值（32位）
        /// </summary>
        /// <param name="str">要加密的字符串</param>
        /// <returns>加密结果</returns>
        public static string GetStrMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(Encoding.Default.GetBytes(str));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString("x2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获取文件的MD5值
        /// </summary>
        /// <param name="path">绝对路径或相对路径</param>
        /// <returns>加密结果</returns>
        public static string GetFileMD5(string path)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            FileStream file = new FileStream(path, FileMode.Open);
            byte[] result = md5.ComputeHash(file);
            file.Close();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
