using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Plural;

public class PluralEnding
{
    private static readonly Dictionary<VowelGroupEnum, Dictionary<LetterTypeEnum, PluralAffix>> Mapping = new()
    {
        {
            VowelGroupEnum.а_я_ы, new Dictionary<LetterTypeEnum, PluralAffix>
            {
                { LetterTypeEnum.Vowel, PluralAffix.Лар },
                { LetterTypeEnum.VoicedConsonant, PluralAffix.Дар },
                { LetterTypeEnum.VoicelessConsonant, PluralAffix.Тар },
            }
        },
        {
            VowelGroupEnum.у_ю, new Dictionary<LetterTypeEnum, PluralAffix>
            {
                { LetterTypeEnum.Vowel, PluralAffix.Лар },
                { LetterTypeEnum.VoicedConsonant, PluralAffix.Дар },
                { LetterTypeEnum.VoicelessConsonant, PluralAffix.Тар },
            }
        },
        {
            VowelGroupEnum.и_е_э, new Dictionary<LetterTypeEnum, PluralAffix>
            {
                { LetterTypeEnum.Vowel, PluralAffix.Лер },
                { LetterTypeEnum.VoicedConsonant, PluralAffix.Дер },
                { LetterTypeEnum.VoicelessConsonant, PluralAffix.Тер },
            }
        },
        {
            VowelGroupEnum.о_ё, new Dictionary<LetterTypeEnum, PluralAffix>
            {
                { LetterTypeEnum.Vowel, PluralAffix.Лор },
                { LetterTypeEnum.VoicedConsonant, PluralAffix.Дор },
                { LetterTypeEnum.VoicelessConsonant, PluralAffix.Тор },
            }
        },
        {
            VowelGroupEnum.ө_ү, new Dictionary<LetterTypeEnum, PluralAffix>
            {
                { LetterTypeEnum.Vowel, PluralAffix.Лөр },
                { LetterTypeEnum.VoicedConsonant, PluralAffix.Дөр },
                { LetterTypeEnum.VoicelessConsonant, PluralAffix.Төр },
            }
        },
    };


    public static PluralAffix GetPluralAffix(string word)
    {
        // exception case
        if (word.Equals("бала"))
            return PluralAffix.Дар;

        var vowelGroup = word.GetVowelGroup();
        var lastLetter = word[^1];
        // р й go with 'лар, лер, лор, лөр
        var lastLetterType = lastLetter is 'р' or 'й'
            ? LetterTypeEnum.Vowel
            : word.GetLastLetterType();


        return Mapping[vowelGroup][lastLetterType];
    }
}