﻿using System;
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
        public TestButton(int x,int y,
            int width, int height)
        {
            //clickイベントにonclickを登録
            Click += Onclick;
            Text = "ボタン";
            Location = new Point(x,y);
            Size = new Size(width,height);
        }

        public void Onclick(object sender, EventArgs s)
        {
            MessageBox.Show("オッス!オラ悟空!");

        }
    }
}