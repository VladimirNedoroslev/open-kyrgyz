using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Forms.Cooperative;
using OpenKyrgyz.Core.Interrogative;
using OpenKyrgyz.Core.Negative;

namespace OpenKyrgyz.Core.Tenses.PastDefinite;

public class PastDefiniteTenseConjugator
{
    public static string Conjugate(
        string verb,
        PronounEnum pronoun,
        VerbFormEnum form
    )
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        
        if (pronoun == PronounEnum.Алар)
        {
            verb = CooperativeMood.Get(verb);
        }

        if (form is VerbFormEnum.Negative or VerbFormEnum.NegativeAndInterrogative)
        {
            var negativeAffix = verb.GetNegativeAffix();
            verb += negativeAffix.Value;
        }
        
        verb = ConjugateForPositive(verb, pronoun);

        if (form is VerbFormEnum.Interrogative or VerbFormEnum.NegativeAndInterrogative)
        {
            var interrogativeAffix = verb.GetInterrogativeAffix();
            verb += interrogativeAffix.Value;
        }

        return verb;

    }

    public static string ConjugateForPositive(string verb, PronounEnum pronoun)
    {
        var ending = PastDefiniteEnding.GetEnding(verb, pronoun);

        return $"{verb}{ending}";
    }
}