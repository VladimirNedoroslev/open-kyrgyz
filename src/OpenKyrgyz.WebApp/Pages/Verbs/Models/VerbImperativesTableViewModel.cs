using OpenKyrgyz.Core.Models.Verbs;

namespace OpenKyrgyz.WebApp.Pages.Verbs.Models;

public class VerbImperativesTableViewModel
{
    public required VerbConjugationsImperative Positive { get; set; }
    public required VerbConjugationsImperative Negative { get; set; }
}