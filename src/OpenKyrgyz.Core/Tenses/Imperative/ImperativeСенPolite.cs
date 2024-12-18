using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Tenses.Imperative;

public class ImperativeСенPolite
{
    private static readonly Dictionary<VowelGroupEnum, string> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, "чы" },
        { VowelGroupEnum.и_е_э, "чи" },
        { VowelGroupEnum.у_ю, "чу" },
        { VowelGroupEnum.о_ё, "чу" },
        { VowelGroupEnum.ө_ү, "чү" },
    };

    public static string Generate(string verb)
    {
        var vowelGroup = verb.GetVowelGroup();
        return Mapping[vowelGroup];
    }
}