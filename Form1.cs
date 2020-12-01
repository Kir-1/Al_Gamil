using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Gamil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void takeEDSButton_Click(object sender, EventArgs e)
        {
            FormGiveEDS formGiveEDS = new FormGiveEDS();
            formGiveEDS.Show();
        }

        private void giveEDSButton_Click(object sender, EventArgs e)
        {
            giveEDS giveEDS = new giveEDS();
            giveEDS.Show();
        }


    }
}


