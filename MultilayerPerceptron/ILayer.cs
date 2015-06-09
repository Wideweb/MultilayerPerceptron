using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    public interface ILayer
    {
        double[] LastOutput { get; set; }
        int InputDimension { get; set; }
        List<INeuron> Neurons { get; set; }

        void Activate();
    }
}
