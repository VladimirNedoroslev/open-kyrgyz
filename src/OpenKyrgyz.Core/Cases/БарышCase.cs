using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Cases;

public static class БарышCase
{
    public static readonly Dictionary<VowelGroupEnum, string> VowelOrVoicedConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "га" },
        { VowelGroupEnum.и_е_э, "ге" },
        { VowelGroupEnum.о_ё, "го" },
        { VowelGroupEnum.у_ю, "га" },
        { VowelGroupEnum.ө_ү, "гө" },
    };
    
    public static readonly Dictionary<VowelGroupEnum, string> VoicelessConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ка" },
        { VowelGroupEnum.и_е_э, "ке" },
        { VowelGroupEnum.о_ё, "ко" },
        { VowelGroupEnum.у_ю, "ка" },
        { VowelGroupEnum.ө_ү, "кө" },
    };
    

    public static string ToБарышCase(string word)
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