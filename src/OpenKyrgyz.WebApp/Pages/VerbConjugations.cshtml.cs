using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Forms;
using OpenKyrgyz.Core.Models;
using OpenKyrgyz.Core.Tenses;
using OpenKyrgyz.WebApp.ViewModels;

namespace OpenKyrgyz.WebApp.Pages;

public class VerbConjugationsPage : PageModel
{
    private readonly VerbByTenseConjugator _conjugator;
    private static readonly Regex OnlyConsonantsRegex = LetterTypeMapping.OnlyConsonantsRegex();

    public VerbConjugationsPage(VerbByTenseConjugator conjugator)
    {
        _conjugator = conjugator;
    }

    [BindProperty(SupportsGet = true)]
    [Required]
    [RegularExpression(LetterTypeMapping.KyrgyzAlphabetLettersRegex, ErrorMessage = "Используйте только буквы из кыргызского алфавита")]
    [MinLength(2, ErrorMessage = "Минимальная длина глагола 2")]
    [MaxLength(30, ErrorMessage = "Максимальная длина глагола 30")]
    public string Verb { get; set; }

    public AllVerbConjugationsView AllConjugations { get; set; }
    public AllVerbForms AllVerbForms { get; set; }
    

    
    public IActionResult OnGet()
    {
        if (!string.IsNullOrWhiteSpace(Verb))
        {
            if (OnlyConsonantsRegex.IsMatch(Verb))
            {
                ModelState.AddModelError("onlyConsonants", "Глагол не может состоять только из согласных");
            }
        }
        if (!ModelState.IsValid)
        {
            TempData["ErrorMessage"] = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            return RedirectToPage("/VerbConjugationsInput");
        }

        Verb = Verb.Trim().ToLower();
        if (NounForm.IsInNounForm(Verb))
            Verb = NounForm.GetVerbFromNounForm(Verb);

        var verbConjugationsAllTenses = _conjugator.ConjugateByAllTenses(Verb);
        AllConjugations = AllVerbConjugationsView.From(verbConjugationsAllTenses);
        AllVerbForms = _conjugator.GetAllVerbForms(Verb);
        return Page();
    }
    
    public IActionResult OnPost(string verb)
    {
        if (!string.IsNullOrWhiteSpace(Verb))
        {
            if (OnlyConsonantsRegex.IsMatch(Verb))
            {
                ModelState.AddModelError("onlyConsonants", "Глагол не может состоять только из согласных");
            }
        }
        if (!ModelState.IsValid)
        {
            TempData["ErrorMessage"] = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            return RedirectToPage("VerbConjugationsInput");
        }
        return RedirectToPage(new {verb});
    }
    
}