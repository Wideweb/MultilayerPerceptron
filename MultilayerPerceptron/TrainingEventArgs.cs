using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    public class TrainingEventArgs : EventArgs
    {
        public double E { get; set; }
        public double[] output { get; set; }
    }
}
