using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

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

    public static string GetEndingForPronoun(string verb, PronounEnum pronoun)
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
}