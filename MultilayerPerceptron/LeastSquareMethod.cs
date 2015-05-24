using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    public class LeastSquareMethod : IProximityMeasure
    {
        public double Compute(double[] v1, double[] v2)
        {
            double E = 0;
            for(var i = 0; i < v1.Length; i++)
            {
                E += (v1[i] - v2[i]) * (v1[i] - v2[i]);
            }

            return E * 0.5;
        }

        public double ComputePartialDerivative(double[] v1, double[] v2, int Index)
        {
            return v2[Index] - v1[Index];
        }
    }
}
