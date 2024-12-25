using System.Text;

namespace OpenKyrgyz.Core.Core;

public static class Consonants
{
    private static readonly Dictionary<char, char> ConsonantTransforms = new()
    {
        { 'к', 'г' },
        { 'п', 'б' },
    };

    
    private static readonly Dictionary<char, char> ReverseConsonantTransforms = new()
    {
        { 'г', 'к' },
        { 'б', 'п' },
    };
    // TODO: rewrite with Span
    public static string HarmonizeVerbEndingIfNecessary(this string verb)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        var lastSymbol = verb[^1];
        if (verb[^1] is not ('к' or 'п'))
            return verb;

        var sb = new StringBuilder(verb);
        sb[^1] = ConsonantTransforms[lastSymbol];
        verb = sb.ToString();

        return verb;
    }
    
    public static string UnHarmonizeVerbEndingIfNecessary(this string verb)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        var lastSymbol = verb[^1];
        if (verb[^1] is not ('г' or 'б'))
            return verb;

        var sb = new StringBuilder(verb);
        sb[^1] = ReverseConsonantTransforms[lastSymbol];
        verb = sb.ToString();

        return verb;
    }
}