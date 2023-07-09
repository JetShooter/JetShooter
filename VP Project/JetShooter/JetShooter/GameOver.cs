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
    public partial class GameOver : Form
    {
        public GameOver(int score,int highScore)
        {
            InitializeComponent();
            scoreLabel.Text = "Score: " + score;
            highScoreLabel.Text = "High Score: " + highScore;
            this.BackgroundImage = Image.FromFile("Images/GameOver.jpeg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Width = 420;
            this.Height = 250;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void GameOver_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void GameOver_Resize(object sender, EventArgs e)
        {
            this.Width = 420;
            this.Height = 250;
        }
    }
}
