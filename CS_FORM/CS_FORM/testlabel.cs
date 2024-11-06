using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_FORM
{
    class Testlabel : Label
    {
        public Testlabel(string str, int x, int y, int width, int height)
        {

            Text = str;

            Location = new Point(x, y);

            Size = new Size(width, height);

        }

        public void updatetext(string str)
        {
            Text = str;
        }
    }
}
