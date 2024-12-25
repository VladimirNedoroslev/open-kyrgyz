using OpenKyrgyz.Core.Models;

namespace OpenKyrgyz.WebApp.ViewModels;

public class AllVerbConjugationsView
{
    
    public VerbConjugationTableView? PresentAndFutureConjugations { get; set; }
    public VerbConjugationTableView? FutureProbableConjugations { get; set; }
    public VerbConjugationTableView? FutureGoingToConjugations { get; set; }
    public VerbConjugationTableView? PresentContinuousConjugations { get; set; }

    public VerbConjugationTableView? PastDefiniteConjugations { get; set; }
    public VerbConjugationTableView? PastIndefiniteConjugations { get; set; }
    public VerbConjugationTableView? PastUsedToConjugations { get; set; }
    public VerbConjugationTableView? PastSuddenConjugations { get; set; }

    public VerbConjugationTableView? ConditionalConjugations { get; set; }
    public VerbConjugationTableView? IntentionConjugations { get; set; }

    public VerbImperativesTableView? ImperativeConjugations { get; set; }
    
    public VerbConjugatedInOptativeMood OptativeMood { get; set; }

    public static AllVerbConjugationsView From(VerbConjugationsAllTenses conjugations)
    {
        var result = new AllVerbConjugationsView
        {
            PresentAndFutureConjugations = new VerbConjugationTableView
            {
                TenseName = "Настоящее и будущее определенное время (Учур жана айкын келер чак)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.PresentAndFutureSimple),
            },
            PresentContinuousConjugations = new VerbConjugationTableView
            {
                TenseName = "Настоящее сложное время (Татаал учур чак)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.PresentContinuous),
            },
            FutureGoingToConjugations = new VerbConjugationTableView
            {
                TenseName = "Будущее сложное время (Татаал келер чак)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.FutureGoingTo),
            },
            FutureProbableConjugations = new VerbConjugationTableView
            {
                TenseName = "Будущее возможное время (Арсар келер чак)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.FutureProbable),
            },
            PastDefiniteConjugations = new VerbConjugationTableView
            {
                TenseName = "Прошедшее определенное время (Айкын өткөн чак)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.PastDefinite),
            },
            PastIndefiniteConjugations = new VerbConjugationTableView
            {
                TenseName = "Прошедшее неопределенное время (Жалпы өткөн чак)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.PastIndefinite),
            },
            PastSuddenConjugations = new VerbConjugationTableView
            {
                TenseName = "Прошедшее неожиданное время (Капыскы өткөн чак)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.PastSudden),
            },
            PastUsedToConjugations = new VerbConjugationTableView
            {
                TenseName = "Прошедшее многократное время (Адат өткөн чак)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.PastUsedTo),
            },
            ConditionalConjugations = new VerbConjugationTableView
            {
                TenseName = "Условное наклонение (Шарттуу ыңгай)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.Conditional),
            },
            IntentionConjugations = new VerbConjugationTableView
            {
                TenseName = "Наклонение намерения (Максат ыңгай)",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(conjugations.Intention),
            },
            ImperativeConjugations = new VerbImperativesTableView
            {
                Positive = conjugations.ImperativePositive,
                Negative = conjugations.ImperativeNegative,
            },
            OptativeMood = conjugations.OptativeMood,
        };

        return result;
    }
}