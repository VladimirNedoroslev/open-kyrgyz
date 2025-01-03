using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Verbs.Tenses.Conditional;

public static class ConditionalEnding
{
    private static readonly Dictionary<VowelGroupEnum, string> ConditionalMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "са" },
        { VowelGroupEnum.и_е_э, "се" },
        { VowelGroupEnum.у_ю, "са" },
        { VowelGroupEnum.о_ё, "со" },
        { VowelGroupEnum.ө_ү, "сө" },
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
                { PronounEnum.Сиздер, "ңыздар" },
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
                { PronounEnum.Силер, "ңор" },
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
        var pastEnding = ConditionalMapping[vowelGroup];
        return pastEnding + pastPronounEnding;
    }
}