using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Tenses.PastDefinite;

public class PastDefiniteTenseGenerator
{
    public static string GenerateForPronoun(string verb, PronounEnum pronoun)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;

        if (pronoun == PronounEnum.Алар)
            return GenerateForAlar(verb);

        var ending = PastDefiniteEnding.GetEnding(verb, pronoun);
        
        return $"{verb}{ending}";
    }

    private static string GenerateForAlar(string verb)
    {
        var lastLetterType = verb.GetLastLetterType();
        var ending = PastDefiniteEnding.GetEnding(verb, PronounEnum.Алар);
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

    public static Dictionary<PronounEnum, string> GenerateForAllPronouns(string verb)
    {
        return new Dictionary<PronounEnum, string>
        {
            { PronounEnum.Мен, GenerateForPronoun(verb, PronounEnum.Мен) },
            { PronounEnum.Сен, GenerateForPronoun(verb, PronounEnum.Сен) },
            { PronounEnum.Сиз, GenerateForPronoun(verb, PronounEnum.Сиз) },
            { PronounEnum.Ал, GenerateForPronoun(verb, PronounEnum.Ал) },
            { PronounEnum.Биз, GenerateForPronoun(verb, PronounEnum.Биз) },
            { PronounEnum.Силер, GenerateForPronoun(verb, PronounEnum.Силер) },
            { PronounEnum.Сиздер, GenerateForPronoun(verb, PronounEnum.Сиздер) },
            { PronounEnum.Алар, GenerateForAlar(verb) },
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