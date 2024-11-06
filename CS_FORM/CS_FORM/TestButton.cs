using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_FORM
{
    internal class TestButton : Button
    {
        Form1 _form1;
        public TestButton(Form1 form1 ,int x,int y,
            int width, int height,
            string number)
        {
            _form1 = form1;
            Name = number;
            //clickイベントにonclickを登録
            Click += Onclick;
            Text = $"ボタン{number}";
            Location = new Point(x,y);
            Size = new Size(width,height);
        }

        
        public void Onclick(object sender, EventArgs s)
        {
            _form1.labeltextupgrade(int.Parse(Name));
        }
    }
}
