using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Forms.TimeRelated;

public class BeforeForm
{
    private const string BeforeInKyrgyz = "чейин";

    public static string Get(string verb)
    {
        if (string.IsNullOrEmpty(verb))
            return verb;

        return БарышCase.ToБарышCase(Participle.Get(verb, VerbFormEnum.Positive)) + $" {BeforeInKyrgyz}";
    }
}