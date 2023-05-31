using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comboBox.Classes
{
    class DistanceTraveled
    {
        private int speed;
        private int time;

        public DistanceTraveled(int speed, int time)
        {
            this.speed = speed;
            this.time = time;
        }

        public int GetDistance()
        {
            return speed * time;
        }
    }
}
