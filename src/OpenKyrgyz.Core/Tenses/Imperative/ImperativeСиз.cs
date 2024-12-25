using OpenKyrgyz.Core.Common;
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
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        var vowelGroup = verb.GetVowelGroup();
        var ending = Mapping[vowelGroup];

        var lastLetterType = verb.GetLastLetterType();
        if (lastLetterType == LetterTypeEnum.Vowel)
        {
            return verb + ending;
        }

        verb = verb.HarmonizeEndingIfNecessary();

        var linkingVowel = ЫиуүLinkingLetter.GetLinkingChar(vowelGroup);

        return УаойReplacer.Replace(verb + linkingVowel + ending);
    }

    public static string ConjugateNegative(string verb)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        var negativeVerb = verb + verb.GetNegativeAffix();
        return ConjugatePositive(negativeVerb);
    }
}