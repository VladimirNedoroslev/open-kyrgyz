using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Negative;

namespace OpenKyrgyz.Core.Verbs.Tenses.Imperative;

public class ImperativeСенPolite
{
    private static readonly Dictionary<VowelGroupEnum, string> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, "чы" },
        { VowelGroupEnum.и_е_э, "чи" },
        { VowelGroupEnum.у_ю, "чу" },
        { VowelGroupEnum.о_ё, "чу" },
        { VowelGroupEnum.ө_ү, "чү" },
    };

    public static string ConjugatePositive(string verb)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        var vowelGroup = verb.GetVowelGroup();
        return verb + Mapping[vowelGroup];
    }

    public static string ConjugateNegative(string verb)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        var negativeVerb = verb + verb.GetNegativeAffix();
        return ConjugatePositive(negativeVerb);
    }
}