using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Possessive;

namespace OpenKyrgyz.Core.Forms;

public class AlthoughForm
{
    public static string ToAlthoughForm(string verb, PronounEnum pronoun, VerbFormEnum form)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        if (form is VerbFormEnum.Interrogative or VerbFormEnum.NegativeAndInterrogative)
            return "-";

        return Participle.Get(verb, form).ToPossessive(pronoun) + " менен";
    }
}