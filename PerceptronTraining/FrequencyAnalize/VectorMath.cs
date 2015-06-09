using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronTraining
{
    static class VectorMath
    {
        public static double[] NormalizeVector(double[] v)
        {
            double vectorLength = CoumputeVectorLength(v);
            double[] result = new double[v.Length];
            for (var i = 0; i < v.Length; i++)
            {
                result[i] = vectorLength == 0 ? 0 : v[i] / vectorLength;
            }

            return result;
        }

        public static double CoumputeVectorLength(double[] v)
        {
            return Math.Sqrt(v.Sum(x => x * x));
        }
    }
}
