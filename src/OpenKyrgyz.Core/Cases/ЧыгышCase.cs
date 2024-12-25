using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

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


    public static string ToЧыгышCase(string word)
    {
        // todo: handle case for Ал
        if (string.IsNullOrEmpty(word))
            return word;
        var vowelGroup = word.GetVowelGroup();
        var lastLetter = word.GetLastLetterType();
        if (lastLetter is LetterTypeEnum.VoicelessConsonant)
            return word + VoicelessConsonantMapping[vowelGroup];

        return word + VowelOrVoicedConsonantMapping[vowelGroup];
    }
}