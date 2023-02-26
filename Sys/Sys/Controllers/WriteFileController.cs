using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys.Controllers
{
    public class WriteFileController
    {
        WriteDirController dirController;
        public WriteFileController()
        {
            dirController = new WriteDirController();
        }

        public void WriteFile(string path, string content)
        {
            try
            {
                // C:\WINNT\System32\xepobopa\file.json
                string bufPath = "";
                foreach (string dir in path.Split('\\'))
                {
                    bufPath += dir;
                    if (!path.Equals(bufPath))
                    {
                        bufPath += "\\";
                        if (!Directory.Exists(bufPath))
                        {
                            Directory.CreateDirectory(bufPath);
                        }
                    }
                }

                using (FileStream file = File.Create(path))
                {
                    byte[] buffer = new UTF8Encoding(true).GetBytes(string.IsNullOrEmpty(content) ? "" : content);
                    file.Write(buffer, 0, buffer.Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
