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

    [BindProperty] public string? InputVerb { get; set; }

    public VerbConjugationTableView? PresentAndFutureConjugations { get; set; }
    public VerbConjugationTableView? FutureProbableConjugations { get; set; }

    public VerbConjugationTableView? PastDefiniteConjugations { get; set; }
    public VerbConjugationTableView? PastIndefiniteConjugations { get; set; }
    public VerbConjugationTableView? PastUsedToConjugations { get; set; }
    public VerbConjugationTableView? PastSuddenConjugations { get; set; }

    public VerbConjugationTableView? ConditionalConjugations { get; set; }
    public VerbConjugationTableView? IntentionConjugations { get; set; }

    public VerbImperativesTableView? ImperativeConjugations { get; set; }


    public void OnPost()
    {
        if (!string.IsNullOrWhiteSpace(InputVerb))
        {
            var verbConjugationsAllTenses = _conjugator.ConjugateByAllTenses(InputVerb);
            PresentAndFutureConjugations = new VerbConjugationTableView()
            {
                TenseName = "Настоящее и будущее время",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.PresentAndFutureSimple),
            };
            FutureProbableConjugations = new VerbConjugationTableView()
            {
                TenseName = "Будущее возможное время",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.FutureProbable),
            };
            PastDefiniteConjugations = new VerbConjugationTableView()
            {
                TenseName = "Прошлое определенное время",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.PastDefinite),
            };
            PastIndefiniteConjugations = new VerbConjugationTableView()
            {
                TenseName = "Прошлое неопределенное время",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.PastIndefinite),
            };
            PastSuddenConjugations = new VerbConjugationTableView()
            {
                TenseName = "Прошлое внезапное время",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.PastSudden),
            };
            PastUsedToConjugations = new VerbConjugationTableView()
            {
                TenseName = "Прошлое многократное время",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.PastUsedTo),
            };
            ConditionalConjugations = new VerbConjugationTableView()
            {
                TenseName = "Условное наклонение",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.Conditional),
            };
            IntentionConjugations = new VerbConjugationTableView()
            {
                TenseName = "Наклонение намерения",
                VerbConjugatedByPronouns = VerbConjugatedByPronounDto.MapToTableView(verbConjugationsAllTenses.Intention),
            };
            ImperativeConjugations = new VerbImperativesTableView()
            {
                Positive = verbConjugationsAllTenses.ImperativePositive,
                Negative = verbConjugationsAllTenses.ImperativeNegative,
            };
        }
    }
}