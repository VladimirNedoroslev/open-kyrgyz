using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.Conditional;
using OpenKyrgyz.Core.Tenses.FutureProbable;
using OpenKyrgyz.Core.Tenses.PastDefinite;
using OpenKyrgyz.Core.Tenses.PastIndefinite;
using OpenKyrgyz.Core.Tenses.PastSudden;
using OpenKyrgyz.Core.Tenses.PastUsedTo;
using OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

namespace OpenKyrgyz.Core.Tenses;

public class VerbByTenseConjugator
{
    public VerbConjugationsAllTenses ConjugateByAllTenses(string verb)
    {
        var result = new VerbConjugationsAllTenses()
        {
            Verb = verb,
            Conditional = Conjugate(verb, TenseEnum.Conditional),
            PresentAndFutureSimple = Conjugate(verb, TenseEnum.PresentAndFuture),
            FutureProbable = Conjugate(verb, TenseEnum.FutureProbable),
            PastDefinite = Conjugate(verb, TenseEnum.PastDefinite),
            PastIndefinite = Conjugate(verb, TenseEnum.PastIndefinite),
            PastSudden = Conjugate(verb, TenseEnum.PastSudden),
            PastUsedTo = Conjugate(verb, TenseEnum.PastUsedTo),
        };
        return result;
    }

    public VerbConjugatedByAllForms Conjugate(string verb, TenseEnum tense)
    {
        Func<string, PronounEnum, VerbFormEnum, string> tenseConjugatorFunc = tense switch
        {
            TenseEnum.PresentAndFuture => PresentAndFutureSimpleTenseConjugator.Conjugate,
            TenseEnum.PresentContinuous => throw new NotImplementedException(),
            TenseEnum.FutureProbable => FutureProbableTenseConjugator.Conjugate,
            TenseEnum.FutureGoingTo => throw new NotImplementedException(),
            TenseEnum.PastDefinite => PastDefiniteTenseConjugator.Conjugate,
            TenseEnum.PastIndefinite => PastIndefiniteTenseConjugator.Conjugate,
            TenseEnum.PastUsedTo => PastUsedToConjugate.Conjugate,
            TenseEnum.PastSudden => PastSuddenTenseConjugator.Conjugate,
            TenseEnum.Conditional => ConditionalTenseConjugator.Conjugate,
            TenseEnum.SecondConditional => throw new NotImplementedException(),
            _ => throw new ArgumentOutOfRangeException(nameof(tense), tense, null)
        };

        var positive = ConjugateByTenseInternal(verb, tenseConjugatorFunc, VerbFormEnum.Positive, tense);
        var negative = ConjugateByTenseInternal(verb, tenseConjugatorFunc, VerbFormEnum.Negative, tense);
        var interrogative = ConjugateByTenseInternal(verb, tenseConjugatorFunc, VerbFormEnum.Interrogative, tense);
        var negativeInterrogative = ConjugateByTenseInternal(verb, tenseConjugatorFunc, VerbFormEnum.NegativeAndInterrogative, tense);

        return new VerbConjugatedByAllForms(positive, negative, interrogative, negativeInterrogative);
    }

    private static VerbConjugationsByTense ConjugateByTenseInternal(
        string verb,
        Func<string, PronounEnum, VerbFormEnum, string> tenseConjugatorFunc,
        VerbFormEnum form,
        TenseEnum tense)
    {
        var мен = tenseConjugatorFunc(verb, PronounEnum.Мен, form);
        var сен = tenseConjugatorFunc(verb, PronounEnum.Сен, form);
        var сиз = tenseConjugatorFunc(verb, PronounEnum.Сиз, form);
        var ал = tenseConjugatorFunc(verb, PronounEnum.Ал, form);
        var биз = tenseConjugatorFunc(verb, PronounEnum.Биз, form);
        var силер = tenseConjugatorFunc(verb, PronounEnum.Силер, form);
        var сиздер = tenseConjugatorFunc(verb, PronounEnum.Сиздер, form);
        var алар = tenseConjugatorFunc(verb, PronounEnum.Алар, form);
        var result = new VerbConjugationsByTense(verb, мен, сен, сиз, ал, биз, силер, сиздер, алар, form, tense);
        return result;
    }
}