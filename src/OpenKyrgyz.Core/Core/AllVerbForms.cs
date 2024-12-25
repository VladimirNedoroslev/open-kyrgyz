namespace OpenKyrgyz.Core.Core;

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

    public string UntilForm { get; set; }
    public string WhileForm { get; set; }

    public string CauseFormPositive { get; set; }
    public string CauseFormNegative { get; set; }


    public AllVerbForms(
        string baseForm,
        string nounFormPositive,
        string nounFormNegative,
        string gerundPositive,
        string gerundNegative,
        string participlePositive,
        string participleNegative,
        string cooperativeMood,
        string reflexiveMood,
        string passiveMood,
        string untilForm,
        string whileForm,
        string causeFormPositive,
        string causeFormNegative
    )
    {
        BaseForm = baseForm;
        NounFormPositive = nounFormPositive;
        NounFormNegative = nounFormNegative;
        GerundPositive = gerundPositive;
        GerundNegative = gerundNegative;
        ParticiplePositive = participlePositive;
        ParticipleNegative = participleNegative;
        CooperativeMood = cooperativeMood;
        ReflexiveMood = reflexiveMood;
        PassiveMood = passiveMood;
        UntilForm = untilForm;
        WhileForm = whileForm;
        CauseFormPositive = causeFormPositive;
        CauseFormNegative = causeFormNegative;
    }
}