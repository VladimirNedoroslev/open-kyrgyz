using OpenKyrgyz.Core.Common;
using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Possessive;

public class PossessiveМен
{
    private const string PossessiveМенAffix = "м";

    public static string ToPossessive(string word)
    {
        if (string.IsNullOrEmpty(word))
            return word;
        var vowelGroup = word.GetVowelGroup();
        var lastLetterType = word.GetLastLetterType();
        if (lastLetterType is LetterTypeEnum.Vowel)
            return word + PossessiveМенAffix;

        word = word.HarmonizeEndingIfNecessary();
        return УаойReplacer.Replace(word + ЫиуүLinkingLetter.GetLinkingChar(vowelGroup) + PossessiveМенAffix);
    }
}