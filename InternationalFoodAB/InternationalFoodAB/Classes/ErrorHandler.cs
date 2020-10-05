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
        }
    }
}
