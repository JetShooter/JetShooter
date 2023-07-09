using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JetShooter
{
    public class Scene
    {
        public List<Meteor> listMeteor { get; set; }
        public int Points { get; set; } = 0;
        public int highScore { get; set; }
        public playerClass Player { get; set; }
        public MeteorBoss Boss { get; set; }
        public int LifeCounter { get; set; } = 5;
        public double Width { get; set; }
        public double Height { get; set; }
        public int Hardness { get; set; }

        public Scene(double width, double height, int highScore)
        {
            this.highScore = highScore;
            Width = width;
            Height = height;
            listMeteor = new List<Meteor>();
            Point point = new Point((int)Width / 2 - 10, (int) height - 50);
            Player = new playerClass(1, point);
        }


        public void addMeteor(Meteor meteor)
        {
            listMeteor.Add(meteor);
        }

        public void Draw(Graphics g)
        {
            Player.Draw(g);

            foreach (var m in listMeteor)
            {
                m.Draw(g);
            }
            if(Boss != null)
            {
                Boss.Draw(g);
            }
            
        }

        internal void MovePlayer(Point location)
        {
            Player.Location = new Point(location.X, (int)Height - 150);
        }

        internal void FireBullets()
        {
            Player.Shoot();
        }


        internal void MoveBullets()
        {
            if (Player.listBullets.Count > 0)
            {
                Player.MoveBullets();
            }
        }

        internal void MoveMeteors()
        {
            foreach (var m in listMeteor)
            {
                m.MoveMeteor();
            }
        }
        public struct HitResult
        {
            public int MeteorIndex { get; set; }
            public int BulletIndex { get; set; }
        }
        internal HitResult isHit()
        {
            for (int j = Player.listBullets.Count - 1; j >= 0; j--)
            {
                for (int i = listMeteor.Count - 1; i >= 0; i--)
                {
                    if (Hit(listMeteor[i].Center, Player.listBullets[j].Center))
                    {
                        listMeteor.RemoveAt(i);
                        Player.listBullets.RemoveAt(j);
                        Points++;
                        return new HitResult
                        {
                            MeteorIndex = i,
                            BulletIndex = j
                        };
                    }
                }
            }
            return new HitResult
            {
                MeteorIndex = -1,
                BulletIndex = -1
            };
        }
        public bool Hit(Point m, Point b)
        {
            return Math.Sqrt(Math.Pow(m.X - b.X, 2) + Math.Pow(m.Y - b.Y, 2)) < 25;
        }

        public bool HitBoss(Point m, Point b)
        {
            return Math.Sqrt(Math.Pow(m.X - b.X, 2) + Math.Pow(m.Y - b.Y, 2)) < 280;
        }

        internal bool isMeteorOutOfBorders()
        {
            for (int i = listMeteor.Count - 1; i >= 0; i--)
            {
               if (listMeteor[i].Location.Y > Height || Hit(listMeteor[i].Location, Player.Location))
               {
                    listMeteor.RemoveAt(i);
                    LifeCounter--;
                    return true;
                }
            }
            return false;
        }

        internal void isBulletOutOfBorders()
        {
            for (int i = Player.listBullets.Count - 1; i >= 0; i--)
            {
                if (Player.listBullets[i].Location.Y < -5)
                {
                    Player.listBullets.RemoveAt(i);
                    break;
                }
            }
        }

        internal void addBoss(MeteorBoss boss)
        {
            Boss = boss;
        }

        internal void MoveBoss()
        {
            if (Boss != null) 
            {
                Boss.MoveBoss();
            }
        }
    }
}
