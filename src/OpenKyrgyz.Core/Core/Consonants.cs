using System.Text;

namespace OpenKyrgyz.Core.Core;

public static class Consonants
{
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