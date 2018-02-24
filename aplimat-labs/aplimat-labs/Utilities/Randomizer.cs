using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplimat_labs.Utilities
{
    public class Randomizer
    {
        private double min, max;
        private Random random;

        public Randomizer(double _min, double _max)
        {
            this.min = _min;
<<<<<<< HEAD
            this.max = _max + 1; //add one because Random's max is exclusive value
=======
            this.max = _max + 1; //add one because
>>>>>>> c79c0b298f8088a0c70a564e5dbdd0420038b0ef
            this.random = new Random();
        }

        public double GenerateDouble()
        {
            return random.NextDouble() * (max - min) + min;
        }

        public int GenerateInt()
        {
            return (int)random.Next((int)min, (int)max);
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> c79c0b298f8088a0c70a564e5dbdd0420038b0ef
