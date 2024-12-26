using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Verbs.Moods;

public static class ReflexiveMood
{
    private static readonly Dictionary<VowelGroupEnum, string> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ын" },
        { VowelGroupEnum.и_е_э, "ин" },
        { VowelGroupEnum.о_ё, "ун" },
        { VowelGroupEnum.у_ю, "ун" },
        { VowelGroupEnum.ө_ү, "үн" },
    };

    public const char VowelEnding = 'н';

    public static string Get(string verb)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        var lastLetterType = verb.GetLastLetterType();
        if (lastLetterType is LetterTypeEnum.Vowel)
            return verb + VowelEnding;
        var vowelGroup = verb.GetVowelGroup();
        verb = verb.HarmonizeEndingIfNecessary();
        return УаойReplacer.Replace(verb + Mapping[vowelGroup]);
    }
}