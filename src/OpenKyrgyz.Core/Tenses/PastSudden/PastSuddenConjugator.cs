using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Interrogative;
using OpenKyrgyz.Core.Negative;
using OpenKyrgyz.Core.VerbForms.Cooperative;

namespace OpenKyrgyz.Core.Tenses.PastSudden;

public class PastSuddenConjugator
{
    public static string Conjugate(
        string verb,
        PronounEnum pronoun,
        VerbFormEnum form)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;

        if (pronoun == PronounEnum.Алар)
        {
            verb = ЫшEnding.GetЫшEnding(verb);
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

        verb = УаойReplacer.Replace(verb);

        return verb;
    }

    private static string ConjugateForPositive(string verb, PronounEnum pronoun)
    {
        verb = verb.HarmonizeVerbEndingIfNecessary();
        
        var ending = PastSuddenEnding.GetEnding(verb, pronoun);
        
        return $"{verb}{ending}";
    }
}