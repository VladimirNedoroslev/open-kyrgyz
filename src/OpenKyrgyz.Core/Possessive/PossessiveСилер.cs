using OpenKyrgyz.Core.Common;
using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Possessive;

public class PossessiveСилер
{
    private static readonly Dictionary<VowelGroupEnum, string> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ңар" },
        { VowelGroupEnum.и_е_э, "ңер" },
        { VowelGroupEnum.у_ю, "ңар" },
        { VowelGroupEnum.о_ё, "ңар" },
        { VowelGroupEnum.ө_ү, "ңөр" },
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