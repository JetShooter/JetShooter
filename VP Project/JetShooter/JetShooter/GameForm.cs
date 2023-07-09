using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JetShooter
{
    public partial class GameForm : Form
    {
        Scene scene;
        public DoubleBufferedPictureBox picture { get; set; }
        public List<DoubleBufferedPictureBox> picturesOfBullets { get; set; }
        public List<DoubleBufferedPictureBox> pictureOfMeteors { get; set; }
        public DoubleBufferedPictureBox Boss { get; set; }
        public int Level { get; set; } = 1;
        public int MoveCounter { get; set; } = 0;
        public bool FlagGameOver { get; set; } = true;
        public int MeteorsCounter { get; set; }
        public int SpawnMeteors { get; set; } = 0;
        public bool createABoss { get; set; } = true;
        public int sizeSkin { get; set; }
        public string choosenSkin { get; set; }
        public int Hardness { get; set; }

        Random random = new Random();

        public GameForm(int sizeSkin, string choosenSkin, int highScore, int hardness)
        {
            this.sizeSkin = sizeSkin;
            this.choosenSkin = choosenSkin;
            DoubleBuffered = true;
            this.Hardness = hardness;
            picture = new DoubleBufferedPictureBox();
            picturesOfBullets = new List<DoubleBufferedPictureBox>();
            pictureOfMeteors = new List<DoubleBufferedPictureBox>();
            Boss = new DoubleBufferedPictureBox();
            InitializeComponent();

            switch (sizeSkin)
            {
                case 1:
                    picture.Width = 220;
                    picture.Height = 120;
                    break;
                case 2:
                    picture.Width = 150;
                    picture.Height = 150;
                    break;
                default:
                    picture.Width = 120;
                    picture.Height = 220;
                    break;
            }

            /*            switch(random.Next(0,4))
                        {
                            case 0:
                                this.BackgroundImage = Image.FromFile("Images/gameForm.jpg");
                                this.BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                            case 1:
                                this.BackgroundImage = Image.FromFile("Images/gameForm1.jpg");
                                this.BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                            case 2:
                                this.BackgroundImage = Image.FromFile("Images/gameForm4.jpg");
                                this.BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                            default:
                                this.BackgroundImage = Image.FromFile("Images/gameForm3.jpg");
                                this.BackgroundImageLayout = ImageLayout.Stretch;
                                break;
                        }*/

            //this.BackColor = Color.LightBlue;

            this.BackgroundImage = Image.FromFile("Images/gameForm3.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            picture.Location = new Point(this.Width / 2 - picture.Width / 2, this.Height - picture.Height - 100);
            picture.Click += picture_MouseClick; 
            //picture.SendToBack();


            scene = new Scene(this.Width, this.Height, highScore);
            TimerBulletMove.Start();
            TimerMeteorMove.Start();
            MeteorsCounter = Level * 5 * Hardness;
            pointsStats.Text = "Points: 0";
            lifeLeft.Text = "Left Lifes: 5";
            levelLabel.Text = "Level: 1";
            bossHealth.Visible = false;
            bossHealth.Location = new Point(20, 860);
            bossHealth.Width = 740;
            this.Width = 800;
            this.Height = 950;
            //Cursor.Hide();
            try
            {
                string imagePath = System.IO.Path.Combine(Application.StartupPath, choosenSkin);
                Image image = Image.FromFile(imagePath);
                picture.Image = image;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.BackColor = Color.Transparent;
            }
            catch (Exception ex)
            {
                // Handle the exception if the image loading fails.
                MessageBox.Show("Error loading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Controls.Add(picture);
        }

        private void picture_MouseClick(object sender, EventArgs e)
        {
            if (FlagGameOver)
            {
                DoubleBufferedPictureBox pic = new DoubleBufferedPictureBox();
                string path = System.IO.Path.Combine(Application.StartupPath, "Images/bullet.png");
                Image bulletImage = Image.FromFile(path);
                pic.Image = bulletImage;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.BackColor = Color.Transparent;
                pic.Click += picture_MouseClick;
                pic.Width = 40;
                pic.Height = 40;
                pic.Location = new Point(scene.Player.Location.X - pic.Width/2, scene.Player.Location.Y - pic.Height/2);
                picturesOfBullets.Add(pic);
                this.Controls.Add(pic);

                scene.FireBullets();
                //scene.isHit();

                //Invalidate();
            }
        }

        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (FlagGameOver) 
            {
                scene.MovePlayer(e.Location);
                picture.Left = e.X - picture.Width/2;
                
            }
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            if (scene.Boss != null)
            {
                bossHealth.Value = scene.Boss.Health;
            }
            loadStats();
            scene.Draw(e.Graphics);
        }

        private void TimerBulletMove_Tick(object sender, EventArgs e)
        {
            scene.MoveBullets();
            for (int i = picturesOfBullets.Count - 1; i >= 0; i--)
            {
                if (picturesOfBullets[i].Location.Y < -40)
                {
                    picturesOfBullets[i].Dispose();
                    picturesOfBullets.RemoveAt(i);
                } else {
                    picturesOfBullets[i].Location = new Point(picturesOfBullets[i].Location.X, picturesOfBullets[i].Location.Y - 10); 
                }
            }

            scene.isBulletOutOfBorders();

            Invalidate();
        }

        private void GameForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (FlagGameOver)
            {
                if (e.Button == MouseButtons.Left)
                {
                    scene.FireBullets();
                    //scene.isHit();

                    DoubleBufferedPictureBox pic = new DoubleBufferedPictureBox();
                    string path = System.IO.Path.Combine(Application.StartupPath, "Images/bullet.png");
                    Image bulletImage = Image.FromFile(path);
                    pic.Image = bulletImage;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.BackColor = Color.Transparent;
                    pic.Click += picture_MouseClick;
                    pic.Width = 40;
                    pic.Height = 40;
                    pic.Location = new Point(scene.Player.Location.X - pic.Width / 2, scene.Player.Location.Y - pic.Height / 2);
                    picturesOfBullets.Add(pic);
                    this.Controls.Add(pic);
                }
                //Invalidate();
            }
        }

        private void TimerMeteorMove_Tick(object sender, EventArgs e)
        {
            MoveCounter++;
            if (MoveCounter % 70 == 0 && SpawnMeteors != (Hardness * 5 * Level))
            {
                Meteor meteor = new Meteor(new Point(random.Next(30, Width - 60), -60), Level);
                scene.addMeteor(meteor);
                SpawnMeteors++;

                DoubleBufferedPictureBox pic = new DoubleBufferedPictureBox();
                string path = System.IO.Path.Combine(Application.StartupPath, "Images/meteor.png");
                Image meteorImage = Image.FromFile(path);
                pic.Image = meteorImage;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Click += picture_MouseClick;
                pic.BackColor = Color.Transparent;
                pic.Width = 50;
                pic.Height = 50;
                pic.Location = new Point(meteor.Location.X - 8, meteor.Location.Y - 6);
                pictureOfMeteors.Add(pic);
                this.Controls.Add(pic);
            }

            scene.MoveMeteors();
            int size = pictureOfMeteors.Count;
            for (int i = size - 1; i >= 0; i--)
            {
                if (pictureOfMeteors[i].Location.Y > this.Height || scene.Hit(pictureOfMeteors[i].Location, scene.Player.Location))
                {
                    pictureOfMeteors[i].Dispose();
                    pictureOfMeteors.RemoveAt(i);
                }
                else
                {
                    pictureOfMeteors[i].Location = new Point(pictureOfMeteors[i].Location.X, pictureOfMeteors[i].Location.Y + 2*Level);
                }
            }


            var hitResult = scene.isHit();
            int meteorIndex = hitResult.MeteorIndex;
            int bulletIndex = hitResult.BulletIndex;

            if (meteorIndex != -1)
            {
                MeteorsCounter--;

                picturesOfBullets[bulletIndex].Dispose();
                picturesOfBullets.RemoveAt(bulletIndex);

                pictureOfMeteors[meteorIndex].Dispose();
                pictureOfMeteors.RemoveAt(meteorIndex);
            }

            if(scene.isMeteorOutOfBorders()) 
            {
                MeteorsCounter--;
            }
            if (scene.LifeCounter == 0)
            {
                loadStats();
                TimerBulletMove.Stop();
                TimerMeteorMove.Stop();
                FlagGameOver = false;
                this.Close();
                if (scene.Points > scene.highScore)
                {
                    scene.highScore = scene.Points;
                }
                GameOver form = new GameOver(scene.Points, scene.highScore);

                form.ShowDialog();
                if (form.DialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    GameForm gameForm = new GameForm(sizeSkin, choosenSkin, scene.highScore, Hardness);
                    gameForm.ShowDialog();
                    this.Close();

                }
                else if (form.DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    GameForm form2 = new GameForm(form1.sizeSkin, "", scene.highScore, form1.Hardness);
                    form2.ShowDialog();
                }
                else
                {
                    this.Close();
                }
            }


            if (MeteorsCounter == 0)
            {
                createABoss = true;
            
                BossTimer.Start();
                TimerMeteorMove.Stop();
            }
            //Invalidate();
        }

        private void loadStats()
        {
            pointsStats.Text = "Points: " + scene.Points.ToString();
            lifeLeft.Text = "Left Lifes: " + scene.LifeCounter.ToString();
            levelLabel.Text = "Level: " + Level;

        }
        private void GameForm_Resize(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 950;
        }

        private void BossTimer_Tick(object sender, EventArgs e)
        {
            if (createABoss)
            {
                Boss = new DoubleBufferedPictureBox();
                MeteorBoss boos = new MeteorBoss(new Point(this.Width / 2 - 250, -500), Level);

                string path = System.IO.Path.Combine(Application.StartupPath, "Images/boss 1.png");
                Image meteorImage = Image.FromFile(path);
                Boss.Image = meteorImage;
                Boss.SizeMode = PictureBoxSizeMode.StretchImage;
                Boss.Click += picture_MouseClick;
                Boss.MouseMove += picture_MouseMove;
                Boss.BackColor = Color.Transparent;
                Boss.Width = 500;
                Boss.Height = 500;
                Boss.Location = boos.Location;
                pictureOfMeteors.Add(Boss);
                this.Controls.Add(Boss);

                bossHealth.Visible = true;
                bossHealth.ForeColor = Color.Purple;
                scene.addBoss(boos);
                createABoss = false;
                bossHealth.Maximum = scene.Boss.Health;
                bossHealth.Value = scene.Boss.Health;
            }

            scene.MoveBoss();
            if (Boss != null)
            {
                Boss.Location = new Point(Boss.Location.X, Boss.Location.Y + 1);
            }

            if (scene.Boss == null)
            {
                MeteorsCounter = Hardness * 5 * (++Level);
                TimerMeteorMove.Interval -= 2;
                TimerMeteorMove.Start();
                BossTimer.Stop();
                SpawnMeteors = 0;
                pictureOfMeteors.Clear();
                scene.listMeteor.Clear();
                bossHealth.Visible = false;
            }


            if (scene.Boss != null && scene.HitBoss(scene.Player.Location, new Point(scene.Boss.Location.X + 250, scene.Boss.Location.Y + 250)))
            {
                scene.Boss = null;
                scene.LifeCounter = 0;
                Boss.Dispose();
                Boss = null;
                return;
            }
            if (scene.Boss != null)
            {
                for (int j = scene.Player.listBullets.Count - 1; j >= 0; j--)
                {
                    if (scene.HitBoss(new Point(scene.Boss.Location.X + 250, scene.Boss.Location.Y + 250), scene.Player.listBullets[j].Center))
                    {
                        if (scene.Boss.Health > 0)
                        {
                            scene.Boss.Health -= scene.Player.Power * 5;
                        }
                        if (scene.Boss.Health <= 0)
                        {
                            scene.Boss = null;
                            Boss.Dispose();
                            Boss = null;
                            scene.Points += 20;
                        }
                        scene.Player.listBullets.RemoveAt(j);

                        picturesOfBullets[j].Dispose();
                        picturesOfBullets.RemoveAt(j);
                        break;
                    }
                }
            }

            Invalidate();
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (picture.Width == 150)
            {
                scene.Player.Location = new Point(e.X + picture.Width, scene.Player.Location.Y);
                picture.Location = new Point(e.X + picture.Width/2, picture.Location.Y);
            } else if (picture.Width == 220)
            {
                scene.Player.Location = new Point(e.X + 150, scene.Player.Location.Y);
                picture.Location = new Point(e.X + 40, picture.Location.Y);
            } else
            { 
                scene.Player.Location = new Point(e.X + 150, scene.Player.Location.Y);
                picture.Location = new Point(e.X + 90, picture.Location.Y);
            }
        }
        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
