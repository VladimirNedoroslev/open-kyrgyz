using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Possessive;

namespace OpenKyrgyz.Core.Cases;

public static class ЖатышCase
{
    public static readonly Dictionary<VowelGroupEnum, string> VowelOrVoicedConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "да" },
        { VowelGroupEnum.и_е_э, "де" },
        { VowelGroupEnum.о_ё, "до" },
        { VowelGroupEnum.у_ю, "да" },
        { VowelGroupEnum.ө_ү, "дө" },
    };

    public static readonly Dictionary<VowelGroupEnum, string> VoicelessConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "та" },
        { VowelGroupEnum.и_е_э, "те" },
        { VowelGroupEnum.о_ё, "то" },
        { VowelGroupEnum.у_ю, "та" },
        { VowelGroupEnum.ө_ү, "тө" },
    };

    private const char АнынАлардынCaseEnding = 'н';

    public static string Decline(string word, PronounEnum? withPossessive = null)
    {
        if (string.IsNullOrEmpty(word))
            return word;

        if (withPossessive.HasValue)
            word = word.ToPossessive(withPossessive.Value);

        var vowelGroup = word.GetVowelGroup();
        if (withPossessive is PronounEnum.Ал or PronounEnum.Алар)
        {
            return word + АнынАлардынCaseEnding + VowelOrVoicedConsonantMapping[vowelGroup];
        }

        var lastLetter = word.GetLastLetterType();

        if (lastLetter is LetterTypeEnum.VoicelessConsonant)
            return word + VoicelessConsonantMapping[vowelGroup];

        return word + VowelOrVoicedConsonantMapping[vowelGroup];
    }
}