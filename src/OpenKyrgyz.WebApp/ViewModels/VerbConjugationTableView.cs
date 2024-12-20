namespace OpenKyrgyz.WebApp.ViewModels;

public class VerbConjugationTableView
{
    public required string TenseName { get; set; }
    public required List<VerbConjugatedByPronounDto> VerbConjugatedByPronouns { get; set; }
}