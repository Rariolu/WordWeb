using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordWebCS
{
    public struct Vector3
    {
        public double X;
        public double Y;
        public double Z;
        public Vector3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static Vector3 operator+(Vector3 vec, double n)
        {
            return new Vector3(vec.X + n, vec.Y + n, vec.Z + n);
        }
        public static Vector3 operator*(Vector3 vec, double n)
        {
            return new Vector3(vec.X * n, vec.Y * n, vec.Z * n);
        }
        public static implicit operator Vector3(double[] arr)
        {
            Vector3 vec3 = new Vector3();
            vec3.X = arr.Length > 0 ? arr[0] : 0;
            vec3.Y = arr.Length > 1 ? arr[1] : 0;
            vec3.Z = arr.Length > 2 ? arr[2] : 0;
            return vec3;
        }
        public void Lerp(Vector3 vec3, double f)
        {
            X = Util.Lerp(X, vec3.X, f);
            Y = Util.Lerp(Y, vec3.Y, f);
            Z = Util.Lerp(Z, vec3.Z, f);
        }
    }
}