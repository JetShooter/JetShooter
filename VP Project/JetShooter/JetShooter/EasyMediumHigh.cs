using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JetShooter
{
    public partial class EasyMediumHigh : Form
    {
        public int Hardness { get; set; } = -1;
        public EasyMediumHigh()
        {
            InitializeComponent();
            this.BackColor = Color.PowderBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hardness = 1;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hardness = 2;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hardness = 3;
            this.Close();
        }

        private void EasyMediumHigh_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*if (Hardness == -1)
            {
                Hardness = 1;
                this.Close();
            }else
            {*/
                this.Close();
            //}
        }

        private void EasyMediumHigh_Resize(object sender, EventArgs e)
        {
            this.Width = 400;
            this.Height = 180;
        }
    }
}
