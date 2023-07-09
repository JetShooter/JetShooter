using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JetShooter
{
    public class Bullet
    {
        public Point Location { get; set; }
        public Point Center { get; set; }

        public Bullet(Point location)
        {
            Location = location;
            Center = new Point(location.X + 5, location.Y + 5);
        }

        public void Draw(Graphics g)
        {
/*            Brush brush = new SolidBrush(Color.Green);
            g.FillEllipse(brush, Location.X - 5, Location.Y - 20, 10, 10);
            brush.Dispose();*/
        }

        public void MoveBullet()
        {
            Location = new Point(Location.X, Location.Y-10);
            Center = new Point(Location.X + 5, Location.Y + 5);
        }
    }
}