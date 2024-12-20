using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Interrogative;
using OpenKyrgyz.Core.Negative;

namespace OpenKyrgyz.Core.Tenses.PastSudden;

public class PastSuddenConjugator
{
    public static string Conjugate(
        string verb,
        PronounEnum pronoun,
        VerbFormEnum form)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;


        if (form is VerbFormEnum.Negative or VerbFormEnum.NegativeAndInterrogative)
        {
            var negativeAffix = verb.GetNegativeAffix();
            verb += negativeAffix.Value;
        }

        verb = ConjugateForPositive(verb, pronoun);

        if (form is VerbFormEnum.Interrogative or VerbFormEnum.NegativeAndInterrogative)
        {
            var interrogativeAffix = verb.GetInterrogativeAffix();
            verb += interrogativeAffix.Value;
        }

        return verb;
    }

    private static string ConjugateForPositive(string verb, PronounEnum pronoun)
    {
        var lastLetterType = verb.GetLastLetterType();
        if (lastLetterType is not LetterTypeEnum.Vowel)
        {
            var vowelGroup = verb.GetVowelGroup();
            var linkingLetter = LinkingLetterForAlarCase[vowelGroup];
            verb = verb.HarmonizeVerbEndingIfNecessary();
            verb += linkingLetter;
        }

        var ending = PastSuddenEnding.GetEnding(verb, pronoun);

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