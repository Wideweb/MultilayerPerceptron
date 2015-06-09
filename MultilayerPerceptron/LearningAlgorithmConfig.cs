using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    [Serializable]
    public class LearningAlgorithmConfig
    {
        public double TrainingSpeed { get; set; }

        public double InertiaMoment { get; set; }

        public int Epoches { get; set; }

        public IProximityMeasure ErrorFunction { get; set; }
    }
}
