using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace OpenKyrgyz.Core.Models.Verbs;

//TODO: refactor into smaller classes
public class AllVerbForms
{
    public string BaseForm { get; set; }

    public string NounFormPositive { get; set; }
    public string NounFormNegative { get; set; }

    public string GerundPositive { get; set; }
    public string GerundNegative { get; set; }

    public string ParticiplePositive { get; set; }
    public string ParticipleNegative { get; set; }

    public string PassiveParticiplePositive { get; set; }
    public string PassiveParticipleNegative { get; set; }

    public string DirectObjectForm { get; set; }
    public string LikeFormPositive { get; set; }
    public string LikeFormNegative { get; set; }

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

    public string GoalFormPositive { get; set; }
    public string GoalFormNegative { get; set; }

    public string GoalCooperativeFormPositive { get; set; }
    public string GoalCooperativeFormNegative { get; set; }

    public string GoalNounFormPositive { get; set; }
    public string GoalNounFormNegative { get; set; }


    public AllVerbForms(string verb)
    {
        BaseForm = verb;
        NounFormPositive = NounForm.GetPositiveNounForm(verb);
        NounFormNegative = NounForm.GetNegativeNounForm(verb);
        GerundPositive = Gerund.Get(verb, VerbFormEnum.Positive);
        GerundNegative = Gerund.Get(verb, VerbFormEnum.Negative);

        PassiveParticiplePositive = Participle.GetInPassiveMood(verb, VerbFormEnum.Positive);
        PassiveParticipleNegative = Participle.GetInPassiveMood(verb, VerbFormEnum.Negative);

        ParticiplePositive = Participle.Get(verb, VerbFormEnum.Positive);
        ParticipleNegative = Participle.Get(verb, VerbFormEnum.Negative);

        DirectObjectForm = OpenKyrgyz.Core.Verbs.Forms.DirectObjectForm.Get(verb);
        LikeFormPositive = LikeForm.Get(verb, VerbFormEnum.Positive);
        LikeFormNegative = LikeForm.Get(verb, VerbFormEnum.Negative);

        CooperativeMood = OpenKyrgyz.Core.Verbs.Moods.CooperativeMood.Get(verb);
        ReflexiveMood = OpenKyrgyz.Core.Verbs.Moods.ReflexiveMood.Get(verb);
        PassiveMood = OpenKyrgyz.Core.Verbs.Moods.PassiveMood.Get(verb);

        WhenForm = OpenKyrgyz.Core.Verbs.Forms.TimeRelated.WhenForm.Get(verb);
        BeforeForm = OpenKyrgyz.Core.Verbs.Forms.TimeRelated.BeforeForm.Get(verb);
        AfterForm = OpenKyrgyz.Core.Verbs.Forms.TimeRelated.AfterForm.Get(verb);
        AsSoonAsForm = OpenKyrgyz.Core.Verbs.Forms.TimeRelated.AsSoonAsForm.Get(verb);
        WithEveryForm = OpenKyrgyz.Core.Verbs.Forms.TimeRelated.WithEveryForm.Get(verb);
        UntilForm = OpenKyrgyz.Core.Verbs.Forms.TimeRelated.UntilForm.Get(verb);
        WhileForm = OpenKyrgyz.Core.Verbs.Forms.TimeRelated.WhileForm.Get(verb);

        CauseFormPositive = CauseForm.Get(verb, VerbFormEnum.Positive);
        CauseFormNegative = CauseForm.Get(verb, VerbFormEnum.Negative);

        GoalFormPositive = GoalForm.Get(verb, VerbFormEnum.Positive);
        GoalFormNegative = GoalForm.Get(verb, VerbFormEnum.Negative);

        GoalCooperativeFormPositive = GoalForm.GetInCooperativeForm(verb, VerbFormEnum.Positive);
        GoalCooperativeFormNegative = GoalForm.GetInCooperativeForm(verb, VerbFormEnum.Negative);

        GoalNounFormPositive = GoalForm.GetInNounForm(verb, VerbFormEnum.Positive);
        GoalNounFormNegative = GoalForm.GetInNounForm(verb, VerbFormEnum.Negative);
    }
}