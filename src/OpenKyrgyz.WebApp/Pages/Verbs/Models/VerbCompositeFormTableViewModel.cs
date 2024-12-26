using OpenKyrgyz.Core.Models.Verbs;

namespace OpenKyrgyz.WebApp.Pages.Verbs.Models;

public class VerbCompositeFormTableViewModel
{
    public required string FormName { get; set; }
    public VerbInCompositeForm PositiveForm { get; set; }
    public VerbInCompositeForm? NegativeForm { get; set; }
}