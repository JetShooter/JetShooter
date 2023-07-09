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
    public partial class Form1 : Form
    {
        public Random random { get; set; } = new Random();

        public DoubleBufferedPictureBox skin1 { get; set; }
        public DoubleBufferedPictureBox skin2 { get; set; }
        public DoubleBufferedPictureBox skin3 { get; set; }
        public DoubleBufferedPictureBox skin4 { get; set; }
        public DoubleBufferedPictureBox skin5 { get; set; }
        public DoubleBufferedPictureBox skin6 { get; set; }
        public DoubleBufferedPictureBox skin7 { get; set; }
        public DoubleBufferedPictureBox skin8 { get; set; }
        public DoubleBufferedPictureBox skin9 { get; set; }
        public int Hardness { get; set; } = -1;

        public string choosenSkin { get; set; } = "";
        public int sizeSkin { get; set; } = 1;
        public Form1()
        {
            skin1 = new DoubleBufferedPictureBox();
            skin2 = new DoubleBufferedPictureBox();
            skin3 = new DoubleBufferedPictureBox();
            skin4 = new DoubleBufferedPictureBox();
            skin5 = new DoubleBufferedPictureBox();
            skin6 = new DoubleBufferedPictureBox();
            skin7 = new DoubleBufferedPictureBox();
            skin8 = new DoubleBufferedPictureBox();
            skin9 = new DoubleBufferedPictureBox();
            InitializeComponent();
            DoubleBuffered = true;
            this.Width = 1300;
            this.Height = 800;
            this.BackgroundImage = Image.FromFile("Images/background.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void PLAY_Click(object sender, EventArgs e)
        {
            EasyMediumHigh form = new EasyMediumHigh();
            form.ShowDialog();
            Hardness = form.Hardness;
            if (Hardness == -1)
            {
                this.Close();
            }

            switch (random.Next(0, 5))
            {
                case 0:
                    this.BackgroundImage = Image.FromFile("Images/background skins 1.jpg");
                    break;
                case 1:
                    this.BackgroundImage = Image.FromFile("Images/background skins 2.jpg");
                    break;
                case 2:
                    this.BackgroundImage = Image.FromFile("Images/background skins 3.jpg");
                    break;
                case 3:
                    this.BackgroundImage = Image.FromFile("Images/background skins 4.jpg");
                    break;
                default:
                    this.BackgroundImage = Image.FromFile("Images/background skins 5.jpg");
                    break;
            }
            this.BackgroundImageLayout = ImageLayout.Stretch;

            PLAY.Visible = false;
            groupBox1.Visible = false;
            label3.Visible = false;
            label2.Visible = false;

            try
            {
                skin1.Width = 190;
                skin1.Height = 190;
                skin1.Location = new Point(200, 50);
                skin1.Click += skin1_MouseClick;
                skin1.MouseEnter += skin1_BackgroundChanger;
                skin1.MouseLeave += skin_BackgroundChanger;
                string relativeImagePath = "Images/Barbarian 2.png";
                string imagePath = System.IO.Path.Combine(Application.StartupPath, relativeImagePath);
                Image image = Image.FromFile(imagePath);
                skin1.Image = image;
                skin1.SizeMode = PictureBoxSizeMode.StretchImage;
                skin1.BackColor = Color.Transparent;
                this.Controls.Add(skin1);

                skin2.Width = 280;
                skin2.Height = 180;
                skin2.Location = new Point(510, 60);
                skin2.Click += skin2_MouseClick;
                skin2.MouseEnter += skin2_BackgroundChanger;
                skin2.MouseLeave += skin_BackgroundChanger;
                relativeImagePath = "Images/Soldier 1.png";
                imagePath = System.IO.Path.Combine(Application.StartupPath, relativeImagePath);
                image = Image.FromFile(imagePath);
                skin2.Image = image;
                skin2.SizeMode = PictureBoxSizeMode.StretchImage;
                skin2.BackColor = Color.Transparent;
                this.Controls.Add(skin2);

                skin3.Width = 190;
                skin3.Height = 190;
                skin3.Location = new Point(910, 50);
                skin3.Click += skin3_MouseClick;
                skin3.MouseEnter += skin3_BackgroundChanger;
                skin3.MouseLeave += skin_BackgroundChanger;
                relativeImagePath = "Images/Warrior 2.png";
                imagePath = System.IO.Path.Combine(Application.StartupPath, relativeImagePath);
                image = Image.FromFile(imagePath);
                skin3.Image = image;
                skin3.SizeMode = PictureBoxSizeMode.StretchImage;
                skin3.BackColor = Color.Transparent;
                this.Controls.Add(skin3);

                skin4.Width = 130;
                skin4.Height = 230;
                skin4.Location = new Point(230, 270);
                skin4.Click += skin4_MouseClick;
                skin4.MouseEnter += skin4_BackgroundChanger;
                skin4.MouseLeave += skin_BackgroundChanger;
                relativeImagePath = "Images/Lingo 3.png";
                imagePath = System.IO.Path.Combine(Application.StartupPath, relativeImagePath);
                image = Image.FromFile(imagePath);
                skin4.Image = image;
                skin4.SizeMode = PictureBoxSizeMode.StretchImage;
                skin4.BackColor = Color.Transparent;
                this.Controls.Add(skin4);

                skin5.Width = 280;
                skin5.Height = 180;
                skin5.Location = new Point(510, 305);
                skin5.Click += skin5_MouseClick;
                skin5.MouseEnter += skin5_BackgroundChanger;
                skin5.MouseLeave += skin_BackgroundChanger;
                relativeImagePath = "Images/Destroyer 1.png";
                imagePath = System.IO.Path.Combine(Application.StartupPath, relativeImagePath);
                image = Image.FromFile(imagePath);
                skin5.Image = image;
                skin5.SizeMode = PictureBoxSizeMode.StretchImage;
                skin5.BackColor = Color.Transparent;
                this.Controls.Add(skin5);

                skin6.Width = 130;
                skin6.Height = 230;
                skin6.Location = new Point(940, 270);
                skin6.Click += skin6_MouseClick;
                skin6.MouseEnter += skin6_BackgroundChanger;
                skin6.MouseLeave += skin_BackgroundChanger;
                relativeImagePath = "Images/Spacecraft 3.png";
                imagePath = System.IO.Path.Combine(Application.StartupPath, relativeImagePath);
                image = Image.FromFile(imagePath);
                skin6.Image = image;
                skin6.SizeMode = PictureBoxSizeMode.StretchImage;
                skin6.BackColor = Color.Transparent;
                this.Controls.Add(skin6);

                skin7.Width = 280;
                skin7.Height = 180;
                skin7.Location = new Point(155, 530);
                skin7.Click += skin7_MouseClick;
                skin7.MouseEnter += skin7_BackgroundChanger;
                skin7.MouseLeave += skin_BackgroundChanger;
                relativeImagePath = "Images/Starrios 1.png";
                imagePath = System.IO.Path.Combine(Application.StartupPath, relativeImagePath);
                image = Image.FromFile(imagePath);
                skin7.Image = image;
                skin7.SizeMode = PictureBoxSizeMode.StretchImage;
                skin7.BackColor = Color.Transparent;
                this.Controls.Add(skin7);

                skin8.Width = 130;
                skin8.Height = 230;
                skin8.Location = new Point(585, 510);
                skin8.Click += skin8_MouseClick;
                skin8.MouseEnter += skin8_BackgroundChanger;
                skin8.MouseLeave += skin_BackgroundChanger;
                relativeImagePath = "Images/Black Panther 3.png";
                imagePath = System.IO.Path.Combine(Application.StartupPath, relativeImagePath);
                image = Image.FromFile(imagePath);
                skin8.Image = image;
                skin8.SizeMode = PictureBoxSizeMode.StretchImage;
                skin8.BackColor = Color.Transparent;
                this.Controls.Add(skin8);

                skin9.Width = 280;
                skin9.Height = 180;
                skin9.Location = new Point(865, 530);
                skin9.Click += skin9_MouseClick;
                skin9.MouseEnter += skin9_BackgroundChanger;
                skin9.MouseLeave += skin_BackgroundChanger;
                relativeImagePath = "Images/Legion 1.png";
                imagePath = System.IO.Path.Combine(Application.StartupPath, relativeImagePath);
                image = Image.FromFile(imagePath);
                skin9.Image = image;
                skin9.SizeMode = PictureBoxSizeMode.StretchImage;
                skin9.BackColor = Color.Transparent;
                this.Controls.Add(skin9);
            }
            catch (Exception ex)
            {
                // Handle the exception if the image loading fails.
                MessageBox.Show("Error loading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void skin_BackgroundChanger(object sender, EventArgs e)
        {
            /*skin1.BackColor = Color.FromArgb(100, 192, 192, 192);
            skin2.BackColor = Color.FromArgb(100, 192, 192, 192);
            skin3.BackColor = Color.FromArgb(100, 192, 192, 192);
            skin4.BackColor = Color.FromArgb(100, 192, 192, 192);
            skin5.BackColor = Color.FromArgb(100, 192, 192, 192);
            skin6.BackColor = Color.FromArgb(100, 192, 192, 192);
            skin7.BackColor = Color.FromArgb(100, 192, 192, 192);
            skin8.BackColor = Color.FromArgb(100, 192, 192, 192);
            skin9.BackColor = Color.FromArgb(100, 192, 192, 192);*/
            Cursor = Cursors.Arrow;
        }
        private void skin1_BackgroundChanger(object sender, EventArgs e)
        {
            //skin1.BackColor = Color.FromArgb(200, 192, 192, 192);
            Cursor = Cursors.Hand;
        }
        private void skin2_BackgroundChanger(object sender, EventArgs e)
        {
            //skin2.BackColor = Color.FromArgb(200, 192, 192, 192);
            Cursor = Cursors.Hand;
        }
        private void skin3_BackgroundChanger(object sender, EventArgs e)
        {
            //skin3.BackColor = Color.FromArgb(200, 192, 192, 192);
            Cursor = Cursors.Hand;
        }
        private void skin4_BackgroundChanger(object sender, EventArgs e)
        {
            //skin4.BackColor = Color.FromArgb(200, 192, 192, 192);
            Cursor = Cursors.Hand;
        }
        private void skin5_BackgroundChanger(object sender, EventArgs e)
        {
            //skin5.BackColor = Color.FromArgb(200, 192, 192, 192);
            Cursor = Cursors.Hand;
        }
        private void skin6_BackgroundChanger(object sender, EventArgs e)
        {
            //skin6.BackColor = Color.FromArgb(200, 192, 192, 192);
            Cursor = Cursors.Hand;
        }
        private void skin7_BackgroundChanger(object sender, EventArgs e)
        {
            //skin7.BackColor = Color.FromArgb(200, 192, 192, 192);
            Cursor = Cursors.Hand;
        }
        private void skin8_BackgroundChanger(object sender, EventArgs e)
        {
            //skin8.BackColor = Color.FromArgb(200, 192, 192, 192);
            Cursor = Cursors.Hand;
        }
        private void skin9_BackgroundChanger(object sender, EventArgs e)
        {
            //skin9.BackColor = Color.FromArgb(200, 192, 192, 192);
            Cursor = Cursors.Hand;
        }
        private void skin1_MouseClick(object sender, EventArgs e)
        {
            choosenSkin = "Images/Barbarian 2.png";
            sizeSkin = 2;
            this.Close();
        }
        private void skin2_MouseClick(object sender, EventArgs e)
        {
            choosenSkin = "Images/Soldier 1.png";
            sizeSkin = 1;
            this.Close();
        }
        private void skin3_MouseClick(object sender, EventArgs e)
        {
            choosenSkin = "Images/Warrior 2.png";
            sizeSkin = 2;
            this.Close();
        }
        private void skin4_MouseClick(object sender, EventArgs e)
        {
            choosenSkin = "Images/Lingo 3.png";
            sizeSkin = 3;
            this.Close();
        }
        private void skin5_MouseClick(object sender, EventArgs e)
        {
            choosenSkin = "Images/Destroyer 1.png";
            sizeSkin = 1;
            this.Close();
        }
        private void skin6_MouseClick(object sender, EventArgs e)
        {
            choosenSkin = "Images/Spacecraft 3.png";
            sizeSkin = 3;
            this.Close();
        }
        private void skin7_MouseClick(object sender, EventArgs e)
        {
            choosenSkin = "Images/Starrios 1.png";
            sizeSkin = 1;
            this.Close();
        }
        private void skin8_MouseClick(object sender, EventArgs e)
        {
            choosenSkin = "Images/Black Panther 3.png";
            sizeSkin = 3;
            this.Close();
        }
        private void skin9_MouseClick(object sender, EventArgs e)
        {
            choosenSkin = "Images/Legion 1.png";
            sizeSkin = 1;
            this.Close();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Width = 1300;
            this.Height = 800;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            if(choosenSkin.Length == 0)
            {
                this.Close();
            }
        }
    }
}
