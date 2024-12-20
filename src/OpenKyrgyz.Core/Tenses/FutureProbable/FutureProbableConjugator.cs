using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

namespace OpenKyrgyz.Core.Tenses.FutureProbable;

public class FutureProbableConjugator
{
    public static string Conjugate(
        string verb,
        PronounEnum pronoun,
        VerbFormEnum formEnum = VerbFormEnum.Positive)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;

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

        var ending = FutureProbableEnding.GetEndingForPronoun(verb, pronoun);

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