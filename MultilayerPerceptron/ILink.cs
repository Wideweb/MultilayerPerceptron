using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    public interface ILink
    {
        INeuron Neuron { get; set; }
        double Weight { get; set; }
        double dw { get; set; }

        void SendImpulse(double impulse);
    }
}
