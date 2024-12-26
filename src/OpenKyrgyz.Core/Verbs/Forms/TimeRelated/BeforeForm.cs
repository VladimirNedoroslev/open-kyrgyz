using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Verbs.Forms.TimeRelated;

public class BeforeForm
{
    private const string BeforeInKyrgyz = "чейин";

    public static string Get(string verb)
    {
        if (string.IsNullOrEmpty(verb))
            return verb;

        return БарышCase.Decline(Participle.Get(verb, VerbFormEnum.Positive)) + $" {BeforeInKyrgyz}";
    }
}