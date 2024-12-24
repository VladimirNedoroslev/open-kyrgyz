using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Forms.Gerund;
using OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

namespace OpenKyrgyz.Core.Tenses.PresentContinuous;

public class PresentContinuousConjugator
{
    public const string AuxiliaryVerb = "жат";

    public static string Conjugate(
        string verb,
        PronounEnum pronoun,
        VerbFormEnum form)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;

        string gerundVerb;
        if (form is VerbFormEnum.Positive or VerbFormEnum.Interrogative)
        {
            gerundVerb = verb switch
            {
                "бар" => "бара",
                "кел" => "келе",
                _ => Gerund.Get(verb, VerbFormEnum.Positive)
            };
        }
        else
        {
            gerundVerb = Gerund.Get(verb, VerbFormEnum.Negative);
        }

        if (form is VerbFormEnum.Negative)
            form = VerbFormEnum.Positive;
        
        if (form is VerbFormEnum.NegativeAndInterrogative)
            form = VerbFormEnum.Interrogative;
        
        var conjugatedAuxiliaryVerb = PresentAndFutureSimpleConjugator.Conjugate(AuxiliaryVerb, pronoun, form);

        return $"{gerundVerb} {conjugatedAuxiliaryVerb}";
    }
}