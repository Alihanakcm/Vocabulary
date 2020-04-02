using FluentValidation;
using Vocabulary.Entity.Concrete;

namespace Vocabulary.Business.ValidationRules.FluentValidation
{
    public class WordValidator:AbstractValidator<Word>
    {
        public WordValidator()
        {
            RuleFor(p => p.EnglishWord).NotEmpty().WithMessage("Lütfen geçerli alanları boş bırakmayınız!");
            RuleFor(p => p.TurkishWord).NotEmpty().WithMessage("Lütfen geçerli alanları boş bırakmayınız!");
            RuleFor(p => p.WordType).NotEmpty().WithMessage("Lütfen geçerli alanları boş bırakmayınız!");
            RuleFor(p => p.Sentence).NotEmpty().WithMessage("Lütfen geçerli alanları boş bırakmayınız!");
        }

    }
}
