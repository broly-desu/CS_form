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
        Testlabel _Testlabel;
        public Form1()
        {
            InitializeComponent();

            for (int countcreate = 0; countcreate <= 10;countcreate++)    
            {
                string countstring = (countcreate+1).ToString();
                TestButton testButton = new TestButton(this,countcreate % 5 * 100, countcreate / 5 * 100, 100, 100,countstring);
                Controls.Add(testButton);
            }
            _Testlabel = 
                new Testlabel("ラベルのテスト",0,300, 500, 200);
            Controls.Add(_Testlabel);

            ///Label testlabel = new Label();
            ///testlabel.Location = new Point(1000,0);
            ///testlabel.Text = "aa";
            ///Controls.Add(testlabel);            
        }
        public void labeltextupgrade(string str)
        {
            _Testlabel.updatetext(str);
        }
    }
}
