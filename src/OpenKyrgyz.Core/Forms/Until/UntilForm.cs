using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Forms.Until;

public class UntilForm
{
    public static readonly Dictionary<VowelGroupEnum, string> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, "майынча" },
        { VowelGroupEnum.и_е_э, "мейинче" },
        { VowelGroupEnum.о_ё, "моюнча" },
        { VowelGroupEnum.у_ю, "майынча" },
        { VowelGroupEnum.ө_ү, "мөйүнчө" },
    };

    public static string Get(string verb)
    {
        if (string.IsNullOrEmpty(verb))
            return verb;
        var vowelGroup = verb.GetVowelGroup();
        return verb + Mapping[vowelGroup];
    }
}