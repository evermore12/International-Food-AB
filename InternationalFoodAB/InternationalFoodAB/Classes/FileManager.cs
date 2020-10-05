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

        public static void Write(string text, string path, bool append)
        {
            using (StreamWriter writer = new StreamWriter(path, append))
            {

            }
        }
        public static void Read(string path)
        {
            string row = "";
            using (StreamReader reader = new StreamReader(path))
            {
                while ((row = reader.ReadLine()) != null)
                {

                }
            }
        }
    }
}
