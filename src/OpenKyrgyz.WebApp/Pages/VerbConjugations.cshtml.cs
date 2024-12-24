using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Forms.Noun;
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

    public AllVerbConjugationsView AllConjugations { get; set; }
    public AllVerbForms AllVerbForms { get; set; }


    public void OnGet()
    {
        if (string.IsNullOrWhiteSpace(Verb)) return;
        
        if (NounForm.IsInNounForm(Verb))
            Verb = NounForm.GetVerbFromNounForm(Verb);
        
        var verbConjugationsAllTenses = _conjugator.ConjugateByAllTenses(Verb);
        AllConjugations = AllVerbConjugationsView.From(verbConjugationsAllTenses);
        AllVerbForms = _conjugator.GetAllVerbForms(Verb);
    }
}