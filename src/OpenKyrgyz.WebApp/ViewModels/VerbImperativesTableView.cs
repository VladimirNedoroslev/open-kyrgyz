using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Models;

namespace OpenKyrgyz.WebApp.ViewModels;

public class VerbImperativesTableView
{
    public required VerbConjugationsImperative Positive { get; set; }
    public required VerbConjugationsImperative Negative { get; set; }
}