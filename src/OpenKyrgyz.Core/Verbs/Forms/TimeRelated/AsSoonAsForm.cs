using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Possessive;
using OpenKyrgyz.Core.Verbs.Tenses.FutureProbable;

namespace OpenKyrgyz.Core.Verbs.Forms.TimeRelated;

public class AsSoonAsForm
{
    public const string AsSoonAsInKyrgyz = "замат";

    public static string Get(string verb)
    {
        return FutureProbableConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Positive) + $" {AsSoonAsInKyrgyz}";
    }


    public static string GetPronounForm(string verb, PronounEnum pronoun)
    {
        if (string.IsNullOrEmpty(verb))
            return verb;

        var verbWithАрEnding = FutureProbableConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Positive);

        return verbWithАрEnding.ToPossessive(pronoun) + " менен";
    }
}