using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Verbs.Forms;

public class DespiteForm
{
    public static string ToDespiteForm(string verb, PronounEnum pronoun, VerbFormEnum form)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        if (form is VerbFormEnum.Interrogative or VerbFormEnum.NegativeAndInterrogative)
            return "-";

        return БарышCase.Decline(Participle.Get(verb, form), pronoun) + " карабастан";
    }
}