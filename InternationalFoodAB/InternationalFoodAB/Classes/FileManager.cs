using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InternationalFoodAB.Classes
{
    public static class FileManager
    {
        /// <summary>
        /// Append is true by default
        /// </summary>
        public static void Write(string path, string text, bool append = true)
        {
            using (StreamWriter writer = new StreamWriter(path, append))
            {
                writer.WriteLine(text);
            }
        }
        public static List<string> Read(string path)
        {
            string row = "";
            List<string> rows = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                while ((row = reader.ReadLine()) != null)
                {
                    rows.Add(row);
                }
            }
            return rows;
        }
    }
}
