using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Negative;
using OpenKyrgyz.Core.Verbs.Moods;

namespace OpenKyrgyz.Core.Verbs.Forms;

public class GoalForm
{
    public const string ForInKyrgyz = "үчүн";

    public static readonly Dictionary<VowelGroupEnum, string> VowelOrVoicedConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ганы" },
        { VowelGroupEnum.и_е_э, "гени" },
        { VowelGroupEnum.о_ё, "гону" },
        { VowelGroupEnum.у_ю, "ганы" },
        { VowelGroupEnum.ө_ү, "гөнү" },
    };

    public static readonly Dictionary<VowelGroupEnum, string> VoicelessConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "каны" },
        { VowelGroupEnum.и_е_э, "кени" },
        { VowelGroupEnum.о_ё, "кону" },
        { VowelGroupEnum.у_ю, "каны" },
        { VowelGroupEnum.ө_ү, "көнү" },
    };

    public static string Get(string verb, VerbFormEnum form)
    {
        if (string.IsNullOrEmpty(verb))
            return verb;

        if (form is VerbFormEnum.Interrogative or VerbFormEnum.NegativeAndInterrogative)
            return "-";

        if (form == VerbFormEnum.Negative)
            verb += verb.GetNegativeAffix();

        var vowelGroup = verb.GetVowelGroup();
        var lastLetter = verb.GetLastLetterType();

        if (lastLetter is LetterTypeEnum.VoicelessConsonant)
            return verb + VoicelessConsonantMapping[vowelGroup];

        return verb + VowelOrVoicedConsonantMapping[vowelGroup];
    }

    public static string GetInCooperativeForm(string verb, VerbFormEnum form)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;

        if (form is VerbFormEnum.Interrogative or VerbFormEnum.NegativeAndInterrogative)
            return "-";

        if (form is VerbFormEnum.Negative)
            verb += verb.GetNegativeAffix();

        return CooperativeMood.Get(verb) + $" {ForInKyrgyz}";
    }

    public static string GetInNounForm(string verb, VerbFormEnum form)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;

        if (form is VerbFormEnum.Interrogative or VerbFormEnum.NegativeAndInterrogative)
            return "-";

        if (form is VerbFormEnum.Negative)
            return NounForm.GetNegativeNounForm(verb) + $" {ForInKyrgyz}";

        return NounForm.GetPositiveNounForm(verb) + $" {ForInKyrgyz}";
    }
}