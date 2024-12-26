using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Possessive;

namespace OpenKyrgyz.Core.Cases;

public class ИликCase
{
    public static readonly Dictionary<VowelGroupEnum, string> VowelMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "нын" },
        { VowelGroupEnum.и_е_э, "нин" },
        { VowelGroupEnum.о_ё, "нун" },
        { VowelGroupEnum.у_ю, "нун" },
        { VowelGroupEnum.ө_ү, "нүн" },
    };

    public static readonly Dictionary<VowelGroupEnum, string> VoicedConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "дын" },
        { VowelGroupEnum.и_е_э, "дин" },
        { VowelGroupEnum.о_ё, "дун" },
        { VowelGroupEnum.у_ю, "дун" },
        { VowelGroupEnum.ө_ү, "дүн" },
    };

    public static readonly Dictionary<VowelGroupEnum, string> VoicelessConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "тын" },
        { VowelGroupEnum.и_е_э, "тин" },
        { VowelGroupEnum.о_ё, "тун" },
        { VowelGroupEnum.у_ю, "тун" },
        { VowelGroupEnum.ө_ү, "түн" },
    };

    public static string Decline(string word, PronounEnum? withPossessive = null, string? relatedWord = "нерсе")
    {
        if (string.IsNullOrEmpty(word))
            return word;

        if (withPossessive.HasValue)
            word = word.ToPossessive(withPossessive.Value);

        var vowelGroup = word.GetVowelGroup();
        var lastLetter = word.GetLastLetterType();

        word += lastLetter switch
        {
            LetterTypeEnum.Vowel => VowelMapping[vowelGroup],
            LetterTypeEnum.VoicedConsonant => VoicedConsonantMapping[vowelGroup],
            LetterTypeEnum.VoicelessConsonant => VoicelessConsonantMapping[vowelGroup],
            _ => throw new ArgumentOutOfRangeException()
        };
        if (string.IsNullOrWhiteSpace(relatedWord))
            return word;
        var declinedRelatedWord = relatedWord.ToPossessive(PronounEnum.Ал);
        return $"{word} {declinedRelatedWord}";
    }
}