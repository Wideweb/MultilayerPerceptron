using MultilayerPerceptron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronTraining
{
    public interface INeuralNetworkVisitor<T>
    {
        T DynemicVisit(INeuralNetwork w);
    }

    public abstract class NeuralNetworkVisitor<T> : INeuralNetworkVisitor<T> where T : new()
    {
        public virtual T DynemicVisit(INeuralNetwork w)
        {
            Visit((dynamic)w);
            return new T();
        }
        protected abstract void Visit(INeuralNetwork w);

        protected virtual void Visit(MultilayerNeuralNetwork w) { Visit((MultilayerNeuralNetwork)w); }
    }

    public class WidgetNeuralNetworkVisitor : NeuralNetworkVisitor<NeuralNetworkControl>
    {
        private int elementY;
        private int elementMarginY = 10;
        private int elementMarginX = 10;
        private int elementStartPosY = 25;
        private string networkType;

        NeuralNetworkControl watchControl;

        public override NeuralNetworkControl DynemicVisit(INeuralNetwork w)
        {
            watchControl = new NeuralNetworkControl();
            elementY = elementStartPosY;
            base.DynemicVisit(w);
            //watchControl.WatchType = networkType;
            watchControl.Height = elementMarginY;

            return watchControl;
        }

        protected override void Visit(INeuralNetwork nn)
        {
            var nnpf = new NeuralNetworkPropertyField("Training_speed", "");
            AddNeuralNetworkField(nnpf);
            nnpf = new NeuralNetworkPropertyField("Alpha", "");
            AddNeuralNetworkField(nnpf);
        }

        protected override void Visit(MultilayerNeuralNetwork mnn)
        {
            base.Visit(mnn);
            networkType = "Multilayer perceptron";

            var nnpf = new NeuralNetworkPropertyField("Neurons", "");
            AddNeuralNetworkField(nnpf);
        }

        private void AddNeuralNetworkField(NeuralNetworkPropertyField nnpf)
        {
            nnpf.Top = elementY;
            nnpf.Left = elementMarginX;
            watchControl.Add(nnpf);

            elementY += (nnpf.Height + elementMarginY);
        }
    }



   /* public class NeuralNetworkCreator : NeuralNetworkVisitor<INeuralNetwork>
    {
        Dictionary<string, string> fields;
        BackPropagationAlgorithm bpa;


        public NeuralNetworkCreator(Dictionary<string, string> fields)
        {
            this.fields = fields;
        }

        public void SetFields(Dictionary<string, string> fields)
        {
            this.fields = fields;
        }

        public override INeuralNetwork DynemicVisit(INeuralNetwork nn)
        {
            base.DynemicVisit(nn);

            return nn;
        }

        protected override void Visit(INeuralNetwork nn)
        {
            double trainingSpeed = Double.Parse(fields["Training_speed"]);
            double alpha = Double.Parse(fields["Alpha"]);

            bpa = new BackPropagationAlgorithm(new LeastSquareMethod(), trainingSpeed, alpha);
            bpa.Train()
        }
    }*/
}
