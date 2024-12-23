using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

namespace OpenKyrgyz.Core.Tenses.FutureGoingTo;

public class FutureGoingToConjugator
{
    private static readonly Dictionary<VowelGroupEnum, string> VowelOrVoicedConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ганы" },
        { VowelGroupEnum.и_е_э, "гени" },
        { VowelGroupEnum.у_ю, "ганы" },
        { VowelGroupEnum.о_ё, "гону" },
        { VowelGroupEnum.ө_ү, "гөнү" },
    };

    private static readonly Dictionary<VowelGroupEnum, string> VoicelessConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "каны" },
        { VowelGroupEnum.и_е_э, "кени" },
        { VowelGroupEnum.у_ю, "каны" },
        { VowelGroupEnum.о_ё, "кону" },
        { VowelGroupEnum.ө_ү, "көнү" },
    };

    public const string AuxiliaryVerb = "жат";

    public static string Conjugate(
        string verb,
        PronounEnum pronoun,
        VerbFormEnum form)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;

        if (form is VerbFormEnum.Negative or VerbFormEnum.NegativeAndInterrogative)
            return "-";

        var vowelGroup = verb.GetVowelGroup();
        var mapping = verb.GetLastLetterType() is LetterTypeEnum.VoicelessConsonant ? VoicelessConsonantMapping : VowelOrVoicedConsonantMapping;
        var verbWithFutureGoingToEnding = verb + mapping[vowelGroup];

        var conjugatedAuxiliaryVerb = PresentAndFutureSimpleConjugator.Conjugate(AuxiliaryVerb, pronoun, form);

        return $"{verbWithFutureGoingToEnding} {conjugatedAuxiliaryVerb}";
    }
}