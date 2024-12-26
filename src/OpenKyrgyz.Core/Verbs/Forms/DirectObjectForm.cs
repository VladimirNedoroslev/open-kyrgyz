using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Verbs.Forms;

public class DirectObjectForm
{
    public static string Get(string verb)
    {
        if (string.IsNullOrEmpty(verb))
            return verb;

        return ТабышCase.Decline(Participle.Get(verb, VerbFormEnum.Positive));
    }
}