using OpenKyrgyz.Core.Common;
using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Possessive;

public class PossessiveСиз
{
    private static readonly Dictionary<VowelGroupEnum, string> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ңыз" },
        { VowelGroupEnum.и_е_э, "ңиз" },
        { VowelGroupEnum.у_ю, "ңуз" },
        { VowelGroupEnum.о_ё, "ңуз" },
        { VowelGroupEnum.ө_ү, "ңүз" },
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