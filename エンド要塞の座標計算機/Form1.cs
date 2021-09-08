using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Double;

namespace エンド要塞の座標計算機
{
    public partial class エンド要塞特定 : Form
    {
        public エンド要塞特定()
        {
            InitializeComponent();
        }

        private static (double x, double y) 連立方程式の解(double a, double b, double c, double d, double p, double q)
        {
            var x = (p * d - b * q) / (a * d - b * c);
            var y = (a * q - p * c) / (a * d - b * c);
            return (x, y);
        }

        private static (double a, double b, double c) To一次方程式(double x1, double y1, double x2, double y2)
        {
            double a, b, c;
            if (Math.Abs(x1 - x2) < 0.1)
            {
                a = 1;
                b = 0;
                c = x1;
            }
            else if (Math.Abs(y1 - y2) < 0.1)
            {
                a = 0;
                b = 1;
                c = y1;
            }
            else
            {
                a = -(y2 - y1) / (x2 - x1);
                b = 1;
                c = a * x1 + y1;
            }

            return (a, b, c);
        }

        private void 再計算(object sender, EventArgs e)
        {
            double x10, x11, x20, x21, z10, z11, z20, z21;
            var tryParse = new bool[8];
            tryParse[0] = TryParse(this.x10.Text, out x10);
            tryParse[1] = TryParse(this.x11.Text, out x11);
            tryParse[2] = TryParse(this.x20.Text, out x20);
            tryParse[3] = TryParse(this.x21.Text, out x21);
            tryParse[4] = TryParse(this.z10.Text, out z10);
            tryParse[5] = TryParse(this.z11.Text, out z11);
            tryParse[6] = TryParse(this.z20.Text, out z20);
            tryParse[7] = TryParse(this.z21.Text, out z21);
            if (tryParse.Any((b => !b))) return;

            double a1, b1, c1, a2, b2, c2;
            (a1, b1, c1) = To一次方程式(x10, z10, x11, z11);
            (a2, b2, c2) = To一次方程式(x20, z20, x21, z21);

            double x, z;
            (x, z) = 連立方程式の解(a1, b1, a2, b2, c1, c2);

            要塞の座標.Text = $"エンド要塞の座標は X={x:F0}, Z={z:F0} です";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.要塞の座標.Text);
        }
    }
}