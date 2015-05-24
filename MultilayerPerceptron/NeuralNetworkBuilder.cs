using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    public class NeuralNetworkBuilder
    {
        private List<Layer> Layers { get; set; }

        public NeuralNetworkBuilder(params int[] neurons)
        {
            Layers = new List<Layer>();

            if (neurons.Length == 0) return;

            var nonFunction = new NonFunction();
            var sigmoid = new SigmoidFunction(1);

            Layers.Add(new Layer(neurons[0], nonFunction));
            for(var i = 1; i < neurons.Length; i++)
            {
                if(neurons[i] != 0)
                Layers.Add(new Layer(neurons[i], sigmoid));
            }
        }

        private List<Link> ImplementInputLinks()
        {
            List<Link> links = new List<Link>();
            foreach(var inputNeuron in Layers[0].Neurons)
            {
                links.Add(new Link{
                    Neuron = inputNeuron,
                    Weight = 1
                });
            }

            return links;
        }

        public MultilayerNeuralNetwork Build()
        {
            LayersConnector lc = new LayersConnector();
            lc.EstablishLinks(Layers);

            List<Link> links = ImplementInputLinks();

            return new MultilayerNeuralNetwork {
                Layers = this.Layers,
                inputLinks = links
            };
        }
    }
}
