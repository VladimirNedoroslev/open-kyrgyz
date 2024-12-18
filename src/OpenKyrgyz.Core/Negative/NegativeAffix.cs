using OpenKyrgyz.Core.Common;

namespace OpenKyrgyz.Core.Negative;

public class NegativeAffix : Affix
{
    public static NegativeAffix Ба = new("ба");
    public static NegativeAffix Бе = new("бе");
    public static NegativeAffix Бо = new("бо");
    public static NegativeAffix Бө = new("бө");
    public static NegativeAffix Па = new("па");
    public static NegativeAffix Пе = new("пе");
    public static NegativeAffix По = new("по");
    public static NegativeAffix Пө = new("пө");
    
    public override string Value { get; }

    public NegativeAffix(string value)
    {
        Value = value;
    }
}