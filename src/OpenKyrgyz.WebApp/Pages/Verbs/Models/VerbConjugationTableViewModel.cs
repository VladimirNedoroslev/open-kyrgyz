namespace OpenKyrgyz.WebApp.Pages.Verbs.Models;

public class VerbConjugationTableViewModel
{
    public required string TenseName { get; set; }
    public required List<VerbConjugatedByPronounDto> VerbConjugatedByPronouns { get; set; }
}