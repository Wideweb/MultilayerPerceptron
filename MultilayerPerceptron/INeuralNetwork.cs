using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    public interface INeuralNetwork
    {
        List<Layer> Layers { get; set; }
        List<Link> inputLinks { get; set; }

        double[] ComputeOutput(double[] inputVector);
    }
}
