using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.Conditional;
using OpenKyrgyz.Core.Tenses.FutureProbable;
using OpenKyrgyz.Core.Tenses.Imperative;
using OpenKyrgyz.Core.Tenses.PastDefinite;
using OpenKyrgyz.Core.Tenses.PastSudden;
using OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;
using OpenKyrgyz.Core.Tenses.WithDifferentNegative.Intention;
using OpenKyrgyz.Core.Tenses.WithDifferentNegative.PastIndefinite;
using OpenKyrgyz.Core.Tenses.WithDifferentNegative.PastUsedTo;

namespace OpenKyrgyz.Core.Tenses;

public class VerbByTenseConjugator
{
    public VerbConjugationsAllTenses ConjugateByAllTenses(string verb)
    {
        var result = new VerbConjugationsAllTenses()
        {
            Verb = verb,
            PresentAndFutureSimple = Conjugate(verb, TenseEnum.PresentAndFuture),
            FutureProbable = Conjugate(verb, TenseEnum.FutureProbable),
            PastDefinite = Conjugate(verb, TenseEnum.PastDefinite),
            PastIndefinite = Conjugate(verb, TenseEnum.PastIndefinite),
            PastSudden = Conjugate(verb, TenseEnum.PastSudden),
            PastUsedTo = Conjugate(verb, TenseEnum.PastUsedTo),
            Conditional = Conjugate(verb, TenseEnum.Conditional),
            Intention = Conjugate(verb, TenseEnum.Intention),
            ImperativePositive = ConjugateImperativePositive(verb),
            ImperativeNegative = ConjugateImperativeNegative(verb),
        };
        return result;
    }

    private static VerbConjugationsImperative ConjugateImperativePositive(string verb)
    {
        var сен = ImperativeСен.ConjugatePositive(verb);
        var сенPolite = ImperativeСенPolite.ConjugatePositive(verb);
        var сенOrder = ImperativeСенOrder.ConjugatePositive(verb);
        var силер = ImperativeСилер.ConjugatePositive(verb);
        var сиз = ImperativeСиз.ConjugatePositive(verb);
        var сиздер = ImperativeСиздер.ConjugatePositive(verb);
        var ал = ImperativeАл.ConjugatePositive(verb);
        var алар = ImperativeАлар.ConjugatePositive(verb);
        return new VerbConjugationsImperative(verb, сен, сенPolite, сенOrder, сиз, ал, силер, сиздер, алар);
    }

    private static VerbConjugationsImperative ConjugateImperativeNegative(string verb)
    {
        var сен = ImperativeСен.ConjugateNegative(verb);
        var сенPolite = ImperativeСенPolite.ConjugateNegative(verb);
        var сенOrder = ImperativeСенOrder.ConjugateNegative(verb);
        var силер = ImperativeСилер.ConjugateNegative(verb);
        var сиз = ImperativeСиз.ConjugateNegative(verb);
        var сиздер = ImperativeСиздер.ConjugateNegative(verb);
        var ал = ImperativeАл.ConjugateNegative(verb);
        var алар = ImperativeАлар.ConjugateNegative(verb);
        return new VerbConjugationsImperative(verb, сен, сенPolite, сенOrder, сиз, ал, силер, сиздер, алар);
    }

    private static VerbConjugatedByAllForms Conjugate(string verb, TenseEnum tense)
    {
        Func<string, PronounEnum, VerbFormEnum, string> tenseConjugatorFunc = tense switch
        {
            TenseEnum.PresentAndFuture => PresentAndFutureSimpleConjugator.Conjugate,
            TenseEnum.PresentContinuous => throw new NotImplementedException(),
            TenseEnum.FutureProbable => FutureProbableConjugator.Conjugate,
            TenseEnum.FutureGoingTo => throw new NotImplementedException(),
            TenseEnum.PastDefinite => PastDefiniteTenseConjugator.Conjugate,
            TenseEnum.PastIndefinite => PastIndefiniteConjugator.Conjugate,
            TenseEnum.PastUsedTo => PastUsedToConjugator.Conjugate,
            TenseEnum.PastSudden => PastSuddenConjugator.Conjugate,
            TenseEnum.Conditional => ConditionalConjugator.Conjugate,
            TenseEnum.Intention => IntentionConjugator.Conjugate,
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