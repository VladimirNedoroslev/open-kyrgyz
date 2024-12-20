using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Negative;

namespace OpenKyrgyz.Core.Tenses.FutureProbable;

public static class FutureProbableEnding
{
    private static readonly Dictionary<VowelGroupEnum, char> MappingForConsonantEnding = new()
    {
        { VowelGroupEnum.а_я_ы, 'а' },
        { VowelGroupEnum.у_ю, 'а' },
        { VowelGroupEnum.и_е_э, 'е' },
        { VowelGroupEnum.о_ё, 'о' },
        { VowelGroupEnum.ө_ү, 'ө' },
    };

    private static readonly Dictionary<VowelGroupEnum, Dictionary<PronounEnum, string>> PronounMapping = new()
    {
        {
            VowelGroupEnum.а_я_ы, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "рмын" },
                { PronounEnum.Сен, "рсың" },
                { PronounEnum.Сиз, "рсыз" },
                { PronounEnum.Ал, "р" },
                { PronounEnum.Биз, "рбыз" },
                { PronounEnum.Силер, "рсыңар" },
                { PronounEnum.Сиздер, "рсыздар" },
                { PronounEnum.Алар, "шар" },
            }
        },
        {
            VowelGroupEnum.и_е_э, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "рмин" },
                { PronounEnum.Сен, "рсиң" },
                { PronounEnum.Сиз, "рсиз" },
                { PronounEnum.Ал, "р" },
                { PronounEnum.Биз, "рбиз" },
                { PronounEnum.Силер, "рсиңер" },
                { PronounEnum.Сиздер, "рсиздер" },
                { PronounEnum.Алар, "шер" },
            }
        },
        {
            VowelGroupEnum.у_ю, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "рмун" },
                { PronounEnum.Сен, "рсуң" },
                { PronounEnum.Сиз, "рсуз" },
                { PronounEnum.Ал, "р" },
                { PronounEnum.Биз, "рбуз" },
                { PronounEnum.Силер, "рсуңар" },
                { PronounEnum.Сиздер, "рсуздар" },
                { PronounEnum.Алар, "шар" },
            }
        },
        {
            VowelGroupEnum.о_ё, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "рмун" },
                { PronounEnum.Сен, "рсуң" },
                { PronounEnum.Сиз, "рсуз" },
                { PronounEnum.Ал, "р" },
                { PronounEnum.Биз, "рбуз" },
                { PronounEnum.Силер, "рсуңар" },
                { PronounEnum.Сиздер, "рсуздар" },
                { PronounEnum.Алар, "шор" },
            }
        },
        {
            VowelGroupEnum.ө_ү, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "рмүн" },
                { PronounEnum.Сен, "рсүң" },
                { PronounEnum.Сиз, "рсүз" },
                { PronounEnum.Ал, "р" },
                { PronounEnum.Биз, "рбүз" },
                { PronounEnum.Силер, "рсүңөр" },
                { PronounEnum.Сиздер, "рсүздөр" },
                { PronounEnum.Алар, "шөр" },
            }
        }
    };

    private static readonly Dictionary<VowelGroupEnum, Dictionary<PronounEnum, string>> PronounMappingNegative = new()
    {
        {
            VowelGroupEnum.а_я_ы, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "смын" },
                { PronounEnum.Сен, "ссың" },
                { PronounEnum.Сиз, "ссыз" },
                { PronounEnum.Ал, "с" },
                { PronounEnum.Биз, "спыз" },
                { PronounEnum.Силер, "ссыңар" },
                { PronounEnum.Сиздер, "ссыздар" },
                { PronounEnum.Алар, "шпас" },
            }
        },
        {
            VowelGroupEnum.и_е_э, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "смин" },
                { PronounEnum.Сен, "ссиң" },
                { PronounEnum.Сиз, "ссиз" },
                { PronounEnum.Ал, "с" },
                { PronounEnum.Биз, "спиз" },
                { PronounEnum.Силер, "ссиңер" },
                { PronounEnum.Сиздер, "ссиздер" },
                { PronounEnum.Алар, "шпес" },
            }
        },
        {
            VowelGroupEnum.у_ю, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "смын" },
                { PronounEnum.Сен, "ссың" },
                { PronounEnum.Сиз, "ссыз" },
                { PronounEnum.Ал, "с" },
                { PronounEnum.Биз, "спыз" },
                { PronounEnum.Силер, "ссыңар" },
                { PronounEnum.Сиздер, "ссыздар" },
                { PronounEnum.Алар, "шпас" },
            }
        },
        {
            VowelGroupEnum.о_ё, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "смун" },
                { PronounEnum.Сен, "ссуң" },
                { PronounEnum.Сиз, "ссуз" },
                { PronounEnum.Ал, "с" },
                { PronounEnum.Биз, "спуз" },
                { PronounEnum.Силер, "ссуңар" },
                { PronounEnum.Сиздер, "ссуздар" },
                { PronounEnum.Алар, "шпос" },
            }
        },
        {
            VowelGroupEnum.ө_ү, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "смүн" },
                { PronounEnum.Сен, "ссүң" },
                { PronounEnum.Сиз, "ссүз" },
                { PronounEnum.Ал, "с" },
                { PronounEnum.Биз, "спүз" },
                { PronounEnum.Силер, "ссүңөр" },
                { PronounEnum.Сиздер, "ссүздөр" },
                { PronounEnum.Алар, "шпөс" },
            }
        }
    };

    public static string GetEndingForPronounPositive(string verb, PronounEnum pronoun)
    {
        var vowelGroup = verb.GetVowelGroup();
        var lastLetterType = verb.GetLastLetterType();
        if (lastLetterType is not LetterTypeEnum.Vowel)
        {
            var newVowelGroup = VowelGroupMapping.VowelToGroupMapping[MappingForConsonantEnding[vowelGroup]];
            return MappingForConsonantEnding[vowelGroup] + PronounMapping[newVowelGroup][pronoun];
        }

        return PronounMapping[vowelGroup][pronoun];
    }

    public static string GetEndingForPronounNegative(string verb, PronounEnum pronoun)
    {
        var negativeAffix = verb.GetNegativeAffix();
        var vowelGroup = negativeAffix.Value.GetVowelGroup();

        return negativeAffix + PronounMappingNegative[vowelGroup][pronoun];
    }
}