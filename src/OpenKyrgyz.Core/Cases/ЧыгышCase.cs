using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Possessive;

namespace OpenKyrgyz.Core.Cases;

public static class ЧыгышCase
{
    public static readonly Dictionary<VowelGroupEnum, string> VowelOrVoicedConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "дан" },
        { VowelGroupEnum.и_е_э, "ден" },
        { VowelGroupEnum.о_ё, "дон" },
        { VowelGroupEnum.у_ю, "дан" },
        { VowelGroupEnum.ө_ү, "дөн" },
    };

    public static readonly Dictionary<VowelGroupEnum, string> VoicelessConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "тан" },
        { VowelGroupEnum.и_е_э, "тен" },
        { VowelGroupEnum.о_ё, "тон" },
        { VowelGroupEnum.у_ю, "тан" },
        { VowelGroupEnum.ө_ү, "төн" },
    };

    public static readonly Dictionary<VowelGroupEnum, string> АнынАлардынCaseMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "нан" },
        { VowelGroupEnum.и_е_э, "нен" },
        { VowelGroupEnum.о_ё, "" }, // not possible with Ал possessive, since it always ends with ы и у ү 
        { VowelGroupEnum.у_ю, "нан" },
        { VowelGroupEnum.ө_ү, "нөн" },
    };


    public static string ToЧыгышCase(string word, PronounEnum? withPossessive = null)
    {
        if (string.IsNullOrEmpty(word))
            return word;


        if (withPossessive.HasValue)
            word = word.ToPossessive(withPossessive.Value);

        var vowelGroup = word.GetVowelGroup();
        if (withPossessive is PronounEnum.Ал or PronounEnum.Алар)
        {
            return word + АнынАлардынCaseMapping[vowelGroup];
        }

        var lastLetter = word.GetLastLetterType();
        if (lastLetter is LetterTypeEnum.VoicelessConsonant)
            return word + VoicelessConsonantMapping[vowelGroup];

        return word + VowelOrVoicedConsonantMapping[vowelGroup];
    }
}