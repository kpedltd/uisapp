using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UisApp.Helpers
{
    static class FileBinaryHelper
    {
        public static string Read(string fileName)
        {
            byte[] bytes = File.ReadAllBytes(fileName);
            string result = Convert.ToBase64String(bytes);

            return result;
        }
    }
}
