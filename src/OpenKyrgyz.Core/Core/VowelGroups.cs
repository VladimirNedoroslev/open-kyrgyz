using OpenKyrgyz.Core.Common;

namespace OpenKyrgyz.Core.Core;

public static class VowelGroups
{
    public static readonly HashSet<char> FirstGroup = ['а', 'я', 'ы'];
    public static readonly HashSet<char> SecondGroup = ['и', 'е', 'э'];
    public static readonly HashSet<char> ThirdGroup = ['у', 'ю'];
    public static readonly HashSet<char> FourthGroup = ['о', 'ё'];
    public static readonly HashSet<char> FifthGroup = ['ө', 'ү'];

    public static VowelGroupEnum GetVowelGroup(this char vowel)
    {
        if (FirstGroup.Contains(vowel))
            return VowelGroupEnum.а_я_ы;

        if (SecondGroup.Contains(vowel))
            return VowelGroupEnum.и_е_э;

        if (ThirdGroup.Contains(vowel))
            return VowelGroupEnum.у_ю;

        if (FourthGroup.Contains(vowel))
            return VowelGroupEnum.о_ё;
        
        if (FifthGroup.Contains(vowel))
            return VowelGroupEnum.ө_ү;
        throw new Exception("Undefined vowel group");
    }

    public static VowelGroupEnum GetVowelGroup(this string word)
    {
        var lastVowelIndex = word.GetLastVowelIndex();
        var lastVowel = word[lastVowelIndex];
        return GetVowelGroup(lastVowel);
    }
}