using OpenKyrgyz.Core.Common;
using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Possessive;

public class PossessiveСен
{
    private const string PossessiveСенAffix = "ң";

    public static string ToPossessive(string word)
    {
        if (string.IsNullOrEmpty(word))
            return word;
        var vowelGroup = word.GetVowelGroup();
        var lastLetterType = word.GetLastLetterType();
        if (lastLetterType is LetterTypeEnum.Vowel)
            return word + PossessiveСенAffix;
        word = word.HarmonizeEndingIfNecessary();
        return УаойReplacer.Replace(word + ЫиуүLinkingLetter.GetLinkingChar(vowelGroup) + PossessiveСенAffix);
    }
}