using System.Runtime.InteropServices;
using System.Text;
using OneOf;
using OneOf.Types;

namespace OpenKyrgyz.Core.Core;

[StructLayout(LayoutKind.Sequential, Size = 1)]
public struct VoicedConsonant;

[StructLayout(LayoutKind.Sequential, Size = 1)]
public struct VoicelessConsonant;

public static class Consonants
{
    public static readonly HashSet<char> VoicedConsonants =
        ['б', 'в', 'г', 'д', 'ж', 'з', 'й', 'л', 'м', 'н', 'ң', 'р', 'ь',];

    public static readonly HashSet<char> VoicelessConsonants =
        ['к', 'п', 'с', 'т', 'ф', 'х', 'ч', 'ш', 'щ', 'ь',];

    public static OneOf<No, VoicelessConsonant, VoicedConsonant> IsConsonant(this char symbol)
    {
        if (VoicedConsonants.Contains(symbol))
            return new VoicedConsonant();
        if (VoicelessConsonants.Contains(symbol))
            return new VoicelessConsonant();

        return new No();
    }

    private static readonly Dictionary<char, char> ConsonantTransforms = new()
    {
        { 'к', 'г' },
        { 'п', 'б' },
    };

    // TODO: rewrite with Span
    public static string HarmonizeVerbEndingIfNecessary(this string verb)
    {
        var lastSymbol = verb[^1];
        if (verb[^1] is not ('к' or 'п'))
            return verb;

        var sb = new StringBuilder(verb);
        sb[^1] = ConsonantTransforms[lastSymbol];
        verb = sb.ToString();

        return verb;
    }
}