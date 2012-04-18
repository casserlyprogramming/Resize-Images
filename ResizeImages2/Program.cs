using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ResizeImages2.Properties;
using Microsoft.Win32;

namespace ResizeImages2
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1(args));
    }
  }
}
