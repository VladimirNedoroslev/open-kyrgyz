using OpenKyrgyz.Core.Common;
using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Possessive;

namespace OpenKyrgyz.Core.Cases;

public static class БарышCase
{
    public static readonly Dictionary<VowelGroupEnum, string> VowelOrVoicedConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "га" },
        { VowelGroupEnum.и_е_э, "ге" },
        { VowelGroupEnum.о_ё, "го" },
        { VowelGroupEnum.у_ю, "га" },
        { VowelGroupEnum.ө_ү, "гө" },
    };

    public static readonly Dictionary<VowelGroupEnum, string> VoicelessConsonantMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ка" },
        { VowelGroupEnum.и_е_э, "ке" },
        { VowelGroupEnum.о_ё, "ко" },
        { VowelGroupEnum.у_ю, "ка" },
        { VowelGroupEnum.ө_ү, "кө" },
    };

    public static readonly Dictionary<VowelGroupEnum, string> АнынАлардынCaseMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "на" },
        { VowelGroupEnum.и_е_э, "не" },
        { VowelGroupEnum.о_ё, "но" }, // not possible with Ал/Алар possessive, since it always ends with ы и у ү 
        { VowelGroupEnum.у_ю, "на" },
        { VowelGroupEnum.ө_ү, "нө" },
    };


    public static string Decline(string word, PronounEnum? withPossessive = null)
    {
        if (string.IsNullOrEmpty(word))
            return word;

        if (withPossessive.HasValue)
            word = word.ToPossessive(withPossessive.Value);

        var vowelGroup = word.GetVowelGroup();
        if (withPossessive is PronounEnum.Мен or PronounEnum.Сен)
        {
            return word + АеөойLinkingLetter.GetLinkingChar(word);
        }

        if (withPossessive is PronounEnum.Ал or PronounEnum.Алар)
        {
            return word + АнынАлардынCaseMapping[vowelGroup];
        }

        var lastLetter = word.GetLastLetterType();
        if (lastLetter is LetterTypeEnum.VoicelessConsonant)
            return word + VoicelessConsonantMapping[vowelGroup];

        return word + VowelOrVoicedConsonantMapping[vowelGroup];
    }
}