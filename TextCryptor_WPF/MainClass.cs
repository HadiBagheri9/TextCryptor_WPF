using System;
using System.Text;

namespace TextCryptor_WPF
{
    class MainClass
    {
        public static string Encrypt(string text, int layers)
        {
            byte[] textBytes = Encoding.UTF8.GetBytes(text);
            string str = Convert.ToBase64String(textBytes);

            for (int i = 0; i < layers - 1; i++)
            {
                textBytes = Encoding.UTF8.GetBytes(str);
                str = Convert.ToBase64String(textBytes);
            }

            return str;
        }

        public static string Decrypt(string text, int layers)
        {
            string str = Encoding.UTF8.GetString(Convert.FromBase64String(text));

            for (int i = 0; i < layers -1; i++)
            {
                str = Encoding.UTF8.GetString(Convert.FromBase64String(str));
            }

            return str;
        }
    }
}
