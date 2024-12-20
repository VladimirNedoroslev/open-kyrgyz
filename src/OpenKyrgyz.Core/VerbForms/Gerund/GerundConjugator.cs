using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.VerbForms.Gerund;

public static class GerundConjugator
{
    public static readonly Dictionary<VowelGroupEnum, string> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ып" },
        { VowelGroupEnum.и_е_э, "ип" },
        { VowelGroupEnum.о_ё, "уп" },
        { VowelGroupEnum.у_ю, "уп" },
        { VowelGroupEnum.ө_ү, "үп" },
    };

    public const char VowelEnding = 'п';

    public static string GetGerund(string verb)
    {
        var lastLetterType = verb.GetLastLetterType();
        if (lastLetterType is LetterTypeEnum.Vowel)
            return verb + VowelEnding;
        var vowelGroup = verb.GetVowelGroup();
        return verb + Mapping[vowelGroup];
    }
}