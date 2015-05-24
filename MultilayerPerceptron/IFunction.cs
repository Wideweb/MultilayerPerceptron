using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    public interface IFunction
    {
        double Compute(double x);
        double ComputeFirstDerivative(double x);
    }
}
