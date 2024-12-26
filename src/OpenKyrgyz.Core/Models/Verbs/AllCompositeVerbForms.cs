using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Models.Verbs;

public class AllCompositeVerbForms
{
    public string Verb { get; private set; }
    public VerbInCompositeForm AsSoonAs { get; private set; }

    public VerbInCompositeForm AlthoughPositive { get; private set; }
    public VerbInCompositeForm AlthoughNegative { get; private set; }


    public VerbInCompositeForm DespitePositive { get; private set; }
    public VerbInCompositeForm DespiteNegative { get; private set; }

    public VerbInCompositeForm CausePositive { get; private set; }
    public VerbInCompositeForm CauseNegative { get; private set; }


    public AllCompositeVerbForms(string verb)
    {
        Verb = verb;
        AsSoonAs = VerbInCompositeForm.GetAsSoonAsForm(verb);

        AlthoughPositive = VerbInCompositeForm.GetAlthoughForm(verb, VerbFormEnum.Positive);
        AlthoughNegative = VerbInCompositeForm.GetAlthoughForm(verb, VerbFormEnum.Negative);

        DespitePositive = VerbInCompositeForm.GetDespiteForm(verb, VerbFormEnum.Positive);
        DespiteNegative = VerbInCompositeForm.GetDespiteForm(verb, VerbFormEnum.Negative);

        CausePositive = VerbInCompositeForm.GetCauseForm(verb, VerbFormEnum.Positive);
        CauseNegative = VerbInCompositeForm.GetCauseForm(verb, VerbFormEnum.Negative);
    }
}