using EntityDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MultilayerPerceptron;

namespace UITraining
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TrainNetwork()
        {
            string path = @"C:\Users\Alexander\Documents\Visual Studio 2013\Projects\EntityDb\EntityDb\bin\Debug\115Cat\training";
            
            DocumentRepository dr = new DocumentRepository();
            List<Word> vocabulary = dr.GetVocabulary().OrderBy(x => x.Id).ToList();

            NeuralNetworkBuilder nnb = new NeuralNetworkBuilder(vocabulary.Count, 2, 3);
            MultilayerNeuralNetwork mnn = nnb.Build();

            ITrainingAlgorithm tr = new BackPropagationAlgorithm(new LeastSquareMethod());
            //tr.Train(mnn, )

            int docsCount = dr.DocumentsCount();
            int takenDocuments = 0;
            int bufferSize = 2000;

            while(takenDocuments < docsCount)
            {
                List<Document> docs = dr.TakeDocuments(bufferSize, takenDocuments);
                takenDocuments += docs.Count;

                foreach(var doc in docs)
                {
                    nw.Study(doc.Tokens, doc.Classification);
                }
            }
        }
    }
}
