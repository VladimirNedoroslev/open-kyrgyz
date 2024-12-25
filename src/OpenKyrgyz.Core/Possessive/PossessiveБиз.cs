using OpenKyrgyz.Core.Common;
using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Possessive;

public class PossessiveБиз
{
    private static readonly Dictionary<VowelGroupEnum, string> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, "быз" },
        { VowelGroupEnum.и_е_э, "биз" },
        { VowelGroupEnum.у_ю, "буз" },
        { VowelGroupEnum.о_ё, "буз" },
        { VowelGroupEnum.ө_ү, "бүз" },
    };

    public static string ToPossessive(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
            return word;
        var vowelGroup = word.GetVowelGroup();
        var ending = Mapping[vowelGroup];

        var lastLetterType = word.GetLastLetterType();
        if (lastLetterType == LetterTypeEnum.Vowel)
        {
            return word + ending;
        }

        word = word.HarmonizeEndingIfNecessary();

        var linkingVowel = ЫиуүLinkingLetter.GetLinkingChar(vowelGroup);

        return УаойReplacer.Replace(word + linkingVowel + ending);
    }
}