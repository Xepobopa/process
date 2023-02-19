using System.Diagnostics;
using System.Text;
using Newtonsoft.Json;
using Sys.Controllers;

Console.WriteLine(new ReadFileController().ReadFile(Environment.GetCommandLineArgs()[1]));