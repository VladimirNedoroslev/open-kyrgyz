using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Interrogative;

namespace OpenKyrgyz.Core.Tenses.WithDifferentNegative.PastIndefinite;

public class PastIndefiniteConjugator
{
    public static string Conjugate(
        string verb,
        PronounEnum pronoun,
        VerbFormEnum form = VerbFormEnum.Positive)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;

        if (pronoun == PronounEnum.Алар)
            return ConjugateForАлар(verb, form);


        if (form is VerbFormEnum.Negative or VerbFormEnum.NegativeAndInterrogative)
        {
            verb += PastIndefiniteEnding.GetPastIndefiniteEnding(verb);
        }

        if (form is VerbFormEnum.Negative)
        {
            return $"{verb} {pronoun.GetNegativeParticle()}";
        }

        if (form is VerbFormEnum.NegativeAndInterrogative)
        {
            return $"{verb} {pronoun.GetNegativeInterrogativeParticle()}";
        }

        verb = ConjugateForPositive(verb, pronoun);

        if (form is VerbFormEnum.Interrogative)
        {
            var interrogativeAffix = verb.GetInterrogativeAffix();
            return $"{verb}{interrogativeAffix}";
        }

        return verb;
    }

    private static string ConjugateForPositive(string verb, PronounEnum pronoun)
    {
        var ending = PastIndefiniteEnding.GetPositiveEnding(verb, pronoun);

        return $"{verb}{ending}";
    }

    private static readonly Dictionary<VowelGroupEnum, char> LinkingLetterForAlarCase = new()
    {
        { VowelGroupEnum.а_я_ы, 'ы' },
        { VowelGroupEnum.у_ю, 'у' },
        { VowelGroupEnum.и_е_э, 'и' },
        { VowelGroupEnum.о_ё, 'у' },
        { VowelGroupEnum.ө_ү, 'ү' },
    };

    private static string ConjugateForАлар(string verb, VerbFormEnum form)
    {
        var lastLetterType = verb.GetLastLetterType();
        if (lastLetterType is not LetterTypeEnum.Vowel)
        {
            var vowelGroup = verb.GetVowelGroup();
            var linkingLetter = LinkingLetterForAlarCase[vowelGroup];
            verb = verb.HarmonizeVerbEndingIfNecessary();
            verb += linkingLetter;
        }


        var ending = PastIndefiniteEnding.GetPositiveEnding(verb, PronounEnum.Алар);
        verb += ending;
        
        return form switch
        {
            VerbFormEnum.Positive => verb,
            VerbFormEnum.Negative => $"{verb} {PronounEnum.Алар.GetNegativeParticle()}",
            VerbFormEnum.Interrogative => $"{verb}{verb.GetInterrogativeAffix()}",
            VerbFormEnum.NegativeAndInterrogative => $"{verb} {PronounEnum.Алар.GetNegativeInterrogativeParticle()}",
            _ => verb
        };
    }
}