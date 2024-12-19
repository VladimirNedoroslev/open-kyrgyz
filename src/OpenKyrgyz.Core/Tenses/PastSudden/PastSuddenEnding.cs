using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Tenses.PastSudden;

public static class PastSuddenEnding
{
    private static readonly Dictionary<VowelGroupEnum, string> PastSuddenMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "птыр" },
        { VowelGroupEnum.и_е_э, "птир" },
        { VowelGroupEnum.у_ю, "птур" },
        { VowelGroupEnum.о_ё, "птур" },
        { VowelGroupEnum.ө_ү, "птүр" },
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
                { PronounEnum.Алар, "шыптыр" },
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
                { PronounEnum.Алар, "шиптир" },
            }
        },
        {
            VowelGroupEnum.у_ю, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "мун" },
                { PronounEnum.Сен, "суң" },
                { PronounEnum.Сиз, "суз" },
                { PronounEnum.Ал, "" },
                { PronounEnum.Биз, "буз" },
                { PronounEnum.Силер, "суңар" },
                { PronounEnum.Сиздер, "суздар" },
                { PronounEnum.Алар, "шуптур" },
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
                { PronounEnum.Алар, "шуптур" },
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
                { PronounEnum.Алар, "шүптүр" },
            }
        }
    };

    public static string GetEnding(string verb, PronounEnum pronoun)
    {
        var vowelGroup = verb.GetVowelGroup();
        var pastPronounEnding = PronounMapping[vowelGroup][pronoun];
        if (pronoun == PronounEnum.Алар)
            return pastPronounEnding;
        
        var pastEnding = PastSuddenMapping[vowelGroup];
        return pastEnding + pastPronounEnding;
    }
}