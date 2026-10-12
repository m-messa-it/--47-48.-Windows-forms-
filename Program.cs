using System;
using System.Windows.Forms;
using PostServiceFormsApp.Forms;

namespace PostServiceFormsApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}