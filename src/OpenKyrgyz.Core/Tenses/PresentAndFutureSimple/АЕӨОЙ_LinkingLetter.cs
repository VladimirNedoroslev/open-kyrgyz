using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

public static class АеөойLinkingLetter
{
    private static readonly Dictionary<VowelGroupEnum, char> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, 'а' },
        { VowelGroupEnum.у_ю, 'а' },
        { VowelGroupEnum.и_е_э, 'е' },
        { VowelGroupEnum.о_ё, 'о' },
        { VowelGroupEnum.ө_ү, 'ө' },
    };

    public static char GetLinkingChar(string word)
    {
        var lastLetterType = word.GetLastLetterType();
        if (lastLetterType == LetterTypeEnum.Vowel)
        {
            return 'й';
        }

        var vowelGroup = word.GetVowelGroup();

        return Mapping[vowelGroup];
    }
}