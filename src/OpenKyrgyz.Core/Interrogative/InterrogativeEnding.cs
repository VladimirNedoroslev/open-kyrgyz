using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Interrogative;

public static class InterrogativeEnding
{
    private static readonly Dictionary<VowelGroupEnum, Dictionary<LetterTypeEnum, InterrogativeAffix>> Mapping = new()
    {
        {
            VowelGroupEnum.а_я_ы, new Dictionary<LetterTypeEnum,InterrogativeAffix >
            {
                { LetterTypeEnum.Vowel, InterrogativeAffix.Бы },
                { LetterTypeEnum.VoicedConsonant, InterrogativeAffix.Бы },
                { LetterTypeEnum.VoicelessConsonant, InterrogativeAffix.Пы },
            }
        },
        {
            VowelGroupEnum.у_ю, new Dictionary<LetterTypeEnum, InterrogativeAffix>
            {
                { LetterTypeEnum.Vowel, InterrogativeAffix.Бу },
                { LetterTypeEnum.VoicedConsonant, InterrogativeAffix.Бу },
                { LetterTypeEnum.VoicelessConsonant, InterrogativeAffix.Пу },
            }
        },
        {
            VowelGroupEnum.и_е_э, new Dictionary<LetterTypeEnum, InterrogativeAffix>
            {
                { LetterTypeEnum.Vowel, InterrogativeAffix.Би },
                { LetterTypeEnum.VoicedConsonant, InterrogativeAffix.Би },
                { LetterTypeEnum.VoicelessConsonant, InterrogativeAffix.Пи },
            }
        },
        {
            VowelGroupEnum.о_ё, new Dictionary<LetterTypeEnum, InterrogativeAffix>
            {
                { LetterTypeEnum.Vowel, InterrogativeAffix.Бу },
                { LetterTypeEnum.VoicedConsonant, InterrogativeAffix.Бу },
                { LetterTypeEnum.VoicelessConsonant, InterrogativeAffix.Пу },
            }
        },
        {
            VowelGroupEnum.ө_ү, new Dictionary<LetterTypeEnum, InterrogativeAffix>
            {
                { LetterTypeEnum.Vowel, InterrogativeAffix.Бү },
                { LetterTypeEnum.VoicedConsonant, InterrogativeAffix.Бү },
                { LetterTypeEnum.VoicelessConsonant, InterrogativeAffix.Пү},
            }
        }
    };

    public static InterrogativeAffix GetInterrogativeAffix(this string verb)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return InterrogativeAffix.Empty;
        var vowelGroup = verb.GetVowelGroup();
        var lastLetterType = verb.GetLastLetterType();
        return Mapping[vowelGroup][lastLetterType];
    }
}