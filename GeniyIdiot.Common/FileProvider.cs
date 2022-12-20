using System.Text;

namespace GeniyIdiot.Common
{
    public class FileProvider
    {
        public static string Get(string fileName)
        {
            string text;

            using (var reader = new StreamReader(fileName))
            {
                text = reader.ReadToEnd();
            }

            return text;
        }

        public static void Put(string fileName, string text)
        {
            using (var writer = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                writer.WriteLine(text);
            }
        }

        public static bool Exist(string fileName)
        {
            return File.Exists(fileName);
        }
    }
}
