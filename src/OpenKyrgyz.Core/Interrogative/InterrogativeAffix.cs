using OpenKyrgyz.Core.Common;

namespace OpenKyrgyz.Core.Interrogative;

public class InterrogativeAffix : Affix
{
    public static InterrogativeAffix Бы = new("бы");
    public static InterrogativeAffix Би = new("би");
    public static InterrogativeAffix Бу = new("бу");
    public static InterrogativeAffix Бү = new("бү");
    public static InterrogativeAffix Пы = new("пы");
    public static InterrogativeAffix Пи = new("пи");
    public static InterrogativeAffix Пу = new("пу");
    public static InterrogativeAffix Пү = new("пү");
    
    public override string Value { get; }

    public InterrogativeAffix(string value)
    {
        Value = value;
    }
}