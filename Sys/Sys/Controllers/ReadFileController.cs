using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys.Controllers
{
    public class ReadFileController
    {
        string defaultPath;
        public ReadFileController()
        {
            defaultPath = "C:\\Users\\User\\Desktop\\Sys\\Sys\\Sys\\whiteList.json";
        }

        public string ReadFile(string path)
        {
            string bufPath = "";
            try
            {
                foreach (string dir in path.Split('\\'))
                {
                    bufPath += dir;
                    if (!path.Equals(bufPath))
                    {
                        bufPath += "\\";
                        if (!Directory.Exists(bufPath))
                        {
                            path = defaultPath;
                            break;
                        }
                    }
                    else if (!File.Exists(bufPath))
                    {
                        path = defaultPath;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return File.ReadAllText(path);
        }

    }
}
