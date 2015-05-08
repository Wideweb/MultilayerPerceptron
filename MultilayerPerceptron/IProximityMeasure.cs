using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    interface IProximityMeasure
    {
        double Compute(double[] x, double[] y);
        double ComputePartialDerivative(double[] x, double[] y, int Index);
    }
}
