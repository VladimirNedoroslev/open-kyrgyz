using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Possessive;

namespace OpenKyrgyz.Core.Cases;

public class ТабышCase
{
    public static readonly Dictionary<VowelGroupEnum, string> VowelConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ны" },
        { VowelGroupEnum.и_е_э, "ни" },
        { VowelGroupEnum.о_ё, "ну" },
        { VowelGroupEnum.у_ю, "ну" },
        { VowelGroupEnum.ө_ү, "нү" },
    };

    public static readonly Dictionary<VowelGroupEnum, string> VoicedConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ды" },
        { VowelGroupEnum.и_е_э, "ди" },
        { VowelGroupEnum.о_ё, "ду" },
        { VowelGroupEnum.у_ю, "ду" },
        { VowelGroupEnum.ө_ү, "дү" },
    };

    public static readonly Dictionary<VowelGroupEnum, string> VoicelessConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ты" },
        { VowelGroupEnum.и_е_э, "ти" },
        { VowelGroupEnum.о_ё, "ту" },
        { VowelGroupEnum.у_ю, "ту" },
        { VowelGroupEnum.ө_ү, "тү" },
    };

    private const char АнынАлардынCase = 'н';

    public static string Decline(string word, PronounEnum? withPossessive = null)
    {
        if (string.IsNullOrEmpty(word))
            return word;

        if (withPossessive.HasValue)
            word = word.ToPossessive(withPossessive.Value);

        var vowelGroup = word.GetVowelGroup();
        if (withPossessive is PronounEnum.Ал or PronounEnum.Алар)
        {
            return word + АнынАлардынCase;
        }

        var lastLetter = word.GetLastLetterType();

        return lastLetter switch
        {
            LetterTypeEnum.Vowel => word + VowelConsonantMapping[vowelGroup],
            LetterTypeEnum.VoicedConsonant => word + VoicedConsonantMapping[vowelGroup],
            LetterTypeEnum.VoicelessConsonant => word + VoicelessConsonantMapping[vowelGroup],
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}