using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Al_Gamil
{
    public partial class FormGiveEDS : Form
    {
        BigInteger p;
        BigInteger x;
        BigInteger g;
        BigInteger y;
        BigInteger m;
        BigInteger a;
        BigInteger b;
        public FormGiveEDS()
        {
            InitializeComponent();
        }

        public static int RevNum(BigInteger a, BigInteger mod)
        {
            List<int> listX = new List<int>();
            listX.Add(1);
            listX.Add(0);
            List<int> listY = new List<int>();
            listY.Add(0);
            listY.Add(1);
            int i = 2;
            BigInteger mod1 = mod;
            BigInteger a1 = a;
            BigInteger r = mod % a;
            BigInteger q;
            while (r != 1)
            {
                q = mod1 / a1;
                r = mod1 % a1;
                listX.Add(listX[i - 2] - (int)q * listX[i - 1]);
                listY.Add(listY[i - 2] - (int)q * listY[i - 1]);
                mod1 = a1;
                a1 = r;
                i++;
            }
            string str = (listX.Count - 1).ToString();
            int resX = listX[listX.Count - 1];
            int resY = listY[listY.Count - 1];
            if (resX <= 0)
            {
                resX = (int)(mod + resX);
            }
            if (resY <= 0)
            {
                resY = (int)(mod + resY);
            }
            if ((a * resX) % mod == 1)
            {
                return resX;
            }
            else
            {
                return resY;
            }


        }
        private BigInteger ConvertNumber(string str)
        {
            BigInteger m1 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                m1 += (Convert.ToInt32(str[i]) - 97) * Convert.ToInt32(Math.Pow(26, (str.Length - 1) - i));
            }

            return m1;
        }
        private string ConvertNumber(BigInteger num)
        {
            string result1 = "";
            string result2 = "";
            result2 = num.ToString();
            int num1 = Int32.Parse(result2);
            result2 = "";
            while (num1 != 0)
            {
                result1 += Convert.ToChar((num1 % 26) + 97);
                num1 /= 26;
            }
            for (int i = result1.Length - 1; i >= 0; i--)
            {
                result2 += result1[i];
            }
            return result2;
        }

        private bool Simple(BigInteger n)
        {

            if (n == 2)
            {
                return true;
            }
            if (n == 1 || n % 2 == 0)
            {
                return false;
            }
            double h = (double)n;
            for (int i = 3; i < Math.Sqrt(h); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private bool ChekP()
        {
            if (pTextBox.Text.Length == 0)
            {
                MessageBox.Show("P некорректно", "Ошибка");
                return false;
            }
            if (BigInteger.TryParse(pTextBox.Text, out p) == false)
            {
                MessageBox.Show("P некорректно", "Ошибка");
                return false;
            }
            if (p <= 0)
            {
                MessageBox.Show("P некорректно", "Ошибка");
                return false;
            }
            if (!Simple(p))
            {
                MessageBox.Show("P некорректно", "Ошибка");
                return false;
            }



            return true;
        }

        private bool ChekM()
        {
            if (mTextBox.Text.Length == 0)
            {
                MessageBox.Show("M некорректно", "Ошибка");
                return false;
            }
            if (BigInteger.TryParse(mTextBox.Text, out m) == false)
            {
                MessageBox.Show("M некорректно", "Ошибка");
                return false;
            }
            if (m <= 0)
            {
                MessageBox.Show("M некорректно", "Ошибка");
                return false;
            }

            return true;
        }

        private bool ChekX()
        {
            if (xTextBox.Text.Length == 0)
            {
                MessageBox.Show("X некорректно", "Ошибка");
                return false;
            }
            if (BigInteger.TryParse(xTextBox.Text, out x) == false)
            {
                MessageBox.Show("X некорректно", "Ошибка");
                return false;
            }
            if (x <= 0)
            {
                MessageBox.Show("X некорректно", "Ошибка");
                return false;
            }
            if (x >= p)
            {
                MessageBox.Show("X некорректно", "Ошибка");
                return false;
            }

            return true;
        }

        private bool ChekG()
        {
            if (gTextBox.Text.Length == 0)
            {
                MessageBox.Show("G некорректно", "Ошибка");
                return false;
            }
            if (BigInteger.TryParse(gTextBox.Text, out g) == false)
            {
                MessageBox.Show("G некорректно", "Ошибка");
                return false;
            }
            if (g <= 0)
            {
                MessageBox.Show("G некорректно", "Ошибка");
                return false;
            }
            if (g >= p)
            {
                MessageBox.Show("G некорректно", "Ошибка");
                return false;
            }

            return true;
        }
        private bool Chek()
        {
            if (ChekP() && ChekX() && ChekG())
            {
                return true;
            }
            return false;
        }

        private bool ChekA()
        {
            if (aTextBox.Text.Length == 0)
            {
                MessageBox.Show("A некорректно", "Ошибка");
                return false;
            }
            if (BigInteger.TryParse(aTextBox.Text, out a) == false)
            {
                MessageBox.Show("A некорректно", "Ошибка");
                return false;
            }
            if (a <= 0)
            {
                MessageBox.Show("A некорректно", "Ошибка");
                return false;
            }

            return true;
        }


        private bool ChekB()
        {
            if (bTextBox.Text.Length == 0)
            {
                MessageBox.Show("B некорректно", "Ошибка");
                return false;
            }
            if (BigInteger.TryParse(bTextBox.Text, out b) == false)
            {
                MessageBox.Show("B некорректно", "Ошибка");
                return false;
            }
            if (b <= 0)
            {
                MessageBox.Show("B некорректно", "Ошибка");
                return false;
            }

            return true;
        }

        private bool Chek1()
        {
            if (ChekA() && ChekB() && ChekM())
            {
                return true;
            }

            return false;
        }



        private void canselButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }



        private void okButton_Click(object sender, EventArgs e)
        {
            if (Chek() == true)
            {

                y = BigInteger.ModPow(g, x, p);
                yTextBox.Text = y.ToString();
                yTextBox.Enabled = true;
                pTextBox1.Text = pTextBox.Text;
                gTextBox1.Text = gTextBox.Text;
                xTextBox1.Text = xTextBox.Text;
                yTextBox1.Text = yTextBox.Text;
                pTextBox1.Enabled = false;
                gTextBox1.Enabled = false;
                xTextBox1.Enabled = false;
                yTextBox1.Enabled = false;


            }
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            if (Chek1() == true)
            {
                BigInteger cur = BigInteger.ModPow(a, p - 1 - x, p) * b;
                BigInteger.DivRem(cur, p, out cur);
                if (m == cur)
                {
                    richTextBox.BackColor = Color.Green;
                    richTextBox.Text = "Сообщение Не изменялось";
                }
                else
                {
                    richTextBox.BackColor = Color.Red;
                    richTextBox.Text = "Сообщение изменялось";
                }

            }
        }
    }
}
