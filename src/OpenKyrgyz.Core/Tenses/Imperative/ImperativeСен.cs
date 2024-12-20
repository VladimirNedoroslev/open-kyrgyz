using OpenKyrgyz.Core.Negative;

namespace OpenKyrgyz.Core.Tenses.Imperative;

public class ImperativeСен
{
    public static string ConjugatePositive(string verb)
    {
        return verb;
    }

    public static string ConjugateNegative(string verb)
    {
        return verb + verb.GetNegativeAffix();
    }
}