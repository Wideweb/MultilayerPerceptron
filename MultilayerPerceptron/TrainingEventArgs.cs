using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    [Serializable]
    public class TrainingEventArgs : EventArgs
    {
        public double E { get; set; }
        public double[] output { get; set; }
    }
}
