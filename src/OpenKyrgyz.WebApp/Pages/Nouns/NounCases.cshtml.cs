using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Core;
using OpenKyrgyz.WebApp.Pages.Nouns.Models;

namespace OpenKyrgyz.WebApp.Pages.Nouns;

public class NounCasesPage : PageModel
{
    private static readonly Regex OnlyConsonantsRegex = LetterTypeMapping.OnlyConsonantsRegex();

    private readonly NounDecliner _nounDecliner;

    public NounCasesPage(NounDecliner nounDecliner)
    {
        _nounDecliner = nounDecliner;
    }

    [BindProperty(SupportsGet = true)]
    [Required]
    [RegularExpression(LetterTypeMapping.KyrgyzAlphabetLettersRegex, ErrorMessage = "Используйте только буквы из кыргызского алфавита")]
    [MinLength(2, ErrorMessage = "Минимальная длина слова 2")]
    [MaxLength(100, ErrorMessage = "Максимальная длина слова 100")]
    public string Noun { get; set; }


    public NounDeclinedInAllCasesTable NounDeclinedInAllCasesTable { get; set; }
    public NounDeclinedInAllCasesWithPossessiveViewModel Singular { get; set; }
    public NounDeclinedInAllCasesWithPossessiveViewModel Plural { get; set; }
    
    public string NounInИликCase { get; set; }

    public IActionResult OnGet()
    {
        if (!string.IsNullOrWhiteSpace(Noun))
        {
            if (OnlyConsonantsRegex.IsMatch(Noun))
            {
                ModelState.AddModelError("onlyConsonants", "Слово не может состоять только из согласных");
            }
        }

        if (!ModelState.IsValid)
        {
            TempData["ErrorMessage"] = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            return RedirectToPage("/Nouns/NounCasesInput");
        }
        
        Noun = Noun.Trim().ToLower();

        var allNounDeclensionsSingular = _nounDecliner.GetAllNounDeclensions(Noun);
        var allNounDeclensionsPlural = _nounDecliner.GetAllNounDeclensions(Noun, true);

        NounDeclinedInAllCasesTable = new NounDeclinedInAllCasesTable()
        {
            Singular = new NounDeclinedInAllCasesViewModel(allNounDeclensionsSingular.WithoutPossessive, null),
            Plural = new NounDeclinedInAllCasesViewModel(allNounDeclensionsPlural.WithoutPossessive, null),
        };
        Singular = new NounDeclinedInAllCasesWithPossessiveViewModel("Склонения по падежам с притяжательными формами (ед. ч.)", allNounDeclensionsSingular);
        Plural = new NounDeclinedInAllCasesWithPossessiveViewModel("Склонения по падежам с притяжательными формами (мн. ч.)", allNounDeclensionsPlural);


        NounInИликCase = ИликCase.Decline(Noun, null, null);
        return Page();
    }

    public IActionResult OnPost(string noun)
    {
        if (!string.IsNullOrWhiteSpace(Noun))
        {
            if (OnlyConsonantsRegex.IsMatch(Noun))
            {
                ModelState.AddModelError("onlyConsonants", "Слово не может состоять только из согласных");
            }
        }

        if (!ModelState.IsValid)
        {
            TempData["ErrorMessage"] = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            return RedirectToPage("/Nouns/NounCasesInput");
        }

        return RedirectToPage(new { noun });
    }
}