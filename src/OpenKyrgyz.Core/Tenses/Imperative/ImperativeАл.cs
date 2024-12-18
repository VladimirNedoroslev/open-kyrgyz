using OpenKyrgyz.Core.Common;
using OpenKyrgyz.Core.Core;

namespace OpenKyrgyz.Core.Tenses.Imperative;

public class ImperativeАл
{
    private static readonly Dictionary<VowelGroupEnum, string> VowelGroupToAlEndingMappings = new()
    {
        { VowelGroupEnum.а_я_ы, "сын" },
        { VowelGroupEnum.и_е_э, "син" },
        { VowelGroupEnum.у_ю, "сун" },
        { VowelGroupEnum.о_ё, "сун" },
        { VowelGroupEnum.ө_ү, "сүн" },
    };
    
    public static string Generate(string verb)
    {
        var lastVowelIndex = verb.GetLastVowelIndex();
        var vowelGroup = Mappings.VowelToGroupMapping[verb[lastVowelIndex]];
        var correspondingEnding = VowelGroupToAlEndingMappings[vowelGroup];
        return $"{verb}{correspondingEnding}";
    }
}