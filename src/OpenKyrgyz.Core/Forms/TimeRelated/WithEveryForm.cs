using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Forms.TimeRelated;

public class WithEveryForm
{
    public const string EveryInKyrgyz = "сайын";

    public static string Get(string verb)
    {
        if (string.IsNullOrEmpty(verb))
            return verb;

        return Participle.Get(verb, VerbFormEnum.Positive) + $" {EveryInKyrgyz}";
    }
}