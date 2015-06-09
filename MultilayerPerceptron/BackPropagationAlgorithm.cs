using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    [Serializable]
    public class BackPropagationAlgorithm : ITrainingAlgorithm
    {
        public LearningAlgorithmConfig Config { get; set; }

        public event EventHandler<TrainingEventArgs> TrainingEvent;

        public BackPropagationAlgorithm(LearningAlgorithmConfig config)
        {
            this.Config = config;
        }

        public void Train(INeuralNetwork neuralNetwork, List<TrainingSample> trainingSamples)
        {
            double[] output;

            for (var i = 0; i < Config.Epoches; i++)
            {

                foreach (var sample in trainingSamples)
                {
                    output = neuralNetwork.ComputeOutput(sample.Sample);

                    if (TrainingEvent != null)
                        TrainingEvent(this, new TrainingEventArgs
                        {
                            E = Config.ErrorFunction.Compute(sample.Answer, output)
                        });

                    SpreadErrorSignals(neuralNetwork, sample.Answer);
                }
            }
        }

        void SpreadErrorSignals(INeuralNetwork neuralNetwork, double[] answer)
        {
            int length = neuralNetwork.Layers.Count;
            List<Layer> layers = neuralNetwork.Layers;

            ComputeGradientForOutputNeurons(layers[length - 1], answer);
            for (var i = length - 2; i > 0; i--)
            {
                ComputeGradientForInnerNeurons(layers[i], answer);
            }
            CorrectWeights(neuralNetwork);
        }

        void CorrectWeights(INeuralNetwork neuralNetwork)
        {
            int lenght = neuralNetwork.Layers.Count;
            List<Layer> layers = neuralNetwork.Layers;

            for(var i = 1; i < lenght; i ++)
            {
                foreach(var neuron in layers[i].Neurons)
                {
                    foreach(var incomingLink in neuron.IncomingLinks)
                    {
                        incomingLink.dw = incomingLink.dw * Config.InertiaMoment + neuron.dEdS
                            * incomingLink.Neuron.OUT * Config.TrainingSpeed;
                        incomingLink.Weight -= incomingLink.dw;

                        if (incomingLink.Weight == double.NaN) throw new Exception("Backprop: Nan weight");
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

                neuron.dEdS = 
                    Config.ErrorFunction.ComputePartialDerivative(answer, layer.LastOutput, i)
                    * function.ComputeFirstDerivative(neuron.LastNET);
                    
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

                var d = function.ComputeFirstDerivative(neuron.LastNET);
                var e = InnerNeuronError(neuron);

                neuron.dEdS = d * e;

            }
        }

        double InnerNeuronError(INeuron neuron)
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
