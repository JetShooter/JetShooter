using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JetShooter
{
    public class playerClass
    {
        public Point Location { get; set; }
        public int Power { get; set; }
        public int MissCounter { get; set; }
        public List<Bullet> listBullets { get; set; }
        public int Health { get; set; }

        public playerClass(int power, Point location)
        {
            Health = 5;
            Power = power;
            Location = location;
            MissCounter = 5;
            listBullets = new List<Bullet>();
        }

        public void Draw(Graphics g)
        {
/*            Brush brush = new SolidBrush(Color.Transparent);
            g.FillEllipse(brush, Location.X - 20, Location.Y, 40, 40);
            brush.Dispose();*/

            foreach (var b in listBullets)
            {
                b.Draw(g);
            }
        }

        public void addBullet(Bullet bullet)
        {
            listBullets.Add(bullet);
        }

        public void removeBullet(Bullet bullet)
        {
            listBullets.Remove(bullet);
        }

        public void Shoot()
        {
            Bullet bullet = new Bullet(Location);
            addBullet(bullet);
        }

        internal void MoveBullets()
        {
            foreach (var b in listBullets)
            {
                b.MoveBullet();
            }
        }
    }
}
