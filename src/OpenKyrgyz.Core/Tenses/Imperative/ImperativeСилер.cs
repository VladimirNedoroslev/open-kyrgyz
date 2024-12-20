using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Negative;

namespace OpenKyrgyz.Core.Tenses.Imperative;

public class ImperativeСилер
{
    private static readonly Dictionary<VowelGroupEnum, Dictionary<LetterTypeEnum, string>> Mappings = new()
    {
        {
            VowelGroupEnum.а_я_ы, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "гыла" },
                { LetterTypeEnum.VoicedConsonant, "гыла" },
                { LetterTypeEnum.VoicelessConsonant, "кыла" },
            }
        },
        {
            VowelGroupEnum.и_е_э, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "гиле" },
                { LetterTypeEnum.VoicedConsonant, "гиле" },
                { LetterTypeEnum.VoicelessConsonant, "киле" },
            }
        },
        {
            VowelGroupEnum.у_ю, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "гула" },
                { LetterTypeEnum.VoicedConsonant, "гула" },
                { LetterTypeEnum.VoicelessConsonant, "кула" },
            }
        },
        {
            VowelGroupEnum.о_ё, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "гула" },
                { LetterTypeEnum.VoicedConsonant, "гула" },
                { LetterTypeEnum.VoicelessConsonant, "кула" },
            }
        },
        {
            VowelGroupEnum.ө_ү, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "гүлө" },
                { LetterTypeEnum.VoicedConsonant, "гүлө" },
                { LetterTypeEnum.VoicelessConsonant, "күлө" },
            }
        },
    };

    public static string ConjugatePositive(string verb)
    {
        var vowelGroup = verb.GetVowelGroup();
        var lastLetterType = verb.GetLastLetterType();
        return verb + Mappings[vowelGroup][lastLetterType];
    }
    
    public static string ConjugateNegative(string verb)
    {
        var negativeVerb = verb + verb.GetNegativeAffix();
        return ConjugatePositive(negativeVerb);
    }
}