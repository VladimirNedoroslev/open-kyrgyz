using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Forms.Cooperative;
using OpenKyrgyz.Core.Interrogative;
using OpenKyrgyz.Core.Negative;

namespace OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

public class PresentAndFutureSimpleConjugator
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
            if (pronoun == PronounEnum.Ал)
            {
                // remove last letter
                verb = verb[..^1];
            }

            var interrogativeAffix = verb.GetInterrogativeAffix();
            verb += interrogativeAffix.Value;
        }

        verb = УаойReplacer.Replace(verb);

        return verb;
    }


    private static string ConjugateForPositive(string verb, PronounEnum pronoun)
    {
        verb = verb.HarmonizeVerbEndingIfNecessary();

        var linkingLetter = АеөойLinkingLetter.GetLinkingChar(verb);

        verb += linkingLetter;

        var ending = PresentAndFutureSimpleEnding.GetEndingForPronoun(verb, pronoun);

        return $"{verb}{ending}";
    }
}