namespace OpenKyrgyz.Core.Models.Verbs;

public class VerbConjugatedByAllForms
{
    public VerbConjugationsByTense Positive { get; }
    public VerbConjugationsByTense Negative { get; }
    public VerbConjugationsByTense Interrogative { get; }
    public VerbConjugationsByTense NegativeInterrogative { get; }

    public VerbConjugatedByAllForms(
        VerbConjugationsByTense positive,
        VerbConjugationsByTense negative,
        VerbConjugationsByTense interrogative,
        VerbConjugationsByTense negativeInterrogative
    )
    {
        Positive = positive ?? throw new ArgumentNullException(nameof(positive));
        Negative = negative ?? throw new ArgumentNullException(nameof(negative));
        Interrogative = interrogative ?? throw new ArgumentNullException(nameof(interrogative));
        NegativeInterrogative = negativeInterrogative ?? throw new ArgumentNullException(nameof(negativeInterrogative));
    }
}