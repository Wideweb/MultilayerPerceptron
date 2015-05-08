using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    class Layer
    {
        public double[] LastOutput { get; set; }
        public int InputDimension { get; set; }
        public List<INeuron> Neurons { get; set; }

        public Layer(int length, IFunction activationFunction)
        {
            InputDimension = length;

            Neurons = new List<INeuron>();
            for (var i = 0; i < length; i++)
            {
                Neurons.Add(new Neuron(activationFunction));
            }
        }

        public void Activate()
        {
            var output = new double[Neurons.Count];
            for(var i = 0; i < Neurons.Count; i ++)
            {
                output[i] = Neurons[i].Activate();
            }

            LastOutput = output;
        }
    }
}
