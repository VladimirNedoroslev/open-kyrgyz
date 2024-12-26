using OpenKyrgyz.Core.Common;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Verbs.Forms;

public class LikeForm
{
    public static string Get(string verb, VerbFormEnum form)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        if (form is VerbFormEnum.Interrogative or VerbFormEnum.NegativeAndInterrogative)
            return "-";

        verb = Participle.Get(verb, form);

        return LikeEnding.Get(verb);
    }
}