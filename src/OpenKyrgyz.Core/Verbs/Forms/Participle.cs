using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Negative;
using OpenKyrgyz.Core.Verbs.Moods;

namespace OpenKyrgyz.Core.Verbs.Forms;

public static class Participle
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


    public static string Get(string verb, VerbFormEnum form)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        if (form is VerbFormEnum.Interrogative or VerbFormEnum.NegativeAndInterrogative)
            return "-";

        if (form == VerbFormEnum.Negative)
            verb += verb.GetNegativeAffix();

        var lastLetterType = verb.GetLastLetterType();
        var vowelGroup = verb.GetVowelGroup();
        if (lastLetterType is LetterTypeEnum.Vowel or LetterTypeEnum.VoicedConsonant)
            return verb + VowelOrVoicedConsonantMapping[vowelGroup];

        return verb + VoicelessConsonantMapping[vowelGroup];
    }

    public static string GetInPassiveMood(string verb, VerbFormEnum form)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        if (form is VerbFormEnum.Interrogative or VerbFormEnum.NegativeAndInterrogative)
            return "-";
        return Get(PassiveMood.Get(verb), form);
    }
}