using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Tenses.Imperative;

public class ImperativeАл
{
    private static readonly Dictionary<VowelGroupEnum, string> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, "сын" },
        { VowelGroupEnum.и_е_э, "син" },
        { VowelGroupEnum.у_ю, "сун" },
        { VowelGroupEnum.о_ё, "сун" },
        { VowelGroupEnum.ө_ү, "сүн" },
    };
    
    public static string GetImperativeAlEnding(string verb)
    {
        var vowelGroup = verb.GetVowelGroup();
        return Mapping[vowelGroup];
    }
}