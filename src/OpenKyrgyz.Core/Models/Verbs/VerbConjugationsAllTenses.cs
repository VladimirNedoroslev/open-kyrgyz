namespace OpenKyrgyz.Core.Models.Verbs;

public class VerbConjugationsAllTenses
{
    public required string Verb { get; set; }

    public required VerbConjugatedByAllForms PresentAndFutureSimple { get; set; }
    public required VerbConjugatedByAllForms PresentContinuous { get; set; }
    public required VerbConjugatedByAllForms FutureGoingTo { get; set; }
    public required VerbConjugatedByAllForms FutureProbable { get; set; }

    public required VerbConjugatedByAllForms PastDefinite { get; set; }
    public required VerbConjugatedByAllForms PastIndefinite { get; set; }
    public required VerbConjugatedByAllForms PastUsedTo { get; set; }
    public required VerbConjugatedByAllForms PastSudden { get; set; }

    public required VerbConjugatedByAllForms Conditional { get; set; }
    public required VerbConjugatedByAllForms Intention { get; set; }

    public required VerbConjugationsImperative ImperativePositive { get; set; }
    public required VerbConjugationsImperative ImperativeNegative { get; set; }

    public required VerbConjugatedInOptativeMood OptativeMood { get; set; }
}