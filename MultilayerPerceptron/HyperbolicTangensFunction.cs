using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    class HyperbolicTangensFunction : IFunction
    {
        private double alpha;

        internal HyperbolicTangensFunction(double alpha)
        {
            this.alpha = alpha;
        }

        public double Compute(double x)
        {
            return (Math.Tanh(alpha * x));
        }

        public double ComputeFirstDerivative(double x)
        {
            double t = Math.Tanh(alpha * x);
            return alpha * (1 - t * t);
        }

    }
}
