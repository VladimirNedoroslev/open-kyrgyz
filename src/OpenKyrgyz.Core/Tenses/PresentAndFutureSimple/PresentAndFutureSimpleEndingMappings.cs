using OpenKyrgyz.Core.Common;

namespace OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

public static class PresentAndFutureSimpleEndingMappings
{
    private static readonly Dictionary<VowelGroupEnum, Dictionary<PronounEnum, string>> Mappings = new()
    {
        {
            VowelGroupEnum.а_я_ы, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "мын" },
                { PronounEnum.Сен, "сың" },
                { PronounEnum.Сиз, "сыз" },
                { PronounEnum.Ал, "т" },
                { PronounEnum.Биз, "быз" },
                { PronounEnum.Силер, "сыңар" },
                { PronounEnum.Сиздер, "сыздар" },
                { PronounEnum.Алар, "шат" },
            }
        },
        {
            VowelGroupEnum.и_е_э, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "мин" },
                { PronounEnum.Сен, "сиң" },
                { PronounEnum.Сиз, "сиз" },
                { PronounEnum.Ал, "т" },
                { PronounEnum.Биз, "биз" },
                { PronounEnum.Силер, "сиңер" },
                { PronounEnum.Сиздер, "сиздер" },
                { PronounEnum.Алар, "шет" },
            }
        },
        {
            VowelGroupEnum.у_ю, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "мун" },
                { PronounEnum.Сен, "суң" },
                { PronounEnum.Сиз, "суз" },
                { PronounEnum.Ал, "т" },
                { PronounEnum.Биз, "буз" },
                { PronounEnum.Силер, "суңар" },
                { PronounEnum.Сиздер, "суздар" },
                { PronounEnum.Алар, "шат" },
            }
        },
        {
            VowelGroupEnum.о_ё, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "мун" },
                { PronounEnum.Сен, "суң" },
                { PronounEnum.Сиз, "суз" },
                { PronounEnum.Ал, "т" },
                { PronounEnum.Биз, "буз" },
                { PronounEnum.Силер, "суңар" },
                { PronounEnum.Сиздер, "суздар" },
                { PronounEnum.Алар, "шот" },
            }
        },
        {
            VowelGroupEnum.ө_ү, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "мүн" },
                { PronounEnum.Сен, "сүң" },
                { PronounEnum.Сиз, "сүз" },
                { PronounEnum.Ал, "т" },
                { PronounEnum.Биз, "бүз" },
                { PronounEnum.Силер, "сүңөр" },
                { PronounEnum.Сиздер, "сүздөр" },
                { PronounEnum.Алар, "шөт" },
            }
        }
    };

    public static Dictionary<PronounEnum, string> GetEnding(VowelGroupEnum vowelGroup)
    {
        return Mappings[vowelGroup];
    }
}