using System;
using Vocabulary.Entity.Abstract;

namespace Vocabulary.Entity.Concrete
{
    public class Word:IEntity
    {
        public int id { get; set; }
        public string EnglishWord { get; set; }
        public string TurkishWord { get; set; }
        public string WordType { get; set; }
        public string Sentence { get; set; }
        public int LearnState { get; set; }
        public DateTime TimeToLearn { get; set; }
        public DateTime Exam1Time { get; set; }
        public DateTime Exam2Time { get; set; }
        public DateTime Exam3Time { get; set; }
        public DateTime Exam4Time { get; set; }
        public bool Learning { get; set; }
    }
}
