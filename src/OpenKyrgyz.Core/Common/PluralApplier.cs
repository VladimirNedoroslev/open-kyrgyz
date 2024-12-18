using OpenKyrgyz.Core.Core;

namespace OpenKyrgyz.Core.Common;

public class PluralApplier
{
    private static readonly Dictionary<char, char> VowelToPluralVowelMapping = new()
    {
        { 'а', 'а' },
        { 'я', 'а' },
        { 'ы', 'а' },
        { 'у', 'а' },
        { 'ю', 'а' },

        { 'и', 'е' },
        { 'е', 'е' },
        { 'э', 'е' },

        { 'о', 'о' },
        { 'ё', 'о' },

        { 'ө', 'ө' },
        { 'ү', 'ө' },
    };


    public static string Apply(string word)
    {
        // exception case
        if (word.Equals("бала"))
            return "балдар";

        var lastSymbol = word[^1];
        var isConsonantResult = lastSymbol.IsConsonant();
        if (isConsonantResult.IsT0)
        {
            return ApplyWithVowelOr_рй_Ending(word, word.Length - 1);
        }

        var lastVowelIndex = word.GetLastVowelIndex();
        if (isConsonantResult.IsT1)
        {
            return ApplyWithVoicelessConsonantEnding(word, lastVowelIndex);
        }

        if (lastSymbol is 'р' or 'й')
        {
            return ApplyWithVowelOr_рй_Ending(word, lastVowelIndex);
        }

        return ApplyWithVoicedConsonantEnding(word, lastVowelIndex);
    }

    private static string ApplyWithVowelOr_рй_Ending(string word, int lastVowelIndex)
    {
        var correspondingVowel = VowelToPluralVowelMapping[word[lastVowelIndex]];
        return $"{word}л{correspondingVowel}р";
    }

    private static string ApplyWithVoicelessConsonantEnding(string word, int lastVowelIndex = 1)
    {
        var correspondingVowel = VowelToPluralVowelMapping[word[lastVowelIndex]];
        return $"{word}т{correspondingVowel}р";
    }

    private static string ApplyWithVoicedConsonantEnding(string word, int lastVowelIndex = 1)
    {
        var correspondingVowel = VowelToPluralVowelMapping[word[lastVowelIndex]];
        return $"{word}д{correspondingVowel}р";
    }
}