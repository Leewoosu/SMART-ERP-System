using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary.FormHelper
{
    public static class FormHelper
    {
        public static void SetFormLocation(this Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(
                Screen.PrimaryScreen.Bounds.Width / 2 - form.Size.Width / 2,
                Screen.PrimaryScreen.Bounds.Height / 2 - form.Size.Height / 2);
        }
    }
}
