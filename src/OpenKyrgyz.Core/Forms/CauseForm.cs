using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Negative;

namespace OpenKyrgyz.Core.Forms;

public class CauseForm
{
    public static readonly Dictionary<VowelGroupEnum, string> VowelOrVoicedConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "гандыктан" },
        { VowelGroupEnum.и_е_э, "гендиктен" },
        { VowelGroupEnum.о_ё, "гондуктан" },
        { VowelGroupEnum.у_ю, "гандыктан" },
        { VowelGroupEnum.ө_ү, "гөндүктөн" },
    };

    public static readonly Dictionary<VowelGroupEnum, string> VoicelessConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "кандыктан" },
        { VowelGroupEnum.и_е_э, "кендиктен" },
        { VowelGroupEnum.о_ё, "кондуктан" },
        { VowelGroupEnum.у_ю, "кандыктан" },
        { VowelGroupEnum.ө_ү, "көндүктөн" },
    };
    
    public static string Get(string verb, VerbFormEnum form)
    {
        if (string.IsNullOrEmpty(verb))
            return verb;
        
        if (form is VerbFormEnum.Interrogative or VerbFormEnum.NegativeAndInterrogative)
            return "-";

        if (form == VerbFormEnum.Negative)
            verb += verb.GetNegativeAffix();

        var vowelGroup = verb.GetVowelGroup();
        var lastLetter = verb.GetLastLetterType();

        if (lastLetter is LetterTypeEnum.VoicelessConsonant)
            return verb + VoicelessConsonantMapping[vowelGroup];

        return verb + VowelOrVoicedConsonantMapping[vowelGroup];
    }
}