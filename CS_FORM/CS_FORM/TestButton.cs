using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_FORM
{
    internal class TestButton : Button
    {
        public TestButton() 
        {
            //clickイベントにonclickを登録
            Click += Onclick;
        }

        public void Onclick(object sender, EventArgs s)
        {
            MessageBox.Show("オッス!オラ悟空!");

        }
    }
}
