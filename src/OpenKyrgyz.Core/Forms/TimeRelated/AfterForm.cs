using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Forms.TimeRelated;

public class AfterForm
{
    private const string AfterInKyrgyz = "кийин";

    public static string Get(string verb)
    {
        if (string.IsNullOrEmpty(verb))
            return verb;

        return ЧыгышCase.ToЧыгышCase(Participle.Get(verb, VerbFormEnum.Positive)) + $" {AfterInKyrgyz}";
    }
}