﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_FORM
{
    internal class TestButton : Button
    {
        Form1 _form1;
        testtextbox _testtextbox;
        public TestButton(Form1 form1 ,int x,int y,
            int width, int height,
            int number, string[] name)
        {
            _form1 = form1;
            string numberstr = number.ToString();
            Name = numberstr;
            //clickイベントにonclickを登録
            Click += Onclick;
            Text = $"{name[number]}";
            Location = new Point(x,y);
            Size = new Size(width,height);
        }

        
        public void Onclick(object sender, EventArgs s)
        {
            //_form1.labeltextupgrade(int.Parse(Name));
            Text = _form1.textboxupgrade(Text);

        }
    }
}
