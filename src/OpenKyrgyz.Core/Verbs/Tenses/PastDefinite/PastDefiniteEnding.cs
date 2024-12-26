using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Verbs.Tenses.PastDefinite;

public static class PastDefiniteEnding
{
    private static readonly Dictionary<VowelGroupEnum, Dictionary<LetterTypeEnum, string>> PastMapping = new()
    {
        {
            VowelGroupEnum.а_я_ы, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "ды" },
                { LetterTypeEnum.VoicedConsonant, "ды" },
                { LetterTypeEnum.VoicelessConsonant, "ты" },
            }
        },
        {
            VowelGroupEnum.и_е_э, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "ди" },
                { LetterTypeEnum.VoicedConsonant, "ди" },
                { LetterTypeEnum.VoicelessConsonant, "ти" },
            }
        },
        {
            VowelGroupEnum.у_ю, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "ду" },
                { LetterTypeEnum.VoicedConsonant, "ду" },
                { LetterTypeEnum.VoicelessConsonant, "ту" },
            }
        },
        {
            VowelGroupEnum.о_ё, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "ду" },
                { LetterTypeEnum.VoicedConsonant, "ду" },
                { LetterTypeEnum.VoicelessConsonant, "ту" },
            }
        },
        {
            VowelGroupEnum.ө_ү, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "дү" },
                { LetterTypeEnum.VoicedConsonant, "дү" },
                { LetterTypeEnum.VoicelessConsonant, "тү" },
            }
        },
    };

    private static readonly Dictionary<VowelGroupEnum, Dictionary<PronounEnum, string>> PronounMapping = new()
    {
        {
            VowelGroupEnum.а_я_ы, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "м" },
                { PronounEnum.Сен, "ң" },
                { PronounEnum.Сиз, "ңыз" },
                { PronounEnum.Ал, "" },
                { PronounEnum.Биз, "к" },
                { PronounEnum.Силер, "ңар" },
                { PronounEnum.Сиздер, "ңыздар" },
                { PronounEnum.Алар, "" },
            }
        },
        {
            VowelGroupEnum.и_е_э, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "м" },
                { PronounEnum.Сен, "ң" },
                { PronounEnum.Сиз, "ңиз" },
                { PronounEnum.Ал, "" },
                { PronounEnum.Биз, "к" },
                { PronounEnum.Силер, "ңер" },
                { PronounEnum.Сиздер, "ңиздер" },
                { PronounEnum.Алар, "" },
            }
        },
        {
            VowelGroupEnum.у_ю, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "м" },
                { PronounEnum.Сен, "ң" },
                { PronounEnum.Сиз, "ңуз" },
                { PronounEnum.Ал, "" },
                { PronounEnum.Биз, "к" },
                { PronounEnum.Силер, "ңар" },
                { PronounEnum.Сиздер, "ңуздар" },
                { PronounEnum.Алар, "" },
            }
        },
        {
            VowelGroupEnum.о_ё, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "м" },
                { PronounEnum.Сен, "ң" },
                { PronounEnum.Сиз, "ңуз" },
                { PronounEnum.Ал, "" },
                { PronounEnum.Биз, "к" },
                { PronounEnum.Силер, "ңар" },
                { PronounEnum.Сиздер, "ңуздар" },
                { PronounEnum.Алар, "" },
            }
        },
        {
            VowelGroupEnum.ө_ү, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "м" },
                { PronounEnum.Сен, "ң" },
                { PronounEnum.Сиз, "ңүз" },
                { PronounEnum.Ал, "" },
                { PronounEnum.Биз, "к" },
                { PronounEnum.Силер, "ңөр" },
                { PronounEnum.Сиздер, "ңүздөр" },
                { PronounEnum.Алар, "" },
            }
        }
    };

    public static string GetEnding(string verb, PronounEnum pronoun)
    {
        var vowelGroup = verb.GetVowelGroup();
        var pastPronounEnding = PronounMapping[vowelGroup][pronoun];

        var lastLetterType = verb.GetLastLetterType();
        var pastEnding = PastMapping[vowelGroup][lastLetterType];
        return pastEnding + pastPronounEnding;
    }
}