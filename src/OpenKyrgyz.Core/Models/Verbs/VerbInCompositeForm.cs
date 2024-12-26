using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;
using OpenKyrgyz.Core.Verbs.Forms.TimeRelated;

namespace OpenKyrgyz.Core.Models.Verbs;

public class VerbInCompositeForm
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

    public VerbFormEnum? Form { get; set; }

    public VerbInCompositeForm(
        string verb,
        string мен,
        string сен,
        string сиз,
        string ал,
        string биз,
        string силер,
        string сиздер,
        string алар,
        VerbFormEnum? form = null)
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
    }

    public static VerbInCompositeForm GetAlthoughForm(string verb, VerbFormEnum form)
    {
        return new VerbInCompositeForm(verb,
            AlthoughForm.ToAlthoughForm(verb, PronounEnum.Мен, form),
            AlthoughForm.ToAlthoughForm(verb, PronounEnum.Сен, form),
            AlthoughForm.ToAlthoughForm(verb, PronounEnum.Сиз, form),
            AlthoughForm.ToAlthoughForm(verb, PronounEnum.Ал, form),
            AlthoughForm.ToAlthoughForm(verb, PronounEnum.Биз, form),
            AlthoughForm.ToAlthoughForm(verb, PronounEnum.Силер, form),
            AlthoughForm.ToAlthoughForm(verb, PronounEnum.Сиздер, form),
            AlthoughForm.ToAlthoughForm(verb, PronounEnum.Алар, form),
            form
        );
    }

    public static VerbInCompositeForm GetDespiteForm(string verb, VerbFormEnum form)
    {
        return new VerbInCompositeForm(verb,
            DespiteForm.ToDespiteForm(verb, PronounEnum.Мен, form),
            DespiteForm.ToDespiteForm(verb, PronounEnum.Сен, form),
            DespiteForm.ToDespiteForm(verb, PronounEnum.Сиз, form),
            DespiteForm.ToDespiteForm(verb, PronounEnum.Ал, form),
            DespiteForm.ToDespiteForm(verb, PronounEnum.Биз, form),
            DespiteForm.ToDespiteForm(verb, PronounEnum.Силер, form),
            DespiteForm.ToDespiteForm(verb, PronounEnum.Сиздер, form),
            DespiteForm.ToDespiteForm(verb, PronounEnum.Алар, form),
            form
        );
    }

    public static VerbInCompositeForm GetCauseForm(string verb, VerbFormEnum form)
    {
        return new VerbInCompositeForm(verb,
            CauseForm.GetPronounForm(verb, PronounEnum.Мен, form),
            CauseForm.GetPronounForm(verb, PronounEnum.Сен, form),
            CauseForm.GetPronounForm(verb, PronounEnum.Сиз, form),
            CauseForm.GetPronounForm(verb, PronounEnum.Ал, form),
            CauseForm.GetPronounForm(verb, PronounEnum.Биз, form),
            CauseForm.GetPronounForm(verb, PronounEnum.Силер, form),
            CauseForm.GetPronounForm(verb, PronounEnum.Сиздер, form),
            CauseForm.GetPronounForm(verb, PronounEnum.Алар, form),
            form
        );
    }

    public static VerbInCompositeForm GetAsSoonAsForm(string verb)
    {
        return new VerbInCompositeForm(verb,
            AsSoonAsForm.GetPronounForm(verb, PronounEnum.Мен),
            AsSoonAsForm.GetPronounForm(verb, PronounEnum.Сен),
            AsSoonAsForm.GetPronounForm(verb, PronounEnum.Сиз),
            AsSoonAsForm.GetPronounForm(verb, PronounEnum.Ал),
            AsSoonAsForm.GetPronounForm(verb, PronounEnum.Биз),
            AsSoonAsForm.GetPronounForm(verb, PronounEnum.Силер),
            AsSoonAsForm.GetPronounForm(verb, PronounEnum.Сиздер),
            AsSoonAsForm.GetPronounForm(verb, PronounEnum.Алар),
            null
        );
    }
}