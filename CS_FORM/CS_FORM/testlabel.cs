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

        public void updatetext(int number)
        {
            switch(number)
            {
                case 1:
                    Text = "ブロリー…です…";
                    break;
                case 2:
                    Text = "はい";
                    break;
                case 3:
                    Text= "カカロットォ…カカロットォ！！！ ";
                    break;
                case 4:
                    Text = "パラガスでございます";
                    break;
                case 5:
                    Text = "もうだめだぁ…おしまいだぁ…";
                    break;
                case 6:
                    Text = "逃げるんだぁ…勝てるわけがないよぉ…";
                    break;
                case 7:
                    Text = "十円！！";
                    break;
                case 8:
                    Text = "終わったな　所詮クズは　クズなのだ";
                    break;
                case 9:
                    Text = "カカロットじゃねぇ！オラ！孫悟空だ！";
                    break;
                case 10:
                    Text = "やっと能天気なお前でも呑み込めたようだな";
                    break;
                case 11:
                    Text = "いいぞぉ！今のお前のパワーでサイヤ人をこの世から消し去ってしまえー！！ﾋﾟﾛﾛﾛﾛ";
                    break;
            }
            
           
        }
    }
}
