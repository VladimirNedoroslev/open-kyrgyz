namespace OpenKyrgyz.Core.Core;

public class VerbConjugationsImperative
{
    public string Verb { get; set; }

    public string Сен { get; }
    public string СенPolite { get; }
    public string СенOrder { get; }
    public string Сиз { get; }
    public string Ал { get; }
    public string Силер { get; }
    public string Сиздер { get; }
    public string Алар { get; }

    public VerbConjugationsImperative(
        string verb,
        string сен,
        string сенPolite,
        string сенOrder,
        string сиз,
        string ал,
        string силер,
        string сиздер,
        string алар)
    {
        Verb = verb;
        Сен = сен;
        СенPolite = сенPolite;
        СенOrder = сенOrder;
        Сиз = сиз;
        Ал = ал;
        Силер = силер;
        Сиздер = сиздер;
        Алар = алар;
    }
}