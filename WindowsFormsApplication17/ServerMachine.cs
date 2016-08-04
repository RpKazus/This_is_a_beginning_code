using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    static class ServerMachine
    {
        public static string primer;
        public static string type;
        public static MethodInvoker MethodToMath;
        public static TabPage ActivePage;
        public static string pressed = "";
        public static Button button_button;
        public static MethodInvoker Invalidate;
        public static int usage = 0;
        public static PictureBox senPic = null;
        public static Image[] BackImages = new Image[5] { Properties.Resources.backcolor_5, Properties.Resources.backcolor_4, Properties.Resources.backcolor_3, Properties.Resources.backcolor_1, Properties.Resources.backcolor_2};
    }
}
