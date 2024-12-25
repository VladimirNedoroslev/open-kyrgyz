using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Interrogative;

namespace OpenKyrgyz.Core.Tenses.WithDifferentNegative.PastUsedTo;

public class PastUsedToConjugator
{
    public static string Conjugate(
        string verb,
        PronounEnum pronoun,
        VerbFormEnum form)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;

        if (pronoun == PronounEnum.Алар)
            return ConjugateForАлар(verb, form);


        if (form is VerbFormEnum.Negative or VerbFormEnum.NegativeAndInterrogative)
        {
            verb += PastUsedToEnding.GetPastUsedToEnding(verb);
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
        var ending = PastUsedToEnding.GetEnding(verb, pronoun);

        return $"{verb}{ending}";
    }

    private static string ConjugateForАлар(string verb, VerbFormEnum form)
    {
        var lastLetterType = verb.GetLastLetterType();
        if (lastLetterType is not LetterTypeEnum.Vowel)
        {
            var vowelGroup = verb.GetVowelGroup();
            var linkingLetter = LinkingLetterForAlarCase[vowelGroup];
            verb = verb.HarmonizeEndingIfNecessary();
            verb += linkingLetter;
        }

        var ending = PastUsedToEnding.GetEnding(verb, PronounEnum.Алар);
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

    private static readonly Dictionary<VowelGroupEnum, char> LinkingLetterForAlarCase = new()
    {
        { VowelGroupEnum.а_я_ы, 'ы' },
        { VowelGroupEnum.у_ю, 'у' },
        { VowelGroupEnum.и_е_э, 'и' },
        { VowelGroupEnum.о_ё, 'у' },
        { VowelGroupEnum.ө_ү, 'ү' },
    };
}