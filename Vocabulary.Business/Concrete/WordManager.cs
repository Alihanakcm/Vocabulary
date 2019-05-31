using System;
using System.Collections.Generic;
using System.Linq;
using Vocabulary.Business.Abstract;
using Vocabulary.Business.Utilities;
using Vocabulary.Business.ValidationRules.FluentValidation;
using Vocabulary.DataAccess.Abstract;
using Vocabulary.Entity.Concrete;

namespace Vocabulary.Business.Concrete
{
    public class WordManager:IWordService
    {
        private IWordDal _wordDal;
        public WordManager(IWordDal wordDal)
        {
            _wordDal = wordDal;
        }

        public List<Word> LoadWord()
        {
            return _wordDal.GetWords();
        }

        public void Add(Word word)
        {
            ValidationTool.Validate(new WordValidator(),word);
            _wordDal.Add(word);
        }

        public void Delete(Word word)
        {
            try
            {
                _wordDal.Delete(word);
            }
            catch
            {
              throw new Exception();
            }
        }

        public void Update(Word word)
        {
            ValidationTool.Validate(new WordValidator(), word);
            _wordDal.Update(word);
        }

        public bool GetTime1()
        {
            return _wordDal.GetTime(p=>p.Exam1Time<=DateTime.Now && p.Learning==true);
        }

        public List<Word> GetWordInformations1()
        {
            return _wordDal.Get(p => p.Exam1Time <= DateTime.Now && p.Learning == true);

        }

        public List<Word> GetWordInformations2()
        {
            return _wordDal.Get(p => p.Exam2Time <= DateTime.Now && p.Learning == true);
        }

        public List<Word> GetWordInformations3()
        {
            return _wordDal.Get(p => p.Exam3Time <= DateTime.Now && p.Learning == true);
        }

        public List<Word> GetWordInformations4()
        {
            return _wordDal.Get(p => p.Exam4Time <= DateTime.Now && p.Learning == true);
        }
        public List<Word> GetWordsByLearning()
        {
            return _wordDal.Get(p => p.Learning == false);
        }

        public bool GetTime2()
        {
            return _wordDal.GetTime(p => p.Exam2Time <= DateTime.Now && p.Learning == true);
        }

        public bool GetTime3()
        {
            return _wordDal.GetTime(p => p.Exam3Time <= DateTime.Now && p.Learning == true);
        }

        public bool GetTime4()
        {
            return _wordDal.GetTime(p => p.Exam4Time <= DateTime.Now && p.Learning == true);
        }

        public bool WordQuery(string txtEnglishWord)
        {
            return _wordDal.QueryWord(p => p.EnglishWord == txtEnglishWord);
        }

        public bool GetValue1(string turkishWordAnswer)
        {
            return _wordDal.GetValue(p => p.TurkishWord.ToLower() == turkishWordAnswer.ToLower() && p.Exam1Time<=DateTime.Now && p.Learning==true);
        }
        public bool GetValue2(string turkishWordAnswer)
        {
            return _wordDal.GetValue(p => p.TurkishWord.ToLower() == turkishWordAnswer.ToLower() && p.Exam2Time <= DateTime.Now && p.Learning == true);
        }
        public bool GetValue3(string turkishWordAnswer)
        {
            return _wordDal.GetValue(p => p.TurkishWord.ToLower() == turkishWordAnswer.ToLower() && p.Exam3Time <= DateTime.Now && p.Learning == true);
        }
        public bool GetValue4(string turkishWordAnswer)
        {
            return _wordDal.GetValue(p => p.TurkishWord.ToLower() == turkishWordAnswer.ToLower() && p.Exam4Time <= DateTime.Now && p.Learning == true);
        }
    }
}
