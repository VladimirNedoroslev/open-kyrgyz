using OpenKyrgyz.Core.Negative;

namespace OpenKyrgyz.Core.Verbs.Tenses.Imperative;

public class ImperativeСен
{
    public static string ConjugatePositive(string verb)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        return verb;
    }

    public static string ConjugateNegative(string verb)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        return verb + verb.GetNegativeAffix();
    }
}