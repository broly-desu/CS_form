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
            string[] strs =
            {
                "アカ",
                "アオ",
                "キ",
                "オレンジ",
                "ミドリ",
                "ブロリー",
                "パラガス",
                "カカロット",
                "ベジータ",
                "虫ケラ",
                "トランクス",
            };

            for (int countcreate = 0; countcreate <= 10;countcreate++)    
            {
                TestButton testButton = new TestButton(this,countcreate % 5 * 100, countcreate / 5 * 100, 100, 100, countcreate, strs);
                Controls.Add(testButton);
            }
            _Testlabel = 
                new Testlabel("ラベルのテスト",0,300, 500, 20);
            Controls.Add(_Testlabel);

            ///Label testlabel = new Label();
            ///testlabel.Location = new Point(1000,0);
            ///testlabel.Text = "aa";
            ///Controls.Add(testlabel);      
            testtextbox testtextbox = new testtextbox("戦う意思を見せなければ俺はこの星を破壊しつくすだけだぁ…", 0, 320, 500, 200);
            Controls.Add(testtextbox);
        }
        public void labeltextupgrade(int number)
        {
            _Testlabel.updatetext(number);
        }
    }
}
