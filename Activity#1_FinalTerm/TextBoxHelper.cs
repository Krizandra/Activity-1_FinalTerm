using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1_FinalTerm
{
    public static class TextBoxHelper
    {

        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public static void SetPlaceholder(this TextBox textBox, string placeholder, bool showWhenFocused = false)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, showWhenFocused ? 1 : 0, placeholder);
        }

    }
}
