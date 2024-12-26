using OpenKyrgyz.Core.Models.Verbs;

namespace OpenKyrgyz.WebApp.Pages.Verbs.Models;

public class AllCompositeVerbFormsViewModel
{
    public VerbCompositeFormTableViewModel DespiteFormTableViewModel { get; set; }
    public VerbCompositeFormTableViewModel AlthoughFormTableViewModel { get; set; }
    public VerbCompositeFormTableViewModel CauseFormTableViewModel { get; set; }
    public VerbCompositeFormTableViewModel AsSoonAsFormTableViewModel { get; set; }

    public AllCompositeVerbFormsViewModel(AllCompositeVerbForms allCompositeVerbForms)
    {
        AsSoonAsFormTableViewModel = new VerbCompositeFormTableViewModel()
        {
            FormName = "Форма \"как только ...\"",
            PositiveForm = allCompositeVerbForms.AsSoonAs,
            NegativeForm = null,
        };

        DespiteFormTableViewModel = new VerbCompositeFormTableViewModel()
        {
            FormName = "Форма \"не смотря на ... \"",
            PositiveForm = allCompositeVerbForms.DespitePositive,
            NegativeForm = allCompositeVerbForms.DespiteNegative,
        };

        AlthoughFormTableViewModel = new VerbCompositeFormTableViewModel()
        {
            FormName = "Форма \"хотя ... \"",
            PositiveForm = allCompositeVerbForms.AlthoughPositive,
            NegativeForm = allCompositeVerbForms.AlthoughNegative,
        };

        CauseFormTableViewModel = new VerbCompositeFormTableViewModel()
        {
            FormName = "Форма выражения причины",
            PositiveForm = allCompositeVerbForms.CausePositive,
            NegativeForm = allCompositeVerbForms.CauseNegative,
        };
    }
}