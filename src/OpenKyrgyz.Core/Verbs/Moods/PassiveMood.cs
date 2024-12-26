using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Verbs.Moods;

public class PassiveMood
{
    private static readonly Dictionary<VowelGroupEnum, string> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ыл" },
        { VowelGroupEnum.и_е_э, "ил" },
        { VowelGroupEnum.о_ё, "ул" },
        { VowelGroupEnum.у_ю, "ул" },
        { VowelGroupEnum.ө_ү, "үл" },
    };

    public const char VowelEnding = 'л';

    public static string Get(string verb)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;

        // if a verb ends with 'л' then it should become 'н' which is exactly the reflexive mood
        if (verb.GetLastConsonant() is 'л')
            return ReflexiveMood.Get(verb);

        var lastLetterType = verb.GetLastLetterType();
        if (lastLetterType is LetterTypeEnum.Vowel)
            return verb + VowelEnding;
        var vowelGroup = verb.GetVowelGroup();
        verb = verb.HarmonizeEndingIfNecessary();
        return УаойReplacer.Replace(verb + Mapping[vowelGroup]);
    }
}