namespace OpenKyrgyz.Core.Core;

public static class Vowels
{
    public static readonly HashSet<char> AllVowels = ['а', 'я', 'ы', 'о', 'ё', 'у', 'ю', 'е', 'э', 'и', 'ө', 'ү'];

    public static bool IsVowel(this char symbol)
    {
        return AllVowels.Contains(symbol);
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