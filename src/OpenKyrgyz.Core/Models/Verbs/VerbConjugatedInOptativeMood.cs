using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Moods;

namespace OpenKyrgyz.Core.Models.Verbs;

public class VerbConjugatedInOptativeMood
{
    public string Verb { get; set; }
    public string МенPositive { get; }
    public string МенNegative { get; }
    public string МенInterrogative { get; }
    public string МенNegativeInterrogative { get; }


    public string БизPositive { get; }
    public string БизNegative { get; }
    public string БизInterrogative { get; }
    public string БизNegativeInterrogative { get; }

    public VerbConjugatedInOptativeMood(string verb)
    {
        Verb = verb;
        МенPositive = OptativeMood.GetForМен(verb, VerbFormEnum.Positive);
        МенNegative = OptativeMood.GetForМен(verb, VerbFormEnum.Negative);
        МенInterrogative = OptativeMood.GetForМен(verb, VerbFormEnum.Interrogative);
        МенNegativeInterrogative = OptativeMood.GetForМен(verb, VerbFormEnum.NegativeAndInterrogative);

        БизPositive = OptativeMood.GetForБиз(verb, VerbFormEnum.Positive);
        БизNegative = OptativeMood.GetForБиз(verb, VerbFormEnum.Negative);
        БизInterrogative = OptativeMood.GetForБиз(verb, VerbFormEnum.Interrogative);
        БизNegativeInterrogative = OptativeMood.GetForБиз(verb, VerbFormEnum.NegativeAndInterrogative);
    }
}