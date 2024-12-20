using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Interrogative;
using OpenKyrgyz.Core.Negative;

namespace OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

public class PresentAndFutureSimpleConjugator
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
            if (pronoun == PronounEnum.Ал)
            {
                // remove last letter
                verb = verb[..^1];
            }

            var interrogativeAffix = verb.GetInterrogativeAffix();
            verb += interrogativeAffix.Value;
        }

        return verb;
    }

    private static string ConjugateForPositive(string verb, PronounEnum pronoun)
    {
        // TODO: check other edge cases with alar
        if (verb == "бол" && pronoun == PronounEnum.Алар)
        {
            return "болушат";
        }

        var vowelGroup = verb.GetVowelGroup();
        var lastLetterType = verb.GetLastLetterType();
        char? linkingLetter = null;
        if (pronoun == PronounEnum.Алар)
        {
            if (lastLetterType is not LetterTypeEnum.Vowel)
                linkingLetter = LinkingLetterForAlarCase[vowelGroup];
        }
        else
        {
            linkingLetter = АеөойLinkingLetter.GetLinkingChar(verb);
        }

        verb = verb.HarmonizeVerbEndingIfNecessary();
        if (linkingLetter.HasValue)
            verb += linkingLetter;

        var ending = PresentAndFutureSimpleEnding.GetEndingForPronoun(verb, pronoun);

        return $"{verb}{ending}";
    }


    private static readonly Dictionary<VowelGroupEnum, char> LinkingLetterForAlarCase = new()
    {
        { VowelGroupEnum.а_я_ы, 'ы' },
        { VowelGroupEnum.у_ю, 'у' },
        { VowelGroupEnum.и_е_э, 'и' },
        { VowelGroupEnum.о_ё, 'о' },
        { VowelGroupEnum.ө_ү, 'ү' },
    };
}