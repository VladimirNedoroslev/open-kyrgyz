using OpenKyrgyz.Core.Common;
using OpenKyrgyz.Core.Core;

namespace OpenKyrgyz.Core.Tenses.Imperative;

public class ImperativeСенPolite
{
    private static readonly Dictionary<VowelGroupEnum, string> VowelGroupToSenPoliteEndingMappings = new()
    {
        { VowelGroupEnum.а_я_ы, "чы" },
        { VowelGroupEnum.и_е_э, "чи" },
        { VowelGroupEnum.у_ю, "чу" },
        { VowelGroupEnum.о_ё, "чу" },
        { VowelGroupEnum.ө_ү, "чү" },
    };

    public static string Generate(string verb)
    {
        var lastVowelIndex = verb.GetLastVowelIndex();
        var vowelGroup = Mappings.VowelToGroupMapping[verb[lastVowelIndex]];
        var correspondingEnding = VowelGroupToSenPoliteEndingMappings[vowelGroup];
        return $"{verb}{correspondingEnding}";
    }
}