using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Negative;

namespace OpenKyrgyz.Core.Tenses.Imperative;

public static class ImperativeСиз
{
    private static readonly Dictionary<VowelGroupEnum, string> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ңыз" },
        { VowelGroupEnum.и_е_э, "ңиз" },
        { VowelGroupEnum.у_ю, "ңуз" },
        { VowelGroupEnum.о_ё, "ңуз" },
        { VowelGroupEnum.ө_ү, "ңүз" },
    };

    public static string ConjugatePositive(string verb)
    {
        var vowelGroup = verb.GetVowelGroup();
        var ending = Mapping[vowelGroup];

        var lastLetterType = verb.GetLastLetterType();
        if (lastLetterType == LetterTypeEnum.Vowel)
        {
            return verb + ending;
        }

        verb = verb.HarmonizeVerbEndingIfNecessary();

        var linkingVowel = vowelGroup switch
        {
            VowelGroupEnum.а_я_ы => 'ы',
            VowelGroupEnum.и_е_э => 'и',
            VowelGroupEnum.у_ю => 'у',
            VowelGroupEnum.о_ё => 'у',
            VowelGroupEnum.ө_ү => 'ү',
            _ => throw new ArgumentOutOfRangeException()
        };

        return verb + linkingVowel + ending;
    }

    public static string ConjugateNegative(string verb)
    {
        var negativeVerb = verb + verb.GetNegativeAffix();
        return ConjugatePositive(negativeVerb);
    }
}