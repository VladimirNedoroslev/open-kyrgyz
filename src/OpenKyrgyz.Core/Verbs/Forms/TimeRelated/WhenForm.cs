using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Verbs.Forms.TimeRelated;

public class WhenForm
{
    public static string Get(string verb)
    {
        if (string.IsNullOrEmpty(verb))
            return verb;

        return ЖатышCase.Decline(Participle.Get(verb, VerbFormEnum.Positive));
    }
}