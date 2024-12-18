using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

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
        var vowelGroup = verb.GetVowelGroup();
        var ending = VowelGroupToSizImperativeEndingMapping[vowelGroup];

        var lastLetterType = verb.GetLastLetterType();
        if (lastLetterType == LetterTypeEnum.Vowel)
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