using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalFoodAB.Classes
{
    public static class ErrorHandler
    {
        public static void Log(Exception error)
        {
            string text = string.Format("Message: {0}, Type: {1}", error.Message, error.GetType().ToString());
            FileManager.Write(GetPath(), text, true);
        }
        public static string GetPath()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(basePath.Remove(basePath.IndexOf("bin\\Debug")), "Resources\\ErrorLog.txt");
        }
    }
}
