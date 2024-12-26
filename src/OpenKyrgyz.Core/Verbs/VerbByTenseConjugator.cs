using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Models.Verbs;
using OpenKyrgyz.Core.Verbs.Forms;
using OpenKyrgyz.Core.Verbs.Tenses.Conditional;
using OpenKyrgyz.Core.Verbs.Tenses.FutureGoingTo;
using OpenKyrgyz.Core.Verbs.Tenses.FutureProbable;
using OpenKyrgyz.Core.Verbs.Tenses.Imperative;
using OpenKyrgyz.Core.Verbs.Tenses.PastDefinite;
using OpenKyrgyz.Core.Verbs.Tenses.PastSudden;
using OpenKyrgyz.Core.Verbs.Tenses.PresentAndFutureSimple;
using OpenKyrgyz.Core.Verbs.Tenses.PresentContinuous;
using OpenKyrgyz.Core.Verbs.Tenses.WithDifferentNegative.Intention;
using OpenKyrgyz.Core.Verbs.Tenses.WithDifferentNegative.PastIndefinite;
using OpenKyrgyz.Core.Verbs.Tenses.WithDifferentNegative.PastUsedTo;

namespace OpenKyrgyz.Core.Verbs;

public class VerbByTenseConjugator
{
    public VerbConjugationsAllTenses ConjugateByAllTenses(string verb)
    {
        if (NounForm.IsInNounForm(verb))
            verb = NounForm.GetVerbFromNounForm(verb);

        var result = new VerbConjugationsAllTenses
        {
            Verb = verb,
            PresentAndFutureSimple = Conjugate(verb, TenseEnum.PresentAndFuture),
            PresentContinuous = Conjugate(verb, TenseEnum.PresentContinuous),
            FutureGoingTo = Conjugate(verb, TenseEnum.FutureGoingTo),
            FutureProbable = Conjugate(verb, TenseEnum.FutureProbable),
            PastDefinite = Conjugate(verb, TenseEnum.PastDefinite),
            PastIndefinite = Conjugate(verb, TenseEnum.PastIndefinite),
            PastSudden = Conjugate(verb, TenseEnum.PastSudden),
            PastUsedTo = Conjugate(verb, TenseEnum.PastUsedTo),
            Conditional = Conjugate(verb, TenseEnum.Conditional),
            Intention = Conjugate(verb, TenseEnum.Intention),
            ImperativePositive = ConjugateImperativePositive(verb),
            ImperativeNegative = ConjugateImperativeNegative(verb),
            OptativeMood = new VerbConjugatedInOptativeMood(verb),
        };
        return result;
    }

    public AllVerbForms GetAllVerbForms(string verb)
    {
        var result = new AllVerbForms(verb);
        return result;
    }

    public AllCompositeVerbForms GetAllCompositeVerbForms(string verb)
    {
        return new AllCompositeVerbForms(verb);
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
            TenseEnum.PresentContinuous => PresentContinuousConjugator.Conjugate,
            TenseEnum.FutureProbable => FutureProbableConjugator.Conjugate,
            TenseEnum.FutureGoingTo => FutureGoingToConjugator.Conjugate,
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