using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Negative;

namespace OpenKyrgyz.Core.Tenses.Imperative;

public class ImperativeСиздер
{
    private static readonly Dictionary<VowelGroupEnum, string> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ңыздар" },
        { VowelGroupEnum.и_е_э, "ңиздер" },
        { VowelGroupEnum.у_ю, "ңуздар" },
        { VowelGroupEnum.о_ё, "ңуздар" },
        { VowelGroupEnum.ө_ү, "ңүздөр" },
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