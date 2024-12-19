namespace OpenKyrgyz.WebApp.ViewModels;

public class VerbConjugationTableView
{
    public string TenseName { get; set; }
    public List<VerbConjugatedByPronounDto> VerbConjugatedByPronouns { get; set; }
}