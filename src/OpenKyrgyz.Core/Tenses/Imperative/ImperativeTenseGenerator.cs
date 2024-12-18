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
            ImperativeTypeEnum.СенPolite => ImperativeСенPolite.Generate(verb),
            ImperativeTypeEnum.СенOrder => ImperativeСенOrder.GetImperativeSenOrderEnding(verb),
            ImperativeTypeEnum.Силер => ImperativeСилер.GetImperativeSilerEnding(verb),
            ImperativeTypeEnum.Сиз => ImperativeСиз.Generate(verb),
            ImperativeTypeEnum.Сиздер => ImperativeСиздер.Generate(verb),
            ImperativeTypeEnum.Ал => ImperativeАл.GetImperativeAlEnding(verb),
            ImperativeTypeEnum.Алар => ImperativeАлар.Generate(verb),
            _ => null
        };
    }

    public static Dictionary<ImperativeTypeEnum, string> GenerateAllImperativeTensesForVerb(string verb)
    {
        return new Dictionary<ImperativeTypeEnum, string>
        {
            { ImperativeTypeEnum.Сен, verb },
            { ImperativeTypeEnum.СенPolite, ImperativeСенPolite.Generate(verb) },
            { ImperativeTypeEnum.СенOrder, ImperativeСенOrder.GetImperativeSenOrderEnding(verb) },
            { ImperativeTypeEnum.Силер, ImperativeСилер.GetImperativeSilerEnding(verb) },
            { ImperativeTypeEnum.Сиз, ImperativeСиз.Generate(verb) },
            { ImperativeTypeEnum.Сиздер, ImperativeСиздер.Generate(verb) },
            { ImperativeTypeEnum.Ал, ImperativeАл.GetImperativeAlEnding(verb) },
            { ImperativeTypeEnum.Алар, ImperativeАлар.Generate(verb) },
        };
    }
}