using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    public class Link
    {
        public INeuron Neuron { get; set; }
        public double Weight { get; set; }
        public double dw { get; set; }

        public Link()
        {
            Weight = 0;
            dw = 0;
        }

        public void SendImpulse(double impulse)
        {
            if (Weight == double.NaN) throw new Exception("Link: NAN Weight");
            Neuron.ReceiveImpulse(impulse * Weight);
        }
    }
}
