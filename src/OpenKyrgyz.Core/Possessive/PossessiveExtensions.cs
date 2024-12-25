using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Possessive;

public static class PossessiveExtensions
{
    public static string ToPossessive(this string word, PronounEnum pronoun)
    {
        return pronoun switch
        {
            PronounEnum.Мен => PossessiveМен.ToPossessive(word),
            PronounEnum.Сен => PossessiveСен.ToPossessive(word),
            PronounEnum.Сиз => PossessiveСиз.ToPossessive(word),
            PronounEnum.Ал => PossessiveАлАлар.ToPossessive(word),
            PronounEnum.Биз => PossessiveБиз.ToPossessive(word),
            PronounEnum.Силер => PossessiveСилер.ToPossessive(word),
            PronounEnum.Сиздер => PossessiveСиздер.ToPossessive(word),
            PronounEnum.Алар => PossessiveАлАлар.ToPossessive(word),
            _ => throw new ArgumentOutOfRangeException(nameof(pronoun), pronoun, null)
        };
    }
}