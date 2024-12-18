using OpenKyrgyz.Core.Common;

namespace OpenKyrgyz.Core.Plural;

public class PluralAffix : Affix
{
    public static readonly PluralAffix Лар = new("лар");
    public static readonly PluralAffix Лер = new("лер");
    public static readonly PluralAffix Лор = new("лор");
    public static readonly PluralAffix Лөр = new("лөр");

    public static readonly PluralAffix Дар = new("дар");
    public static readonly PluralAffix Дер = new("дер");
    public static readonly PluralAffix Дор = new("дор");
    public static readonly PluralAffix Дөр = new("дөр");

    public static readonly PluralAffix Тар = new("тар");
    public static readonly PluralAffix Тер = new("тер");
    public static readonly PluralAffix Тор = new("тор");
    public static readonly PluralAffix Төр = new("төр");

    public override string Value { get; }

    public PluralAffix(string value)
    {
        Value = value;
    }
}