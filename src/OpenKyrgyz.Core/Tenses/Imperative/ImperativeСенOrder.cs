using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Tenses.Imperative;

public class ImperativeСенOrder
{
    private static readonly Dictionary<VowelGroupEnum, Dictionary<LetterTypeEnum, string>> Mapping = new()
    {
        {
            VowelGroupEnum.а_я_ы, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "гын" },
                { LetterTypeEnum.VoicedConsonant, "гын" },
                { LetterTypeEnum.VoicelessConsonant, "кын" },
            }
        },
        {
            VowelGroupEnum.и_е_э, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "гин" },
                { LetterTypeEnum.VoicedConsonant, "гин" },
                { LetterTypeEnum.VoicelessConsonant, "кин" },
            }
        },
        {
            VowelGroupEnum.у_ю, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "гун" },
                { LetterTypeEnum.VoicedConsonant, "гун" },
                { LetterTypeEnum.VoicelessConsonant, "кун" },
            }
        },
        {
            VowelGroupEnum.о_ё, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "гун" },
                { LetterTypeEnum.VoicedConsonant, "гун" },
                { LetterTypeEnum.VoicelessConsonant, "кун" },
            }
        },
        {
            VowelGroupEnum.ө_ү, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "гүн" },
                { LetterTypeEnum.VoicedConsonant, "гүн" },
                { LetterTypeEnum.VoicelessConsonant, "күн" },
            }
        },
    };

    public static string GetImperativeSenOrderEnding(string verb)
    {
        var vowelGroup = verb.GetVowelGroup();
        var lastLetterType = verb.GetLastLetterType();
        return Mapping[vowelGroup][lastLetterType];
    }
}