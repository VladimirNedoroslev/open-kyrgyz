using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.FutureProbable;

namespace OpenKyrgyz.Core.Forms.TimeRelated;

public class AsSoonAsForm
{
    public const string AsSoonAsInKyrgyz = "замат";

    public static string Get(string verb)
    {
        return FutureProbableConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Positive) + $" {AsSoonAsInKyrgyz}";
    }
}