using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JetShooter
{
    public class MeteorBoss
    {
        public Point Location { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public MeteorBoss(Point location, int level)
        {
            Location = location;
            Level = level;
            Health = 100 * level;
        }

        public void Draw(Graphics g)
        {
/*            Brush brush = new SolidBrush(Color.Purple);
            g.FillEllipse(brush, Location.X, Location.Y, 500, 500);
            brush.Dispose();*/
        }

        public void MoveBoss()
        {
            Location = new Point(Location.X, Location.Y+1);
        }
    }
}
