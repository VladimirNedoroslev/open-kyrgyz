using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Negative;

namespace OpenKyrgyz.Core.Verbs.Tenses.Imperative;

public static class ImperativeАл
{
    private static readonly Dictionary<VowelGroupEnum, string> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, "сын" },
        { VowelGroupEnum.и_е_э, "син" },
        { VowelGroupEnum.у_ю, "сун" },
        { VowelGroupEnum.о_ё, "сун" },
        { VowelGroupEnum.ө_ү, "сүн" },
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