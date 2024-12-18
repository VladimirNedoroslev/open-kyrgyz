using OpenKyrgyz.Core.Common;
using OpenKyrgyz.Core.Core;

namespace OpenKyrgyz.Core.Tenses.Imperative;

public class ImperativeСилер
{
    private static readonly Dictionary<VowelGroupEnum, string> VowelGroupToSilerEndingMappings = new()
    {
        { VowelGroupEnum.а_я_ы, "ыла" },
        { VowelGroupEnum.и_е_э, "иле" },
        { VowelGroupEnum.у_ю, "ула" },
        { VowelGroupEnum.о_ё, "ула" },
        { VowelGroupEnum.ө_ү, "үлө" },
    };

    public static string Generate(string verb)
    {
        var lastSymbol = verb[^1];

        var lastVowelIndex = verb.GetLastVowelIndex();
        var vowelGroup = Mappings.VowelToGroupMapping[verb[lastVowelIndex]];
        var correspondingEnding = VowelGroupToSilerEndingMappings[vowelGroup];

        var lastSymbolResult = lastSymbol.IsConsonant();
        if (lastSymbolResult.IsT0 || lastSymbolResult.IsT2)
        {
            return $"{verb}г{correspondingEnding}";
        }

        return $"{verb}к{correspondingEnding}";
    }
}