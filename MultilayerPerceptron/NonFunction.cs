using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    [Serializable]
    public class NonFunction : IFunction
    {
        public double Compute(double x)
        {
            return x;
        }

        public double ComputeFirstDerivative(double x)
        {
            return 1;
        }
    }
}
