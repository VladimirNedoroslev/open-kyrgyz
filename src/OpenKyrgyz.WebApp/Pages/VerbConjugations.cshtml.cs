using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OpenKyrgyz.Core.Tenses;
using OpenKyrgyz.WebApp.ViewModels;

namespace OpenKyrgyz.WebApp.Pages;

public class VerbConjugationsPage : PageModel
{
    private readonly VerbByTenseConjugator _conjugator;

    public VerbConjugationsPage(VerbByTenseConjugator conjugator)
    {
        _conjugator = conjugator;
    }

    [BindProperty(SupportsGet = true)] public string Verb { get; set; }

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


    public void OnGet()
    {
        if (string.IsNullOrWhiteSpace(Verb)) return;
        var verbConjugationsAllTenses = _conjugator.ConjugateByAllTenses(Verb);
        PresentAndFutureConjugations = new VerbConjugationTableView
        {
            TenseName = "Настоящее и будущее определенное время (Учур жана айкын келер чак)",
            VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.PresentAndFutureSimple),
        };

        PresentContinuousConjugations = new VerbConjugationTableView
        {
            TenseName = "Настоящее сложное время (Татаал учур чак)",
            VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.PresentContinuous),
        };

        FutureGoingToConjugations =  new VerbConjugationTableView
        {
            TenseName = "Будущее сложное время (Татаал келер чак)",
            VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.FutureGoingTo),
        };
        
        FutureProbableConjugations = new VerbConjugationTableView
        {
            TenseName = "Будущее возможное время (Арсар келер чак)",
            VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.FutureProbable),
        };
        PastDefiniteConjugations = new VerbConjugationTableView
        {
            TenseName = "Прошедшее определенное время (Айкын өткөн чак)",
            VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.PastDefinite),
        };
        PastIndefiniteConjugations = new VerbConjugationTableView
        {
            TenseName = "Прошедшее неопределенное время (Жалпы өткөн чак)",
            VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.PastIndefinite),
        };
        PastSuddenConjugations = new VerbConjugationTableView
        {
            TenseName = "Прошедшее неожиданное время (Капыскы өткөн чак)",
            VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.PastSudden),
        };
        PastUsedToConjugations = new VerbConjugationTableView
        {
            TenseName = "Прошедшее многократное время (Адат өткөн чак)",
            VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.PastUsedTo),
        };
        ConditionalConjugations = new VerbConjugationTableView
        {
            TenseName = "Условное наклонение (Шарттуу ыңгай)",
            VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.Conditional),
        };
        IntentionConjugations = new VerbConjugationTableView
        {
            TenseName = "Наклонение намерения (Максат ыңгай)",
            VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.Intention),
        };
        ImperativeConjugations = new VerbImperativesTableView
        {
            Positive = verbConjugationsAllTenses.ImperativePositive,
            Negative = verbConjugationsAllTenses.ImperativeNegative,
        };
    }
}