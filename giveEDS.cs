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
    public partial class giveEDS : Form
    {
        BigInteger p;
        BigInteger x;
        BigInteger g;
        BigInteger y;
        BigInteger m;
        BigInteger k;
        BigInteger a;
        BigInteger b;
        public giveEDS()
        {
            InitializeComponent();
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
            string resutl = "";
            for (int i = 0; i < mTextBox.Text.Length; i++)
            {
                if (Convert.ToInt32(mTextBox.Text[i]) < 97 || Convert.ToInt32(mTextBox.Text[i]) > 122)
                {
                    continue;
                }
                resutl += mTextBox.Text[i];
            }
            if (resutl.Length == 0)
            {
                MessageBox.Show("M некорректно", "Ошибка");
                return false;
            }
            mTextBox.Text = resutl;
            return true;
        }



        private bool ChekY()
        {
            if (yTextBox.Text.Length == 0)
            {
                MessageBox.Show("Y некорректно", "Ошибка");
                return false;
            }
            if (BigInteger.TryParse(yTextBox.Text, out y) == false)
            {
                MessageBox.Show("Y некорректно", "Ошибка");
                return false;
            }
            if (y <= 0)
            {
                MessageBox.Show("Y некорректно", "Ошибка");
                return false;
            }
            if (y >= p)
            {
                MessageBox.Show("Y некорректно", "Ошибка");
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


        private bool ChekK()
        {
            if (kTextBox.Text.Length == 0)
            {
                MessageBox.Show("K некорректно", "Ошибка");
                return false;
            }
            if (BigInteger.TryParse(kTextBox.Text, out k) == false)
            {
                MessageBox.Show("K некорректно", "Ошибка");
                return false;
            }
            if (k <= 0)
            {
                MessageBox.Show("K некорректно", "Ошибка");
                return false;
            }
            if (BigInteger.GreatestCommonDivisor(k,p-1) != 1)
            {
                MessageBox.Show("P некорректно", "Ошибка");
                return false;
            }


            return true;
        }

        private bool Chek()
        {
            if (ChekP() && ChekG() && ChekM() && ChekY()&& ChekK())
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
                m = ConvertNumber(mTextBox.Text);
                mCTextBox.Text = m.ToString();
                a = BigInteger.ModPow(g, k, p);
                aTextBox.Text = a.ToString();
                b = BigInteger.ModPow(BigInteger.ModPow(y, k, p) * m, 1, p);
                bTextBox.Text = b.ToString();

            }
        }
    }
}
