using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys.Controllers
{
    public class ReadFileController
    {
        private string _filePath;
        public ReadFileController(string path)
        {
            string bufPath = "";
            foreach (string dir in path.Split('\\'))
            {
                bufPath += dir;
                if (!path.Equals(bufPath))
                {
                    bufPath += "\\";
                    if (!Directory.Exists(bufPath))
                    {
                        _filePath = bufPath;
                        break;
                    }
                }
                else if (!File.Exists(bufPath))
                {
                    _filePath = bufPath;
                    break;
                }
            }
            _filePath = bufPath;
        }

        public string[] GetJson()
        {
            Console.WriteLine(_filePath);
            if (Path.GetExtension(_filePath).Equals(".json"))
                return JsonConvert.DeserializeObject<string[]>(GetPlainText(_filePath));
            else
                throw new Exception($"Can't find any .json file in {_filePath} dir!");
        }

        public string GetPlainText(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
