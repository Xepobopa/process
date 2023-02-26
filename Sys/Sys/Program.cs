using System.Diagnostics;
using System.Text;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using Sys.Controllers;

[DllImport("kernel32.dll")]
static extern IntPtr GetConsoleWindow();

[DllImport("user32.dll")]
static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

const int SW_HIDE = 0;
const int SW_SHOW = 5;

var handle = GetConsoleWindow();

// Hide
ShowWindow(handle, SW_HIDE);



string path = Environment.GetCommandLineArgs()[1]?.Length > 0 
    ? Environment.GetCommandLineArgs()[1] 
    : @"C:\Users\Public\Documents\Xepobopa\defaultState.txt";

string[] progs = new ReadFileController(path).GetJson();

while (true) { 
    foreach (string prog in progs)
    {
        try { 
            Process.GetProcessesByName(prog)[0].Kill();
        } catch (Exception e) {
            Console.WriteLine(e);
        }
    }
    Thread.Sleep(400);
    GC.Collect();
}
