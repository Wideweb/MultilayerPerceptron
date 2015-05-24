using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    public class MultilayerNeuralNetwork : INeuralNetwork
    {
        public List<Layer> Layers { get; set; }
        public List<Link> inputLinks { get; set; }

        public MultilayerNeuralNetwork()
        {
            Layers = new List<Layer>();
            inputLinks = new List<Link>();
        }

        public double[] ComputeOutput(double[] inputVector)
        {
            if (Layers.Count == 0)
                throw new Exception("MultilayerNeuralNetwork don't has layers");

            if(Layers[0].Neurons.Count != inputVector.Length)
                throw new Exception("Incorrect length of the input vector");

            SendSignalToTheFirstLayer(inputVector);
            ConductSignalOverLayers();
            return ReceiveSignalFormTheLastLayer();
        }

        private void SendSignalToTheFirstLayer(double[] inputVector)
        {
            for(var i = 0; i < inputVector.Length; i++)
            {
                inputLinks[i].SendImpulse(inputVector[i]);
            }
        }

        private void ConductSignalOverLayers()
        {
            for(var i = 0; i < Layers.Count; i++)
            {
                Layers[i].Activate();
            }
        }

        private double[] ReceiveSignalFormTheLastLayer()
        { 
            return Layers[Layers.Count - 1].LastOutput;
        }
    }
}
