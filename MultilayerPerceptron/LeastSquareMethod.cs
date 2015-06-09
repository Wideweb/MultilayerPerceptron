using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    [Serializable]
    public class LeastSquareMethod : IProximityMeasure
    {
        public double Compute(double[] d, double[] y)
        {
            double E = 0;
            for(var i = 0; i < d.Length; i++)
            {
                E += (d[i] - y[i]) * (d[i] - y[i]);
            }

            return E * 0.5;
        }

        public double ComputePartialDerivative(double[] d, double[] y, int Index)
        {
            return y[Index] - d[Index];
        }
    }
}
