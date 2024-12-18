using OpenKyrgyz.Core.Common;

namespace OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

public abstract class PronounBasedGenerator
{
    protected abstract Dictionary<PronounEnum, string> EndingMappings { get; }
}