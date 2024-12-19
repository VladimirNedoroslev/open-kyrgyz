using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.WebApp.ViewModels;

public class VerbConjugatedByPronounDto
{
    public PronounEnum Pronoun { get; set; }
    public string Positive { get; set; }
    public string Negative { get; set; }
    public string Interrogative { get; set; }
    public string NegativeInterrogative { get; set; }

    public static List<VerbConjugatedByPronounDto> MapToTableView(VerbConjugatedByAllForms verb)
    {
        var positive = verb.Positive;
        var negative = verb.Negative;
        var interrogative = verb.Interrogative;
        var negativeInterrogative = verb.NegativeInterrogative;
        var result = new List<VerbConjugatedByPronounDto>()
        {
            new()
            {
                Pronoun = PronounEnum.Мен,
                Positive = positive.Мен,
                Negative = negative.Мен,
                Interrogative = interrogative.Мен,
                NegativeInterrogative = negativeInterrogative.Мен,
            },
            new()
            {
                Pronoun = PronounEnum.Сен,
                Positive = positive.Сен,
                Negative = negative.Сен,
                Interrogative = interrogative.Сен,
                NegativeInterrogative = negativeInterrogative.Сен,
            },
            new()
            {
                Pronoun = PronounEnum.Сиз,
                Positive = positive.Сиз,
                Negative = negative.Сиз,
                Interrogative = interrogative.Сиз,
                NegativeInterrogative = negativeInterrogative.Сиз,
            },
            new()
            {
                Pronoun = PronounEnum.Ал,
                Positive = positive.Ал,
                Negative = negative.Ал,
                Interrogative = interrogative.Ал,
                NegativeInterrogative = negativeInterrogative.Ал,
            },
            new()
            {
                Pronoun = PronounEnum.Биз,
                Positive = positive.Биз,
                Negative = negative.Биз,
                Interrogative = interrogative.Биз,
                NegativeInterrogative = negativeInterrogative.Биз,
            },
            new()
            {
                Pronoun = PronounEnum.Силер,
                Positive = positive.Силер,
                Negative = negative.Силер,
                Interrogative = interrogative.Силер,
                NegativeInterrogative = negativeInterrogative.Силер,
            },
            new()
            {
                Pronoun = PronounEnum.Сиздер,
                Positive = positive.Сиздер,
                Negative = negative.Сиздер,
                Interrogative = interrogative.Сиздер,
                NegativeInterrogative = negativeInterrogative.Сиздер,
            },
            new()
            {
                Pronoun = PronounEnum.Алар,
                Positive = positive.Алар,
                Negative = negative.Алар,
                Interrogative = interrogative.Алар,
                NegativeInterrogative = negativeInterrogative.Алар,
            },
        };
        return result;
    }
}