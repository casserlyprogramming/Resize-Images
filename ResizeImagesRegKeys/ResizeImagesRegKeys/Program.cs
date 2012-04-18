using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace ResizeImagesRegKeys
{
  class Program
  {
    static void Main(string[] args)
    {
      if (args.Length > 0)
      {
        RegistryKey SoftwareKey = Registry.CurrentUser.OpenSubKey("Software\\", true);
        RegistryKey myKey = SoftwareKey.CreateSubKey("Resize Images");
        myKey.SetValue("Width", args[0]);
        myKey.SetValue("Height", args[1]);
      }
      else
      {
        RegistryKey key1 = Registry.ClassesRoot.OpenSubKey("\\*\\shell", true);
        RegistryKey resizekey = key1.CreateSubKey("Resize Images");
        resizekey.SetValue("Icon", "\"C:\\Program Files\\Resize Images\\favicon.ico\"");
        RegistryKey resizeCommand = resizekey.CreateSubKey("command");
        if (IntPtr.Size == 4)
          resizeCommand.SetValue("", "\"C:\\Program Files\\Resize Images\\ResizeImages2.exe\" \"%1\"");
        else
          resizeCommand.SetValue("", "\"C:\\Program Files (x86)\\Resize Images\\ResizeImages2.exe\" \"%1\"");
      }
    }
  }
}
