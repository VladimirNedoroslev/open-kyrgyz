using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PastDefinite;

namespace OpenKyrgyz.Core.Tenses.PastIndefinite;

public class PastIndefiniteTenseGenerator
{
    public static string GenerateForPronoun(string verb, PronounEnum pronoun)
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

        var ending = PastIndefiniteEnding.GetEnding(verb, pronoun);
        
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
            { PronounEnum.Алар, GenerateForPronoun(verb, PronounEnum.Алар) },
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