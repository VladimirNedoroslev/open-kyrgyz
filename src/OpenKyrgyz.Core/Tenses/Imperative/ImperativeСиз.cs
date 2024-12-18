using System.Text;
using OpenKyrgyz.Core.Common;
using OpenKyrgyz.Core.Core;

namespace OpenKyrgyz.Core.Tenses.Imperative;

public static class ImperativeСиз
{
    private static readonly Dictionary<VowelGroupEnum, string> VowelGroupToSizImperativeEndingMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ңыз" },
        { VowelGroupEnum.и_е_э, "ңиз" },
        { VowelGroupEnum.у_ю, "ңуз" },
        { VowelGroupEnum.о_ё, "ңуз" },
        { VowelGroupEnum.ө_ү, "ңүз" },
    };
    
    public static string Generate(string verb)
    {
        var lastSymbol = verb[^1];
        
        var lastVowelIndex = verb.GetLastVowelIndex();
        var vowelGroup = Mappings.VowelToGroupMapping[verb[lastVowelIndex]];
        var ending = VowelGroupToSizImperativeEndingMapping[vowelGroup];
        
        if (lastVowelIndex == verb.Length - 1)
        {
            return $"{verb}{ending}";
        }

        verb = verb.HarmonizeVerbEndingIfNecessary();
        
        var linkingVowel = vowelGroup switch
        {
            VowelGroupEnum.а_я_ы => 'ы',
            VowelGroupEnum.и_е_э => 'и',
            VowelGroupEnum.у_ю => 'у',
            VowelGroupEnum.о_ё => 'у',
            VowelGroupEnum.ө_ү => 'ү',
            _ => throw new ArgumentOutOfRangeException()
        };
        
        return $"{verb}{linkingVowel}{ending}";
    }
}