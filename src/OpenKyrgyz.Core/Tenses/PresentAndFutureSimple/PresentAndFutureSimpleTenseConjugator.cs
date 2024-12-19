using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

public class PresentAndFutureSimpleTenseConjugator
{
    public static string Conjugate(
        string verb,
        PronounEnum pronoun,
        VerbFormEnum form = VerbFormEnum.Positive)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;

        // TODO: check other edge cases with alar
        if (verb == "бол" && pronoun == PronounEnum.Алар)
            return "болушат";

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

    private static string GenerateForAlar(string verb)
    {
        var lastLetterType = verb.GetLastLetterType();
        var ending = PresentAndFutureSimpleEnding.GetEndingForPronoun(verb, PronounEnum.Алар);
        if (lastLetterType is LetterTypeEnum.Vowel)
        {
            return $"{verb}{ending}";
        }

        var vowelGroup = verb.GetVowelGroup();
        var linkingLetter = LinkingLetterForAlarCase[vowelGroup];
        verb = verb.HarmonizeVerbEndingIfNecessary();

        verb += linkingLetter;

        return $"{verb}{ending}";
    }

    public static SortedDictionary<PronounEnum, string> GenerateForAllPronouns(string verb)
    {
        return new SortedDictionary<PronounEnum, string>
        {
            { PronounEnum.Мен, Conjugate(verb, PronounEnum.Мен) },
            { PronounEnum.Сен, Conjugate(verb, PronounEnum.Сен) },
            { PronounEnum.Сиз, Conjugate(verb, PronounEnum.Сиз) },
            { PronounEnum.Ал, Conjugate(verb, PronounEnum.Ал) },
            { PronounEnum.Биз, Conjugate(verb, PronounEnum.Биз) },
            { PronounEnum.Силер, Conjugate(verb, PronounEnum.Силер) },
            { PronounEnum.Сиздер, Conjugate(verb, PronounEnum.Сиздер) },
            { PronounEnum.Алар, Conjugate(verb, PronounEnum.Алар) },
        };
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