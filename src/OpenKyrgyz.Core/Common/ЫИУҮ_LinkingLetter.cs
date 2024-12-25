using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Common;

public static class ЫиуүLinkingLetter
{
    private static readonly Dictionary<VowelGroupEnum, char> Mapping = new()
    {
        { VowelGroupEnum.а_я_ы, 'ы' },
        { VowelGroupEnum.у_ю, 'у' },
        { VowelGroupEnum.и_е_э, 'и' },
        { VowelGroupEnum.о_ё, 'у' },
        { VowelGroupEnum.ө_ү, 'ү' },
    };

    public static char GetLinkingChar(VowelGroupEnum vowelGroup)
    {
        return Mapping[vowelGroup];
    }
}