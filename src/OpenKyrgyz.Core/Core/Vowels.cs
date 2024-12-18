using System.Runtime.InteropServices;
using System.Text;
using OpenKyrgyz.Core.Tenses.Imperative;

namespace OpenKyrgyz.Core.Core;

public static class Vowels
{
    public static readonly HashSet<char> AllVowels = ['а', 'я', 'ы', 'о', 'ё', 'у', 'ю', 'е', 'э', 'и', 'ө', 'ү'];
    
    public static bool IsVowel(this char symbol)
    {
        return AllVowels.Contains(symbol);
    }
    
    public static int GetLastVowelIndex(this string word)
    {
        var i = 0;
        do
        {
            i++;
        } while (!word[^i].IsVowel());

        return word.Length - i;
    }

    // TODO: rewrite with Span
    public static string HarmonizeVerbEndingIfNecessary(this string verb)
    {
        var lastSymbol = verb[^1];
        if (verb[^1] is not ('к' or 'п'))
            return verb;
        
        var sb = new StringBuilder(verb);
        sb[^1] = Mappings.ConsonantTransforms[lastSymbol];
        verb = sb.ToString();

        return verb;
    }
}

[StructLayout(LayoutKind.Sequential, Size = 1)]
public struct VoicedConsonant;

[StructLayout(LayoutKind.Sequential, Size = 1)]
public struct VoicelessConsonant;