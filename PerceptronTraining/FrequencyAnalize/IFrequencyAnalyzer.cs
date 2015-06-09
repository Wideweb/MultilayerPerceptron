using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronTraining
{
    [Serializable]
    public class FrequencyDocument
    {
        public Dictionary<string, double> Tokens { get; set; }
        public string Classification { get; set; }
    }

    public interface IFrequencyAnalyzer
    {
        List<string> Classes { get; }
        List<string> Vocabulary { get;}
        List<FrequencyDocument> Documents { get;}

        List<FrequencyDocument> Transform(string Folder);
        FrequencyDocument TransformText(string text);
    }
}
