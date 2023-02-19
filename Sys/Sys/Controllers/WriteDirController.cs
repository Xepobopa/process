using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys.Controllers
{
    //public class WriteDirController
    //{
    //    public WriteDirController() {}

    //    public void writeDir(string path)
    //    {

    //    }
    //}

    public class WriteDirController
    {
        public WriteDirController() { }

        public void writeDir(string path)
        {
            try
            {
                Directory.CreateDirectory(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
