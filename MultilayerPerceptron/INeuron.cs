using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    public interface INeuron
    {
        List<Link> IncomingLinks { get; set; }
        List<Link> OutgoingLinks { get; set; }

        double NET { get; set; }
        double OUT { get; set; }

        double LastNET { get; set; }
        double dEdS { get; set; }

        IFunction ActivationFunction { get; set; }

        double Activate();

        void ReceiveImpulse(double impulse);

        void SendImpulse();
    }
}
