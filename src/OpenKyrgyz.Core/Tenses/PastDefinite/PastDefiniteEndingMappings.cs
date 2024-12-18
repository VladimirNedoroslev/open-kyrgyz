using OpenKyrgyz.Core.Common;

namespace OpenKyrgyz.Core.Tenses.PastDefinite;

public static class PastDefiniteEndingMappings
{
    private static readonly Dictionary<VowelGroupEnum, Dictionary<PronounEnum, string>> Mappings = new()
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
                { PronounEnum.Алар, "ы" },
            }
        },
        {
            VowelGroupEnum.и_е_э, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "м" },
                { PronounEnum.Сен, "ң" },
                { PronounEnum.Сиз, "иңиз" },
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
                { PronounEnum.Ал, "т" },
                { PronounEnum.Биз, "бүз" },
                { PronounEnum.Силер, "ңөр" },
                { PronounEnum.Сиздер, "ңүздөр" },
                { PronounEnum.Алар, "" },
            }
        }
    };

    public static Dictionary<PronounEnum, string> GetEnding(VowelGroupEnum vowelGroup)
    {
        return Mappings[vowelGroup];
    }
}