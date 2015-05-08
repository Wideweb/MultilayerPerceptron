using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    class Link
    {
        public INeuron Neuron { get; set; }
        public double Weight { get; set; }

        public void SendImpulse(double impulse)
        {
            Neuron.ReceiveImpulse(impulse * Weight);
        }
    }
}
