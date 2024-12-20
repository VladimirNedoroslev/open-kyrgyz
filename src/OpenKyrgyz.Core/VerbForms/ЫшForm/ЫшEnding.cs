using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.VerbForms.ЫшForm;

public class ЫшEnding
{
    private static readonly Dictionary<VowelGroupEnum, string> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ыш" },
        { VowelGroupEnum.и_е_э, "иш" },
        { VowelGroupEnum.о_ё, "уш" },
        { VowelGroupEnum.у_ю, "уш" },
        { VowelGroupEnum.ө_ү, "үш" },
    };

    public const char VowelEnding = 'ш';

    public static string GetЫшEnding(string verb)
    {
        var lastLetterType = verb.GetLastLetterType();
        if (lastLetterType is LetterTypeEnum.Vowel)
            return verb + VowelEnding;
        var vowelGroup = verb.GetVowelGroup();
        return verb + Mapping[vowelGroup];
    }
}