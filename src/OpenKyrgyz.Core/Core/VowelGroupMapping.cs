using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Core;

public static class VowelGroupMapping
{
    public static readonly Dictionary<char, VowelGroupEnum> VowelToGroupMapping = new()
    {
        { 'а', VowelGroupEnum.а_я_ы },
        { 'я', VowelGroupEnum.а_я_ы },
        { 'ы', VowelGroupEnum.а_я_ы },

        { 'и', VowelGroupEnum.и_е_э },
        { 'е', VowelGroupEnum.и_е_э },
        { 'э', VowelGroupEnum.и_е_э },

        { 'у', VowelGroupEnum.у_ю },
        { 'ю', VowelGroupEnum.у_ю },

        { 'о', VowelGroupEnum.о_ё },
        { 'ё', VowelGroupEnum.о_ё },

        { 'ө', VowelGroupEnum.ө_ү },
        { 'ү', VowelGroupEnum.ө_ү },
    };

    public static VowelGroupEnum GetVowelGroup(this string word)
    {
        var lastVowelIndex = word.GetLastVowelIndex();
        var lastVowel = word[lastVowelIndex];
        return VowelToGroupMapping[lastVowel];
    }
}