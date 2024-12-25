using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Forms.TimeRelated;

public class WhileForm
{
    public static readonly Dictionary<VowelGroupEnum, string> VowelOrVoicedConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ганча" },
        { VowelGroupEnum.и_е_э, "генче" },
        { VowelGroupEnum.о_ё, "гончо" },
        { VowelGroupEnum.у_ю, "ганча" },
        { VowelGroupEnum.ө_ү, "гөнчө" },
    };

    public static readonly Dictionary<VowelGroupEnum, string> VoicelessConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "канча" },
        { VowelGroupEnum.и_е_э, "кенче" },
        { VowelGroupEnum.о_ё, "кончо" },
        { VowelGroupEnum.у_ю, "канча" },
        { VowelGroupEnum.ө_ү, "көнчө" },
    };

    public static string Get(string verb)
    {
        if (string.IsNullOrEmpty(verb))
            return verb;

        var vowelGroup = verb.GetVowelGroup();
        var lastLetter = verb.GetLastLetterType();

        if (lastLetter is LetterTypeEnum.VoicelessConsonant)
            return verb + VoicelessConsonantMapping[vowelGroup];

        return verb + VowelOrVoicedConsonantMapping[vowelGroup];
    }
}