using OpenKyrgyz.Core.Common;
using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Interrogative;
using OpenKyrgyz.Core.Negative;

namespace OpenKyrgyz.Core.Moods;

public static class OptativeMood
{
    public static readonly Dictionary<VowelGroupEnum, string> МенMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "йын" },
        { VowelGroupEnum.и_е_э, "йин" },
        { VowelGroupEnum.о_ё, "юн" },
        { VowelGroupEnum.у_ю, "йын" },
        { VowelGroupEnum.ө_ү, "йүн" },
    };

    public static readonly Dictionary<VowelGroupEnum, string> БизConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "алы" },
        { VowelGroupEnum.и_е_э, "ели" },
        { VowelGroupEnum.о_ё, "олу" },
        { VowelGroupEnum.у_ю, "алы" },
        { VowelGroupEnum.ө_ү, "өлү" },
    };
    
    public static readonly Dictionary<VowelGroupEnum, string> БизVowelMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "йлы" },
        { VowelGroupEnum.и_е_э, "йли" },
        { VowelGroupEnum.о_ё, "йлу" },
        { VowelGroupEnum.у_ю, "йлы" },
        { VowelGroupEnum.ө_ү, "йлү" },
    };

    public static string GetForМен(string verb, VerbFormEnum form)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        if (form is VerbFormEnum.Negative or VerbFormEnum.NegativeAndInterrogative)
            verb += verb.GetNegativeAffix();

        verb = verb.HarmonizeVerbEndingIfNecessary();
        verb = GetForМенPositive(verb);

        if (form is VerbFormEnum.Interrogative or VerbFormEnum.NegativeAndInterrogative)
            verb += verb.GetInterrogativeAffix();

        return УаойReplacer.Replace(verb);
    }

    public static readonly Dictionary<string, string> БизExceptions = new()
    {
        { "жаса" , "жасайлы" }
    };
    
    public static string GetForБиз(string verb, VerbFormEnum form)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        if (form is VerbFormEnum.Negative or VerbFormEnum.NegativeAndInterrogative)
            verb += verb.GetNegativeAffix();

        verb = verb.HarmonizeVerbEndingIfNecessary();
        verb = GetForБизPositive(verb);

        if (form is VerbFormEnum.Interrogative or VerbFormEnum.NegativeAndInterrogative)
            verb += verb.GetInterrogativeAffix();

        return УаойReplacer.Replace(verb);
    }

    private static string GetForМенPositive(string verb)
    {
        var lastLetterType = verb.GetLastLetterType();
        var vowelGroup = verb.GetVowelGroup();
        if (lastLetterType is LetterTypeEnum.VoicedConsonant or LetterTypeEnum.VoicelessConsonant)
            verb += АеөойLinkingLetter.GetLinkingChar(verb);

        return verb + МенMapping[vowelGroup];
    }
    
    private static string GetForБизPositive(string verb)
    {
        var lastLetterType = verb.GetLastLetterType();
        var vowelGroup = verb.GetVowelGroup();
        if (lastLetterType is LetterTypeEnum.VoicedConsonant or LetterTypeEnum.VoicelessConsonant)
            return verb + БизConsonantMapping[vowelGroup];

        return verb + БизVowelMapping[vowelGroup];
    }
}