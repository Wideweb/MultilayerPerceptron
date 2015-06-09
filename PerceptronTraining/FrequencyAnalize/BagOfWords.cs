using EnglishStemmer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PerceptronTraining
{
    [Serializable]
    public class BagOfWords : IFrequencyAnalyzer
    {
        public List<string> Classes { get; private set; }
        public List<string> Vocabulary { get; private set; }
        public List<FrequencyDocument> Documents { get; private set; }

        private DirectoryInfo lastFolder;

        public List<FrequencyDocument> Transform(string Folder)
        {
            DirectoryInfo diF = new DirectoryInfo(Folder);
            if(lastFolder != null && diF.FullName == lastFolder.FullName && diF.LastWriteTime == lastFolder.LastWriteTime)
                return Documents;

            lastFolder = diF;

            Classes = new List<string>();
            Vocabulary = new List<string>();
            Documents = new List<FrequencyDocument>();
            string[] folders = Directory.GetDirectories(Folder);

            foreach (var folder in folders)
            {
                DirectoryInfo di = new DirectoryInfo(folder);
                Documents.AddRange(TransformClassificatedDocuments(di.FullName, di.Name));
                IncClasses(di.Name);
            }
            Vocabulary = Vocabulary.OrderBy(x => x).ToList();
            Classes = Classes.OrderBy(x => x).ToList();
            return Documents;
        }

        private List<FrequencyDocument> TransformClassificatedDocuments(string folder, string classification)
        {
            string[] files = Directory.GetFiles(folder);
            var docs = new List<FrequencyDocument>();
            string text;

            foreach (var file in files)
            {
                text = File.ReadAllText(file);
                FrequencyDocument doc = TransformText(text);
                doc.Classification = classification;
                IncVocabulary(doc);
                docs.Add(doc);
            }

            return docs;
        }

        public FrequencyDocument TransformText(string text)
        {
            string[] tokens = Tokenize(text);

            var document = new FrequencyDocument
            {
                Classification = "-",
                Tokens = new Dictionary<string,double>()
            };

            foreach (var token in tokens)
            {
                if (token == String.Empty) continue;

                string stripped = Regex.Replace(token, "[^a-zA-Z0-9]", "");

                if (!StopWords.stopWordsList.Contains(stripped.ToLower()))
                {
                    var english = new EnglishWord(stripped);
                    string stemedToken = english.Stem;

                    if (document.Tokens.Keys.Contains(token))
                        document.Tokens[token]++;
                    else
                        document.Tokens.Add(token, 1);
                }
            }

            return document;
        }


        private FrequencyDocument NormalizeDocument(FrequencyDocument doc)
        {
            double length = 0;
            foreach(var token in doc.Tokens)
            {
                length += token.Value * token.Value;
            }
            length = Math.Sqrt(length);

            string[] keys = doc.Tokens.Keys.ToArray();

            for (var i = 0; i < keys.Length; i++)
            {
                doc.Tokens[keys[i]] /= length;
            }
            return doc;
        }

        private string[] Tokenize(string text)
        {
            text = Regex.Replace(text, "<[^<>]+>", "");
            text = Regex.Replace(text, "[0-9]+", "number");
            text = Regex.Replace(text, @"(http|https)://[^\s]*", "httpaddr");
            text = Regex.Replace(text, @"[^\s]+@[^\s]+", "emailaddr");
            text = Regex.Replace(text, "[$]+", "dollar");
            text = Regex.Replace(text, @"@[^\s]+", "username");
            text = Regex.Replace(text, @"[\s]+", " ");

            return text.Split(" @$/#.-:&*+=[]?!(){},''\">_<;%\\".ToCharArray());
        }

        private void IncClasses(string classification)
        {
            if (!Classes.Contains(classification))
                Classes.Add(classification);
        }

        private void IncVocabulary(FrequencyDocument doc)
        {
            foreach(var token in doc.Tokens.Keys)
            {
                if (!Vocabulary.Contains(token))
                    Vocabulary.Add(token);
            }
        }
    }
}
