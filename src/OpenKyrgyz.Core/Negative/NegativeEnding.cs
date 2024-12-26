using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Negative;

public static class NegativeEnding
{
    private static readonly Dictionary<VowelGroupEnum, Dictionary<LetterTypeEnum, NegativeAffix>> Mapping = new()
    {
        {
            VowelGroupEnum.а_я_ы, new Dictionary<LetterTypeEnum, NegativeAffix>
            {
                { LetterTypeEnum.Vowel, NegativeAffix.Ба },
                { LetterTypeEnum.VoicedConsonant, NegativeAffix.Ба },
                { LetterTypeEnum.VoicelessConsonant, NegativeAffix.Па },
            }
        },
        {
            VowelGroupEnum.у_ю, new Dictionary<LetterTypeEnum, NegativeAffix>
            {
                { LetterTypeEnum.Vowel, NegativeAffix.Ба },
                { LetterTypeEnum.VoicedConsonant, NegativeAffix.Ба },
                { LetterTypeEnum.VoicelessConsonant, NegativeAffix.Па },
            }
        },
        {
            VowelGroupEnum.и_е_э, new Dictionary<LetterTypeEnum, NegativeAffix>
            {
                { LetterTypeEnum.Vowel, NegativeAffix.Бе },
                { LetterTypeEnum.VoicedConsonant, NegativeAffix.Бе },
                { LetterTypeEnum.VoicelessConsonant, NegativeAffix.Пе },
            }
        },
        {
            VowelGroupEnum.о_ё, new Dictionary<LetterTypeEnum, NegativeAffix>
            {
                { LetterTypeEnum.Vowel, NegativeAffix.Бо },
                { LetterTypeEnum.VoicedConsonant, NegativeAffix.Бо },
                { LetterTypeEnum.VoicelessConsonant, NegativeAffix.По },
            }
        },
        {
            VowelGroupEnum.ө_ү, new Dictionary<LetterTypeEnum, NegativeAffix>
            {
                { LetterTypeEnum.Vowel, NegativeAffix.Бө },
                { LetterTypeEnum.VoicedConsonant, NegativeAffix.Бө },
                { LetterTypeEnum.VoicelessConsonant, NegativeAffix.Пө },
            }
        }
    };


    public static NegativeAffix GetNegativeAffix(this string verb)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return NegativeAffix.Empty;
        var vowelGroup = verb.GetVowelGroup();
        var lastLetterType = verb.GetLastLetterType();
        return Mapping[vowelGroup][lastLetterType];
    }
}