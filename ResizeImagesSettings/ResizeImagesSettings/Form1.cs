using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ResizeImagesSettings
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnRightClick_Click(object sender, EventArgs e)
    {
      Process.Start("ResizeImagesRegKeys.exe");
    }

    private void btnSetSize_Click(object sender, EventArgs e)
    {
      Process proc = new Process();
      proc.StartInfo.FileName = "ResizeImagesRegKeys.exe";
      proc.StartInfo.Arguments = spinWidth.Value + " " + spinHeight.Value;
      proc.Start();
    }
  }
}
