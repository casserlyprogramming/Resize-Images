using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace ResizeImages2
{
  public partial class Form1 : Form
  {
    string[] m_args;
    public Form1(string [] args)
    {
      InitializeComponent();
      m_args = args;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      int height = 200;
      int width = 200;

      object rWidth = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Resize Images\\", "Width", null);
      object rheight = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Resize Images\\", "Width", null);
      if (rWidth != null)
        width = Convert.ToInt32(rWidth);
      if (rheight != null)
        height = Convert.ToInt32(rheight);

      string s = "";
      foreach (string str in m_args)
      {
        try
        {
          Image img = Image.FromFile(str);
          Image newimg = ResizeImage(img, new Size(width, height));
          newimg.Save(Path.GetDirectoryName(str) + @"\small" + Path.GetFileName(str));
          s += "small" + str + Environment.NewLine;
        }
        catch (Exception err)
        {
          MessageBox.Show(err.Message);
        }
      }
      this.Close();
    }


    //--------------------------------------------------------------------------------
    private static System.Drawing.Image ResizeImage(System.Drawing.Image imgToResize, Size size)
    {
      int sourceWidth = imgToResize.Width;
      int sourceHeight = imgToResize.Height;

      float nPercent = 0;
      float nPercentW = 0;
      float nPercentH = 0;

      nPercentW = ((float)size.Width / (float)sourceWidth);
      nPercentH = ((float)size.Height / (float)sourceHeight);

      if (nPercentH < nPercentW)
        nPercent = nPercentH;
      else
        nPercent = nPercentW;

      int destWidth = (int)(sourceWidth * nPercent);
      int destHeight = (int)(sourceHeight * nPercent);

      Bitmap b = new Bitmap(destWidth, destHeight);
      Graphics g = Graphics.FromImage((System.Drawing.Image)b);
      g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

      g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
      g.Dispose();

      return (System.Drawing.Image)b;
    }
  }
}
