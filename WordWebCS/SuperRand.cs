using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordWebCS
{
    public class SuperRand: Random
    {
        public double NextDouble(double max)
        {
            return NextDouble(0, max);
        }
        public double NextDouble(double min, double max)
        {
            double range = max - min;
            return NextDouble() * range + min;
        }
        public Vector3 RandomVector3(double min, double max)
        {
            double range = max - min;
            return (RandomVector3() * range) + min;
        }
        public Vector3 RandomVector3()
        {
            return new Vector3(NextDouble(), NextDouble(), NextDouble());
        }
    }
}