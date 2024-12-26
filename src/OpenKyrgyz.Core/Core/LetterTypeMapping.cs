using System.Text.RegularExpressions;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Core;

public static partial class LetterTypeMapping
{
    public const string KyrgyzAlphabetLettersRegex = "^[А-ЯЁа-яёҮүӨөҢң\\s]+$";

    public static readonly Dictionary<char, LetterTypeEnum> Mappings = new()
    {
        // Vowels
        { 'а', LetterTypeEnum.Vowel },
        { 'е', LetterTypeEnum.Vowel },
        { 'ё', LetterTypeEnum.Vowel },
        { 'и', LetterTypeEnum.Vowel },
        { 'о', LetterTypeEnum.Vowel },
        { 'у', LetterTypeEnum.Vowel },
        { 'ы', LetterTypeEnum.Vowel },
        { 'э', LetterTypeEnum.Vowel },
        { 'ю', LetterTypeEnum.Vowel },
        { 'я', LetterTypeEnum.Vowel },
        { 'ө', LetterTypeEnum.Vowel },
        { 'ү', LetterTypeEnum.Vowel },

        // Voiced consonants
        { 'б', LetterTypeEnum.VoicedConsonant },
        { 'в', LetterTypeEnum.VoicedConsonant },
        { 'г', LetterTypeEnum.VoicedConsonant },
        { 'д', LetterTypeEnum.VoicedConsonant },
        { 'ж', LetterTypeEnum.VoicedConsonant },
        { 'з', LetterTypeEnum.VoicedConsonant },
        { 'л', LetterTypeEnum.VoicedConsonant },
        { 'м', LetterTypeEnum.VoicedConsonant },
        { 'н', LetterTypeEnum.VoicedConsonant },
        { 'р', LetterTypeEnum.VoicedConsonant },
        { 'й', LetterTypeEnum.VoicedConsonant },
        { 'ң', LetterTypeEnum.VoicedConsonant },

        // Voiceless consonants
        { 'п', LetterTypeEnum.VoicelessConsonant },
        { 'ф', LetterTypeEnum.VoicelessConsonant },
        { 'к', LetterTypeEnum.VoicelessConsonant },
        { 'т', LetterTypeEnum.VoicelessConsonant },
        { 'ш', LetterTypeEnum.VoicelessConsonant },
        { 'с', LetterTypeEnum.VoicelessConsonant },
        { 'х', LetterTypeEnum.VoicelessConsonant },
        { 'ц', LetterTypeEnum.VoicelessConsonant },
        { 'ч', LetterTypeEnum.VoicelessConsonant },

        // Special cases
        { 'ъ', LetterTypeEnum.VoicedConsonant }, // Hard sign (can be adapted if needed)
        { 'ь', LetterTypeEnum.VoicedConsonant }, // Soft sign (can be adapted if needed)
    };

    public static LetterTypeEnum GetLastLetterType(this string s)
    {
        return Mappings[s[^1]];
    }

    public static LetterTypeEnum GetLetterType(this char c)
    {
        return Mappings[c];
    }

    [GeneratedRegex("^[БГДЖЗЙКЛМНҢПРСТФХЦЧШЩбгджзйклмнңпрстфхцчшщ]+$")]
    public static partial Regex OnlyConsonantsRegex();
}