using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Forms;

namespace OpenKyrgyz.Core.Models;

public class AllVerbForms
{
    public string BaseForm { get; set; }

    public string NounFormPositive { get; set; }
    public string NounFormNegative { get; set; }

    public string GerundPositive { get; set; }
    public string GerundNegative { get; set; }

    public string ParticiplePositive { get; set; }
    public string ParticipleNegative { get; set; }

    public string CooperativeMood { get; set; }
    public string ReflexiveMood { get; set; }
    public string PassiveMood { get; set; }

    public string WhenForm { get; set; }
    public string AfterForm { get; set; }
    public string BeforeForm { get; set; }
    public string AsSoonAsForm { get; set; }
    public string WithEveryForm { get; set; }
    public string UntilForm { get; set; }
    public string WhileForm { get; set; }

    public string CauseFormPositive { get; set; }
    public string CauseFormNegative { get; set; }


    public AllVerbForms(string verb)
    {
        NounFormPositive = NounForm.GetPositiveNounForm(verb);
        NounFormNegative = NounForm.GetNegativeNounForm(verb);
        GerundPositive = Gerund.Get(verb, VerbFormEnum.Positive);
        GerundNegative = Gerund.Get(verb, VerbFormEnum.Negative);
        ParticiplePositive = Participle.Get(verb, VerbFormEnum.Positive);
        ParticipleNegative = Participle.Get(verb, VerbFormEnum.Negative);

        CooperativeMood = Moods.CooperativeMood.Get(verb);
        ReflexiveMood = Moods.ReflexiveMood.Get(verb);
        PassiveMood = Moods.PassiveMood.Get(verb);

        WhenForm = Forms.TimeRelated.WhenForm.Get(verb);
        BeforeForm = Forms.TimeRelated.BeforeForm.Get(verb);
        AfterForm = Forms.TimeRelated.AfterForm.Get(verb);
        AsSoonAsForm = Forms.TimeRelated.AsSoonAsForm.Get(verb);
        WithEveryForm = Forms.TimeRelated.WithEveryForm.Get(verb);
        UntilForm = Forms.TimeRelated.UntilForm.Get(verb);
        WhileForm = Forms.TimeRelated.WhileForm.Get(verb);

        CauseFormPositive = CauseForm.Get(verb, VerbFormEnum.Positive);
        CauseFormNegative = CauseForm.Get(verb, VerbFormEnum.Negative);

        
    }
}