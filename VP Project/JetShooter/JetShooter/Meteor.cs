using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JetShooter
{
    public class Meteor
    {
        public Point Location { get; set; }
        public Point Center { get; set; }
        public int Level { get; set; }
        public Meteor(Point location, int level)
        {
            Location = location;
            Center = new Point(location.X + 18, location.Y + 18);
            Level = level;
        }

        public void Draw(Graphics g)
        {
/*            Brush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush,Location.X,Location.Y,36,36);
            brush.Dispose();*/
        }

        public void MoveMeteor()
        {
            Location = new Point(Location.X,Location.Y+2*Level);
            Center = new Point(Location.X + 18, Location.Y + 18);
        }
    }
}
