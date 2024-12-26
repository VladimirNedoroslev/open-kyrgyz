using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Interrogative;

namespace OpenKyrgyz.Core.Verbs.Tenses.WithDifferentNegative;

public static class NegativeParticle
{
    private static readonly Dictionary<PronounEnum, string> Mapping = new()
    {
        { PronounEnum.Мен, "эмесмин" },
        { PronounEnum.Сен, "эмессиң" },
        { PronounEnum.Сиз, "эмессиз" },
        { PronounEnum.Ал, "эмес" },
        { PronounEnum.Биз, "эмеспиз" },
        { PronounEnum.Силер, "эмессиңер" },
        { PronounEnum.Сиздер, "эмессиздер" },
        { PronounEnum.Алар, "эмес" },
    };

    public static string GetNegativeParticle(this PronounEnum pronounEnum)
    {
        return Mapping[pronounEnum];
    }

    public static string GetNegativeInterrogativeParticle(this PronounEnum pronounEnum)
    {
        var particle = Mapping[pronounEnum];
        var interrogativeAffix = particle.GetInterrogativeAffix();
        return $"{particle}{interrogativeAffix}";
    }
}