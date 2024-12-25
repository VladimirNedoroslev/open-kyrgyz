using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Core;

public static class ConsonantsExtensions
{
    public static bool IsConsonant(this char letter)
    {
        return letter.GetLetterType() is LetterTypeEnum.VoicelessConsonant or LetterTypeEnum.VoicedConsonant;
    }

    public static char GetLastConsonant(this string word)
    {
        var i = 0;
        do
        {
            i++;
        } while (word[^i].IsVowel());

        return word[^i];
    }
}