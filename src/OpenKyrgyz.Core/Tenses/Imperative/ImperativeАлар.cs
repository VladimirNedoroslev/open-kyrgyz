using System.Text;
using OpenKyrgyz.Core.Common;
using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Tenses.Imperative;

public class ImperativeАлар
{
    private static readonly Dictionary<VowelGroupEnum, string> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, "шсын" },
        { VowelGroupEnum.и_е_э, "шсин" },
        { VowelGroupEnum.у_ю, "шсун" },
        { VowelGroupEnum.о_ё, "шсун" },
        { VowelGroupEnum.ө_ү, "шсүн" },
    };
    
    public static string Generate(string verb)
    {
        var lastVowelIndex = verb.GetLastVowelIndex();
        var vowelGroup = VowelGroupMapping.VowelToGroupMapping[verb[lastVowelIndex]];
        var ending = Mapping[vowelGroup];
        
        if (lastVowelIndex == verb.Length - 1)
        {
            return ending;
        }
        
        var linkingVowel = vowelGroup switch
        {
            VowelGroupEnum.а_я_ы => 'ы',
            VowelGroupEnum.и_е_э => 'и',
            VowelGroupEnum.у_ю => 'у',
            VowelGroupEnum.о_ё => 'у',
            VowelGroupEnum.ө_ү => 'ү',
            _ => throw new ArgumentOutOfRangeException()
        };
        
        return linkingVowel + ending;
    }
}