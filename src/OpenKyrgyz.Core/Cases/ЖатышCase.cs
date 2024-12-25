using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Cases;

public static class ЖатышCase
{
    public static readonly Dictionary<VowelGroupEnum, string> VowelOrVoicedConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "да" },
        { VowelGroupEnum.и_е_э, "де" },
        { VowelGroupEnum.о_ё, "до" },
        { VowelGroupEnum.у_ю, "да" },
        { VowelGroupEnum.ө_ү, "дө" },
    };

    public static readonly Dictionary<VowelGroupEnum, string> VoicelessConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "та" },
        { VowelGroupEnum.и_е_э, "те" },
        { VowelGroupEnum.о_ё, "то" },
        { VowelGroupEnum.у_ю, "та" },
        { VowelGroupEnum.ө_ү, "тө" },
    };

    private const char АлCaseLinkinLetter = 'н';

    public static string ToЖатышCase(string word)
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