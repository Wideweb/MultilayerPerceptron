using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    class BackPropagationAlgorithm : ITrainingAlgorithm
    {
        private IProximityMeasure proximityMeasure;
        private double trainingSpeed;

        public BackPropagationAlgorithm(IProximityMeasure pm)
        {
            proximityMeasure = pm;
            trainingSpeed = 0.7;
        }

        public void Train(MultilayerNeuralNetwork neuralNetwork, List<TrainingSample> trainingSamples)
        {
            double[] output;
            foreach(var sample in trainingSamples)
            {
                output = neuralNetwork.ComputeOutput(sample.Sample);    
            }
        }

        void SpreadErrorSignals(MultilayerNeuralNetwork neuralNetwork, double[] answer)
        {
            int length = neuralNetwork.Layers.Count;
            List<Layer> layers = neuralNetwork.Layers;

            ComputeGradientForOutputNeurons(layers[length - 1], answer);
            for(var i = length - 2; i > 0; i--)
            {
                for(var j = 0; j < layers[i].InputDimension; j++)
                {
                    ComputeGradientForInnerNeurons(layers[length - 1], answer);
                }
            }
            CorrectWeights(neuralNetwork);
        }

        void CorrectWeights(MultilayerNeuralNetwork neuralNetwork)
        {
            int lenght = neuralNetwork.Layers.Count;
            List<Layer> layers = neuralNetwork.Layers;

            for(var i = 1; i < lenght; i ++)
            {
                foreach(var neuron in layers[i].Neurons)
                {
                    foreach(var incomingLink in neuron.IncomingLinks)
                    {
                        incomingLink.Weight -= neuron.dEdS
                            * trainingSpeed
                            * incomingLink.Neuron.OUT;
                    }
                }
            }
        }

        void ComputeGradientForOutputNeurons(Layer layer, double[] answer)
        {
            INeuron neuron;
            IFunction function;
            for(var i = 0; i < layer.InputDimension; i++)
            {
                neuron = layer.Neurons[i];
                function = neuron.ActivationFunction;

                neuron.dEdS = -1
                    * proximityMeasure.ComputePartialDerivative(layer.LastOutput, answer, i)
                    * function.ComputeFirstDerivative(neuron.NET);
                    
            }
        }

        void ComputeGradientForInnerNeurons(Layer layer, double[] answer)
        {
            INeuron neuron;
            IFunction function;
            for (var i = 0; i < layer.InputDimension; i++)
            {
                neuron = layer.Neurons[i];
                function = neuron.ActivationFunction;

                neuron.dEdS = function.ComputeFirstDerivative(neuron.NET) 
                    * dEdS_forInnerNeuron(neuron);

            }
        }

        double dEdS_forInnerNeuron(INeuron neuron)
        {
            double result = 0;
            foreach(var outputLink in neuron.OutgoingLinks)
            {
                result += outputLink.Neuron.dEdS
                    * outputLink.Weight;
            }

            return result;
        }
    }
}
