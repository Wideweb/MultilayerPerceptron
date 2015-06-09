using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    [Serializable]
    public class TrainingSample
    {
        public double[] Sample { get; set; }
        public double[] Answer { get; set; }
    }

    public interface ITrainingAlgorithm
    {
        LearningAlgorithmConfig Config { get; set; }
        event EventHandler<TrainingEventArgs> TrainingEvent;

        void Train(INeuralNetwork neuralNetwork, List<TrainingSample> trainingSamples);
    }
}
