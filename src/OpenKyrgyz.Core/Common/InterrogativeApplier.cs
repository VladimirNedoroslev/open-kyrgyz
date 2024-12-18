using OpenKyrgyz.Core.Core;

namespace OpenKyrgyz.Core.Common;

public class InterrogativeApplier
{
    private readonly Dictionary<char, char> _mappings = new()
    {
        { 'а', 'ы' },
        { 'я', 'ы' },
        { 'ы', 'ы' },
        { 'у', 'у' },
        { 'ю', 'у' },

        { 'и', 'и' },
        { 'е', 'и' },
        { 'э', 'и' },
        
        { 'о', 'у' },
        { 'ё', 'у' },

        { 'ө', 'ү' },
        { 'ү', 'ү' },
    };

    public string Apply(string verb)
    {
        var lastSymbol = verb[^1];
        var isConsonantResult = lastSymbol.IsConsonant();
        if (isConsonantResult.IsT0)
        {
            return ApplyWithVowelOrVoicedConsonantEnding(verb, verb.Length - 1);
        }


        var i = verb.GetLastVowelIndex();

        return isConsonantResult.IsT1
            ? ApplyWithVoicelessConsonantEnding(verb, i)
            : ApplyWithVowelOrVoicedConsonantEnding(verb, i);
    }

    private string ApplyWithVowelOrVoicedConsonantEnding(string verb, int vowelIndex)
    {
        var correspondingVowel = _mappings[verb[vowelIndex]];
        return $"{verb}б{correspondingVowel}";
    }


    private string ApplyWithVoicelessConsonantEnding(string verb, int vowelIndex = 1)
    {
        var correspondingConsonant = _mappings[verb[vowelIndex]];
        return $"{verb}п{correspondingConsonant}";
    }
}