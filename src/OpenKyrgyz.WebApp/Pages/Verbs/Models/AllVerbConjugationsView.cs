using OpenKyrgyz.Core.Models.Verbs;

namespace OpenKyrgyz.WebApp.Pages.Verbs.Models;

public class AllVerbConjugationsView
{
    public VerbConjugationTableViewModel? PresentAndFutureConjugations { get; set; }
    public VerbConjugationTableViewModel? FutureProbableConjugations { get; set; }
    public VerbConjugationTableViewModel? FutureGoingToConjugations { get; set; }
    public VerbConjugationTableViewModel? PresentContinuousConjugations { get; set; }

    public VerbConjugationTableViewModel? PastDefiniteConjugations { get; set; }
    public VerbConjugationTableViewModel? PastIndefiniteConjugations { get; set; }
    public VerbConjugationTableViewModel? PastUsedToConjugations { get; set; }
    public VerbConjugationTableViewModel? PastSuddenConjugations { get; set; }

    public VerbConjugationTableViewModel? ConditionalConjugations { get; set; }
    public VerbConjugationTableViewModel? IntentionConjugations { get; set; }

    public VerbImperativesTableViewModel? ImperativeConjugations { get; set; }

    public VerbConjugatedInOptativeMood OptativeMood { get; set; }

    public static AllVerbConjugationsView From(VerbConjugationsAllTenses conjugations)
    {
        var result = new AllVerbConjugationsView
        {
            PresentAndFutureConjugations = new VerbConjugationTableViewModel
            {
                TenseName = "Настоящее и будущее определенное время (Учур жана айкын келер чак)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.PresentAndFutureSimple),
            },
            PresentContinuousConjugations = new VerbConjugationTableViewModel
            {
                TenseName = "Настоящее сложное время (Татаал учур чак)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.PresentContinuous),
            },
            FutureGoingToConjugations = new VerbConjugationTableViewModel
            {
                TenseName = "Будущее сложное время (Татаал келер чак)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.FutureGoingTo),
            },
            FutureProbableConjugations = new VerbConjugationTableViewModel
            {
                TenseName = "Будущее возможное время (Арсар келер чак)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.FutureProbable),
            },
            PastDefiniteConjugations = new VerbConjugationTableViewModel
            {
                TenseName = "Прошедшее определенное время (Айкын өткөн чак)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.PastDefinite),
            },
            PastIndefiniteConjugations = new VerbConjugationTableViewModel
            {
                TenseName = "Прошедшее неопределенное время (Жалпы өткөн чак)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.PastIndefinite),
            },
            PastSuddenConjugations = new VerbConjugationTableViewModel
            {
                TenseName = "Прошедшее неожиданное время (Капыскы өткөн чак)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.PastSudden),
            },
            PastUsedToConjugations = new VerbConjugationTableViewModel
            {
                TenseName = "Прошедшее многократное время (Адат өткөн чак)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.PastUsedTo),
            },
            ConditionalConjugations = new VerbConjugationTableViewModel
            {
                TenseName = "Условное наклонение (Шарттуу ыңгай)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.Conditional),
            },
            IntentionConjugations = new VerbConjugationTableViewModel
            {
                TenseName = "Наклонение намерения (Максат ыңгай)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.Intention),
            },
            ImperativeConjugations = new VerbImperativesTableViewModel
            {
                Positive = conjugations.ImperativePositive,
                Negative = conjugations.ImperativeNegative,
            },
            OptativeMood = conjugations.OptativeMood,
        };

        return result;
    }
}