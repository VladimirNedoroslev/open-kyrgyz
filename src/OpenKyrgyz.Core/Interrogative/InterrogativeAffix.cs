using OpenKyrgyz.Core.Common;

namespace OpenKyrgyz.Core.Interrogative;

public class InterrogativeAffix : Affix
{
    public static readonly InterrogativeAffix Бы = new("бы");
    public static readonly InterrogativeAffix Би = new("би");
    public static readonly InterrogativeAffix Бу = new("бу");
    public static readonly InterrogativeAffix Бү = new("бү");
    
    public static readonly InterrogativeAffix Пы = new("пы");
    public static readonly InterrogativeAffix Пи = new("пи");
    public static readonly InterrogativeAffix Пу = new("пу");
    public static readonly InterrogativeAffix Пү = new("пү");
    
    public override string Value { get; }

    public InterrogativeAffix(string value)
    {
        Value = value;
    }
}