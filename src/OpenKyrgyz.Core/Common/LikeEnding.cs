using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Common;

public class LikeEnding
{
    public static readonly Dictionary<VowelGroupEnum, string> VowelOrVoicedConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "дай" },
        { VowelGroupEnum.и_е_э, "дей" },
        { VowelGroupEnum.о_ё, "дой" },
        { VowelGroupEnum.у_ю, "дай" },
        { VowelGroupEnum.ө_ү, "дөй" },
    };


    public static readonly Dictionary<VowelGroupEnum, string> VoicelessConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "тай" },
        { VowelGroupEnum.и_е_э, "тей" },
        { VowelGroupEnum.о_ё, "той" },
        { VowelGroupEnum.у_ю, "тай" },
        { VowelGroupEnum.ө_ү, "төй" },
    };

    public static string Get(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
            return word;
        var vowelGroup = word.GetVowelGroup();
        var lastLetterType = word.GetLastLetterType();
        if (lastLetterType is LetterTypeEnum.VoicelessConsonant)
            return word + VoicelessConsonantMapping[vowelGroup];

        return word + VowelOrVoicedConsonantMapping[vowelGroup];
    }
}