using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Interrogative;

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
        if (pronoun is PronounEnum.Алар)
        {
            var lastLetterType = verb.GetLastLetterType();
            if (lastLetterType is not LetterTypeEnum.Vowel)
            {
                var vowelGroup = verb.GetVowelGroup();
                var linkingLetter = LinkingLetterForAlarCase[vowelGroup];
                verb = verb.HarmonizeVerbEndingIfNecessary();
                verb += linkingLetter;
            }
        }
        else
        {
            verb = verb.HarmonizeVerbEndingIfNecessary();
        }

        var ending = FutureProbableEnding.GetEndingForPronounPositive(verb, pronoun);

        return $"{verb}{ending}";
    }

    private static readonly Dictionary<VowelGroupEnum, char> LinkingLetterForAlarCase = new()
    {
        { VowelGroupEnum.а_я_ы, 'ы' },
        { VowelGroupEnum.у_ю, 'у' },
        { VowelGroupEnum.и_е_э, 'и' },
        { VowelGroupEnum.о_ё, 'у' },
        { VowelGroupEnum.ө_ү, 'ү' },
    };
}