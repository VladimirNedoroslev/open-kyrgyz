using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.VerbForms.Participle;

public class ParticipleConjugator
{
    private static readonly Dictionary<VowelGroupEnum, string> VowelOrVoicedConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ган" },
        { VowelGroupEnum.и_е_э, "ген" },
        { VowelGroupEnum.о_ё, "гон" },
        { VowelGroupEnum.у_ю, "ган" },
        { VowelGroupEnum.ө_ү, "гөн" },
    };
    
    private static readonly Dictionary<VowelGroupEnum, string> VoicelessConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "кан" },
        { VowelGroupEnum.и_е_э, "кен" },
        { VowelGroupEnum.о_ё, "кон" },
        { VowelGroupEnum.у_ю, "кан" },
        { VowelGroupEnum.ө_ү, "көн" },
    };
    

    public static string GetPastParticiple(string verb)
    {
        var lastLetterType = verb.GetLastLetterType();
        var vowelGroup = verb.GetVowelGroup();
        if (lastLetterType is LetterTypeEnum.Vowel or LetterTypeEnum.VoicedConsonant)
            return verb + VowelOrVoicedConsonantMapping[vowelGroup];
        
        return verb + VoicelessConsonantMapping[vowelGroup];
    }
}