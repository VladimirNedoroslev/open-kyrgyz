using OpenKyrgyz.Core.Core;

namespace OpenKyrgyz.Core.Common;

public class NegativeApplier
{
    private readonly Dictionary<char, char> _mappings = new()
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