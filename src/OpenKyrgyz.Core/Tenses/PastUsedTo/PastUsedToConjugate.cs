using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Tenses.PastUsedTo;

public class PastUsedToConjugate
{
    public static string Conjugate(
        string verb,
        PronounEnum pronoun,
        VerbFormEnum form = VerbFormEnum.Positive)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;

        if (pronoun == PronounEnum.Алар)
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

        var ending = PastUsedToEnding.GetEnding(verb, pronoun);

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
        { VowelGroupEnum.о_ё, 'у' },
        { VowelGroupEnum.ө_ү, 'ү' },
    };
}