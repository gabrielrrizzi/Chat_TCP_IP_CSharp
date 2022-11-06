using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_IP_Server.ViewController
{
    public class DarkMode
    {
        public static void ChangetoDarkMode(MaterialForm form)
        {
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(form);
            manager.Theme = MaterialSkinManager.Themes.DARK;
            manager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey900, Accent.LightBlue100, TextShade.WHITE);
        }

    }
}
