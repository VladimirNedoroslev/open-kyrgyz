namespace OpenKyrgyz.Core.Core;

public static class УаойReplacer
{
    public static readonly Dictionary<string, string> Mapping = new()
    {
        { "йо", "ё" },
        { "йу", "ю" },
        { "йа", "я" },
    };

    public static string Replace(string verb)
    {
        if (!verb.Contains("й"))
            return verb;
        foreach (var pair in Mapping)
        {
            if (verb.Contains(pair.Key))
                verb = verb.Replace(pair.Key, pair.Value);
        }

        return verb;
    }
}