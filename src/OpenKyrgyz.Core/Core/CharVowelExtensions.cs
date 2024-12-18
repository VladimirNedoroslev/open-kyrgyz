using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Core;

public static class CharVowelExtensions
{
    public static bool IsVowel(this char letter)
    {
        return letter.GetLetterType() is LetterTypeEnum.Vowel;
    }

    public static int GetLastVowelIndex(this string word)
    {
        var i = 0;
        do
        {
            i++;
        } while (!word[^i].IsVowel());

        return word.Length - i;
    }
}