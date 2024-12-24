using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Forms;

public class PassiveMood
{
    private static readonly Dictionary<VowelGroupEnum, string> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ыл" },
        { VowelGroupEnum.и_е_э, "ил" },
        { VowelGroupEnum.о_ё, "ул" },
        { VowelGroupEnum.у_ю, "ул" },
        { VowelGroupEnum.ө_ү, "үл" },
    };

    public const char VowelEnding = 'л';

    public static string Get(string verb)
    {
        var lastLetterType = verb.GetLastLetterType();
        if (lastLetterType is LetterTypeEnum.Vowel)
            return verb + VowelEnding;
        var vowelGroup = verb.GetVowelGroup();
        verb = verb.HarmonizeVerbEndingIfNecessary();
        return verb + Mapping[vowelGroup];
    }
}