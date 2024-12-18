using OpenKyrgyz.Core.Common;
using OpenKyrgyz.Core.Core;

namespace OpenKyrgyz.Core.Tenses.Imperative;

public class ImperativeСенOrder
{
    private static readonly Dictionary<VowelGroupEnum, string> VowelGroupToSenOrderEndingMappings = new()
    {
        { VowelGroupEnum.а_я_ы, "ын" },
        { VowelGroupEnum.и_е_э, "ин" },
        { VowelGroupEnum.у_ю, "ун" },
        { VowelGroupEnum.о_ё, "ун" },
        { VowelGroupEnum.ө_ү, "үн" },
    };

    public static string Generate(string verb)
    {
        var lastSymbol = verb[^1];

        var lastVowelIndex = verb.GetLastVowelIndex();
        var vowelGroup = Mappings.VowelToGroupMapping[verb[lastVowelIndex]];
        var correspondingEnding = VowelGroupToSenOrderEndingMappings[vowelGroup];

        var lastSymbolResult = lastSymbol.IsConsonant();
        if (lastSymbolResult.IsT0 || lastSymbolResult.IsT2)
        {
            return $"{verb}г{correspondingEnding}";
        }

        return $"{verb}к{correspondingEnding}";
    }
}