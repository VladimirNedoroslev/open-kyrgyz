using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Models.Verbs;

public class VerbConjugationsByTense
{
    public string Verb { get; set; }

    public string Мен { get; }
    public string Сен { get; }
    public string Сиз { get; }
    public string Ал { get; }
    public string Биз { get; }
    public string Силер { get; }
    public string Сиздер { get; }
    public string Алар { get; }

    public VerbFormEnum Form { get; set; }
    public TenseEnum Tense { get; }

    public VerbConjugationsByTense(
        string verb,
        string мен,
        string сен,
        string сиз,
        string ал,
        string биз,
        string силер,
        string сиздер,
        string алар,
        VerbFormEnum form,
        TenseEnum tense)
    {
        Verb = verb;
        Мен = мен;
        Сен = сен;
        Сиз = сиз;
        Ал = ал;
        Биз = биз;
        Силер = силер;
        Сиздер = сиздер;
        Алар = алар;
        Form = form;
        Tense = tense;
    }
}