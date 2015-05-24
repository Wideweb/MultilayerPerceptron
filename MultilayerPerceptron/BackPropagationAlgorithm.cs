using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    public class BackPropagationAlgorithm : ITrainingAlgorithm
    {
        private IProximityMeasure proximityMeasure;
        private double trainingSpeed;
        private double alpha;

        public event EventHandler<TrainingEventArgs> TrainingEvent;

        public BackPropagationAlgorithm(IProximityMeasure pm, double trainingSpeed, double alpha)
        {
            proximityMeasure = pm;
            this.trainingSpeed = trainingSpeed;
            this.alpha = alpha;

        }

        public void Train(MultilayerNeuralNetwork neuralNetwork, List<TrainingSample> trainingSamples)
        {
            double[] output;
            foreach(var sample in trainingSamples)
            {
                output = neuralNetwork.ComputeOutput(sample.Sample);

                if(TrainingEvent != null)
                TrainingEvent(this, new TrainingEventArgs{
                    E = proximityMeasure.Compute(sample.Answer, output)
                    //E = output[0]
                });

                SpreadErrorSignals(neuralNetwork, sample.Answer);
            }
        }

        void SpreadErrorSignals(MultilayerNeuralNetwork neuralNetwork, double[] answer)
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
                        incomingLink.dw = incomingLink.dw * alpha + (1 - alpha) * neuron.dEdS
                            * incomingLink.Neuron.OUT;
                        incomingLink.Weight -= incomingLink.dw * trainingSpeed;

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
                    proximityMeasure.ComputePartialDerivative(answer, layer.LastOutput, i)
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
                var de = dEdS_forInnerNeuron(neuron);

                neuron.dEdS = d * de;

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
