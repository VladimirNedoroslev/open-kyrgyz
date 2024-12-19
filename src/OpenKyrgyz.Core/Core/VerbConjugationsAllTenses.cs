using OpenKyrgyz.Core.Tenses.Imperative;

namespace OpenKyrgyz.Core.Core;

public class VerbConjugationsAllTenses
{
    public string Verb { get; set; }

    public VerbConjugatedByAllForms PresentAndFutureSimple { get; set; }
    public VerbConjugatedByAllForms FutureProbable { get; set; }
    public VerbConjugatedByAllForms PastDefinite { get; set; }
    public VerbConjugatedByAllForms PastIndefinite { get; set; }
    public VerbConjugatedByAllForms PastUsedTo { get; set; }
    public VerbConjugatedByAllForms PastSudden { get; set; }
    public VerbConjugatedByAllForms Conditional { get; set; }

    public SortedDictionary<ImperativeTypeEnum, string> Imperative { get; set; }
    
    
}