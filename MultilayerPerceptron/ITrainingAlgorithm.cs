﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    public class TrainingSample
    {
        public double[] Sample { get; set; }
        public double[] Answer { get; set; }
    }

    interface ITrainingAlgorithm
    {
        void Train(MultilayerNeuralNetwork neuralNetwork, List<TrainingSample> trainingSamples);
    }
}