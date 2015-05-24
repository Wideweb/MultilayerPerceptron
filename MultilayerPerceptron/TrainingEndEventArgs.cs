﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerPerceptron
{
    public class TrainingEndEventArgs : EventArgs
    {
        public List<INeuron> neurons { get; set; }
    }
}
