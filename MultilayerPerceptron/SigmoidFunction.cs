using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    internal class SigmoidFunction : IFunction
    {

        private double alpha = 1;

        internal SigmoidFunction(double alpha)
        {
            this.alpha = alpha;
        }

        public double Compute(double x)
        {
            double r = (1 / (1 + Math.Exp(-1 * alpha * x)));
            return r;
        }

        public double ComputeFirstDerivative(double x)
        {
            return alpha * this.Compute(x) * (1 - this.Compute(x));
        }
    }

}
