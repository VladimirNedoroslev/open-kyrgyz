using OpenKyrgyz.Core.Common;

namespace OpenKyrgyz.Core.Negative;

public class NegativeAffix : Affix
{
    public static readonly NegativeAffix Ба = new("ба");
    public static readonly NegativeAffix Бе = new("бе");
    public static readonly NegativeAffix Бо = new("бо");
    public static readonly NegativeAffix Бө = new("бө");
    
    public static readonly NegativeAffix Па = new("па");
    public static readonly NegativeAffix Пе = new("пе");
    public static readonly NegativeAffix По = new("по");
    public static readonly NegativeAffix Пө = new("пө");
    
    public override string Value { get; }

    public NegativeAffix(string value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return Value;
    }
}