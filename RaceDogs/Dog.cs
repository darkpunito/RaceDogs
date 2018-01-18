using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceDogs
{
    class Dog
    {
        public int startingposition;
        public int racetracklength;
        public PictureBox MyPictureBox = null;
        public int location = 0;
        public Random random;

        public bool Run()
        {
            random = new Random();
            int distance = random.Next(1, 4);

            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
            if (MyPictureBox.Location.X >= racetracklength)
            {
                return true;
            }

            return false;
            
        }
        public void TakeStartingPosition()
        {
            location = startingposition;
            //todo
        }
    }
}
