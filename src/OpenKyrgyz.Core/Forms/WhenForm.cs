using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Forms;

public class WhenForm
{
    public static string Get(string verb)
    {
        if (string.IsNullOrEmpty(verb))
            return verb;

        return ЖатышCase.ToЖатышCase(Participle.Get(verb, VerbFormEnum.Positive));
    }
}