using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Interrogative;
using OpenKyrgyz.Core.VerbForms.Cooperative;

namespace OpenKyrgyz.Core.Tenses.FutureProbable;

public class FutureProbableConjugator
{
    public static string Conjugate(
        string verb,
        PronounEnum pronoun,
        VerbFormEnum formEnum)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        
        if (pronoun == PronounEnum.Алар)
        {
            verb = ЫшEnding.GetЫшEnding(verb);
        }

        if (formEnum is VerbFormEnum.Negative)
            return verb + FutureProbableEnding.GetEndingForPronounNegative(verb, pronoun);

        if (formEnum is VerbFormEnum.NegativeAndInterrogative)
        {
            var negative = verb + FutureProbableEnding.GetEndingForPronounNegative(verb, pronoun);
            var interrogativeAffix = negative.GetInterrogativeAffix();
            return negative + interrogativeAffix;
        }

        var positive = ConjugateForPositive(verb, pronoun);
        if (formEnum is VerbFormEnum.Interrogative)
        {
            var interrogativeAffix = positive.GetInterrogativeAffix();
            return positive + interrogativeAffix;
        }

        return positive;
    }

    private static string ConjugateForPositive(string verb, PronounEnum pronoun)
    {
        verb = verb.HarmonizeVerbEndingIfNecessary();
        
        var ending = FutureProbableEnding.GetEndingForPronounPositive(verb, pronoun);

        return $"{verb}{ending}";
    }
}