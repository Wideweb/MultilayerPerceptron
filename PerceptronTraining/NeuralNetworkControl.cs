using MultilayerPerceptron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerceptronTraining
{
    public class NeuralNetworkControl : UserControl
    {
        private Label neuralNetworkType;
        private INeuralNetwork watch;

        //public INeuralNetwork Watch { get { return GetWatch(); } }
        //public string WatchType { get { return neuralNetworkType.Text; } set { SetWatchType(value); } }

        public void Add(Control c)
        {
            c.Parent = this;
            this.Controls.Add(c);
        }

        public IEnumerable<NeuralNetworkPropertyField> GetNeuralNetworkFields()
        {
            foreach (Control c in this.Controls)
            {
                if (c is NeuralNetworkPropertyField)
                {
                    yield return (c as NeuralNetworkPropertyField);
                }
            }
        }

        public Dictionary<string, string> GetWatchFieldsAsDictionary()
        {
            var dic = new Dictionary<string, string>();
            foreach (NeuralNetworkPropertyField nnpf in GetNeuralNetworkFields())
            {
                dic.Add(nnpf.fieldName.Text, nnpf.fieldValue.Text);
            }

            return dic;
        }
        /*
        private INeuralNetwork GetWatch()
        {
            var visitor = new WatchInitVisitor(GetWatchFieldsAsDictionary());
            return visitor.DynemicVisit(watch);
        }

        private void SetWatchType(string type)
        {
            watchType.Text = type;
        }*/


        private void InitializeComponent()
        {
            this.neuralNetworkType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // neuralNetworkType
            // 
            this.neuralNetworkType.AutoSize = true;
            this.neuralNetworkType.Location = new System.Drawing.Point(0, 0);
            this.neuralNetworkType.Name = "neuralNetworkType";
            this.neuralNetworkType.Size = new System.Drawing.Size(102, 13);
            this.neuralNetworkType.TabIndex = 0;
            this.neuralNetworkType.Text = "NeuralNetworkType";
            // 
            // NeuralNetworkControl
            // 
            this.Controls.Add(this.neuralNetworkType);
            this.Name = "NeuralNetworkControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
