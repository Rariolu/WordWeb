using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordWebCS
{
    public static class Util
    {
        public static SuperRand superRand = new SuperRand();
        public static double Lerp(double a, double b, double f)
        {
            return a + f * (b - a);
        }
        public static string ReplaceRedundants(this string text, string newExcept, params string[] oldExcerpts)
        {
            foreach(string oldExcerpt in oldExcerpts)
            {
                text = text.Replace(oldExcerpt, newExcept);
            }
            return text;
        }
    }
}