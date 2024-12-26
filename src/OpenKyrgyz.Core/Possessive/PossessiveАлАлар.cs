using OpenKyrgyz.Core.Common;
using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Possessive;

public class PossessiveАлАлар
{
    private const string PossessiveАлVowelEndingAffix = "с";

    public static string ToPossessive(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
            return word;
        var vowelGroup = word.GetVowelGroup();
        var алEnding = ЫиуүLinkingLetter.GetLinkingChar(vowelGroup);

        var lastLetterType = word.GetLastLetterType();
        if (lastLetterType == LetterTypeEnum.Vowel)
        {
            return УаойReplacer.Replace(word + PossessiveАлVowelEndingAffix + алEnding);
        }

        word = word.HarmonizeEndingIfNecessary();

        return УаойReplacer.Replace(word + алEnding);
    }
}