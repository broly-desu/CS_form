using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            int countcreate = 1;
            int locationpoint = 0;
            InitializeComponent();

            while (countcreate < 100)
            {
                locationpoint = (countcreate
                    - 1) * 100;
                TestButton testButton = new TestButton(locationpoint, 0, 100, 100);
                Controls.Add(testButton);
                countcreate++;
            }
        }
    }
}
