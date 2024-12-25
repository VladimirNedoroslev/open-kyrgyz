using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OpenKyrgyz.Core.Core;

namespace OpenKyrgyz.WebApp.Pages.Nouns;

[ResponseCache(Duration = 30, Location = ResponseCacheLocation.Any)]
public class NounCasesPage : PageModel
{
    private static readonly Regex OnlyConsonantsRegex = LetterTypeMapping.OnlyConsonantsRegex();

    public NounCasesPage()
    {
    }

    [BindProperty(SupportsGet = true)]
    [Required]
    [RegularExpression(LetterTypeMapping.KyrgyzAlphabetLettersRegex, ErrorMessage = "Используйте только буквы из кыргызского алфавита")]
    [MinLength(2, ErrorMessage = "Минимальная длина слова 2")]
    [MaxLength(30, ErrorMessage = "Максимальная длина слова 100")]
    public string Word { get; set; }


    public IActionResult OnGet()
    {
        return Page();
    }

    public IActionResult OnPost(string verb)
    {
        if (!string.IsNullOrWhiteSpace(Word))
        {
            if (OnlyConsonantsRegex.IsMatch(Word))
            {
                ModelState.AddModelError("onlyConsonants", "Глагол не может состоять только из согласных");
            }
        }

        if (!ModelState.IsValid)
        {
            TempData["ErrorMessage"] = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            return RedirectToPage("NounCasesInput");
        }

        return RedirectToPage(new { verb });
    }
}