using OpenKyrgyz.Core.Common;
using OpenKyrgyz.Core.Core;

namespace OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

public class PresentAndFutureSimpleLinkingLetterGenerator
{
    private static Dictionary<char, char> Mapping = new()
    {
        { 'а', 'а' },
        { 'я', 'а' },
        { 'ы', 'а' },
        { 'у', 'а' },
        { 'ю', 'а' },

        { 'и', 'е' },
        { 'е', 'е' },
        { 'э', 'е' },

        { 'о', 'о' },
        { 'ё', 'о' },

        { 'ө', 'ө' },
        { 'ү', 'ө' },
    };

    public static char GetLinkingChar(string word)
    {
        var lastVowelIndex = word.GetLastVowelIndex();
        if (lastVowelIndex == word.Length - 1)
        {
            return 'й';
        }

        return Mapping[word[lastVowelIndex]];
    }
}