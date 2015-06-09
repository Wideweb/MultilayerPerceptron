using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    [Serializable]
    public class TrainingEndEventArgs : EventArgs
    {
        public List<INeuron> neurons { get; set; }
    }
}
