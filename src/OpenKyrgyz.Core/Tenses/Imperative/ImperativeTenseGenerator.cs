// ReSharper disable InconsistentNaming

#pragma warning disable CS8603 // Possible null reference return.

namespace OpenKyrgyz.Core.Tenses.Imperative;

public static class ImperativeTenseGenerator
{
    public static string GenerateImperativeTense(string verb, ImperativeTypeEnum type)
    {
        if (string.IsNullOrWhiteSpace(verb))
        {
            return verb;
        }

        return type switch
        {
            ImperativeTypeEnum.Сен => verb,
            ImperativeTypeEnum.СенPolite => ImperativeСенPolite.ConjugatePositive(verb),
            ImperativeTypeEnum.СенOrder => ImperativeСенOrder.ConjugatePositive(verb),
            ImperativeTypeEnum.Силер => ImperativeСилер.ConjugatePositive(verb),
            ImperativeTypeEnum.Сиз => ImperativeСиз.ConjugatePositive(verb),
            ImperativeTypeEnum.Сиздер => ImperativeСиздер.ConjugatePositive(verb),
            ImperativeTypeEnum.Ал => ImperativeАл.ConjugatePositive(verb),
            ImperativeTypeEnum.Алар => ImperativeАлар.ConjugatePositive(verb),
            _ => null
        };
    }
}