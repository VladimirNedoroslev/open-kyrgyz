using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Tenses.PastIndefinite;

public static class PastIndefiniteEnding
{
    private static readonly Dictionary<VowelGroupEnum, Dictionary<LetterTypeEnum, string>> PastMapping = new()
    {
        {
            VowelGroupEnum.а_я_ы, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "ган" },
                { LetterTypeEnum.VoicedConsonant, "ган" },
                { LetterTypeEnum.VoicelessConsonant, "кан" },
            }
        },
        {
            VowelGroupEnum.и_е_э, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "ген" },
                { LetterTypeEnum.VoicedConsonant, "ген" },
                { LetterTypeEnum.VoicelessConsonant, "кен" },
            }
        },
        {
            VowelGroupEnum.у_ю, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "ган" },
                { LetterTypeEnum.VoicedConsonant, "ган" },
                { LetterTypeEnum.VoicelessConsonant, "кан" },
            }
        },
        {
            VowelGroupEnum.о_ё, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "гон" },
                { LetterTypeEnum.VoicedConsonant, "гон" },
                { LetterTypeEnum.VoicelessConsonant, "кон" },
            }
        },
        {
            VowelGroupEnum.ө_ү, new Dictionary<LetterTypeEnum, string>
            {
                { LetterTypeEnum.Vowel, "гөн" },
                { LetterTypeEnum.VoicedConsonant, "гөн" },
                { LetterTypeEnum.VoicelessConsonant, "көн" },
            }
        },
    };

    private static readonly Dictionary<VowelGroupEnum, Dictionary<PronounEnum, string>> PronounMapping = new()
    {
        {
            VowelGroupEnum.а_я_ы, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "мын" },
                { PronounEnum.Сен, "сың" },
                { PronounEnum.Сиз, "сыз" },
                { PronounEnum.Ал, "" },
                { PronounEnum.Биз, "быз" },
                { PronounEnum.Силер, "сыңар" },
                { PronounEnum.Сиздер, "сыздар" },
                { PronounEnum.Алар, "шкан" },
            }
        },
        {
            VowelGroupEnum.и_е_э, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "мин" },
                { PronounEnum.Сен, "сиң" },
                { PronounEnum.Сиз, "сиз" },
                { PronounEnum.Ал, "" },
                { PronounEnum.Биз, "биз" },
                { PronounEnum.Силер, "сиңер" },
                { PronounEnum.Сиздер, "сиздер" },
                { PronounEnum.Алар, "шкен" },
            }
        },
        {
            VowelGroupEnum.у_ю, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "мын" },
                { PronounEnum.Сен, "сың" },
                { PronounEnum.Сиз, "сыз" },
                { PronounEnum.Ал, "" },
                { PronounEnum.Биз, "быз" },
                { PronounEnum.Силер, "сыңар" },
                { PronounEnum.Сиздер, "сыздар" },
                { PronounEnum.Алар, "шкан" },
            }
        },
        {
            VowelGroupEnum.о_ё, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "мун" },
                { PronounEnum.Сен, "суң" },
                { PronounEnum.Сиз, "суз" },
                { PronounEnum.Ал, "" },
                { PronounEnum.Биз, "буз" },
                { PronounEnum.Силер, "суңар" },
                { PronounEnum.Сиздер, "суздар" },
                { PronounEnum.Алар, "шкон" },
            }
        },
        {
            VowelGroupEnum.ө_ү, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "мүн" },
                { PronounEnum.Сен, "сүң" },
                { PronounEnum.Сиз, "сүз" },
                { PronounEnum.Ал, "" },
                { PronounEnum.Биз, "бүз" },
                { PronounEnum.Силер, "сүңөр" },
                { PronounEnum.Сиздер, "сүздөр" },
                { PronounEnum.Алар, "шкөн" },
            }
        }
    };

    public static string GetEnding(string verb, PronounEnum pronoun)
    {
        var vowelGroup = verb.GetVowelGroup();
        var pastPronounEnding = PronounMapping[vowelGroup][pronoun];
        if (pronoun == PronounEnum.Алар)
            return pastPronounEnding;
        
        var lastLetterType = verb.GetLastLetterType();
        var pastEnding = PastMapping[vowelGroup][lastLetterType];
        return pastEnding + pastPronounEnding;
    }
}