using System;
using System.Collections.Generic;
using Vocabulary.Entity.Concrete;

namespace Vocabulary.Business.Abstract
{
    public interface IWordService
    {
        List<Word> LoadWord();
        void Add(Word word);
        void Delete(Word word);
        void Update(Word word);
        List<Word> GetWordInformations1();
        List<Word> GetWordInformations2();
        List<Word> GetWordInformations3();
        List<Word> GetWordInformations4();
        List<Word> GetWordsByLearning();
        bool GetTime1();
        bool GetTime2();
        bool GetTime3();
        bool GetTime4();
        bool WordQuery(string txtEnglishWord);
        bool GetValue1(string turkishWordAnswer);
        bool GetValue2(string turkishWordAnswer);
        bool GetValue3(string turkishWordAnswer);
        bool GetValue4(string turkishWordAnswer);
    }
}
