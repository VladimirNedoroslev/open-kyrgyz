using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Negative;

namespace OpenKyrgyz.Core.Forms.Noun;

public static class NounForm
{
    public const string ОоEnding = "оо";
    public const string УуEnding = "уу";
    public const string ҮүEnding = "үү";
    public const string ӨөEnding = "өө";

    public static string GetPositiveNounForm(string verb)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;
        if (verb is "же")
            return "-";
        
        var vowelGroup = verb.GetVowelGroup();
        if (verb is "оку")
        {
            return "окуу";
        }

        var lastLetter = verb[^1];
        if (lastLetter is 'е')
        {
            // remove last letter and add өө
            return verb[..^1] + ӨөEnding;
        }

        if (lastLetter is 'а')
        {
            // remove last letter and add оо
            return verb[..^1] + ОоEnding;
        }

        if (lastLetter is 'ө')
            return verb + 'ө';

        if (lastLetter is 'о')
        {
            return verb + 'о';
        }

        if (verb is not "корк")
            verb = verb.HarmonizeVerbEndingIfNecessary();

        if (vowelGroup is VowelGroupEnum.ө_ү or VowelGroupEnum.и_е_э)
        {
            return verb + ҮүEnding;
        }

        return УаойReplacer.Replace(verb + УуEnding);
    }

    public static string GetNegativeNounForm(string verb)
    {
        return GetPositiveNounForm(verb + verb.GetNegativeAffix());
    }

    public static string GetVerbFromNounForm(string verbInNounForm)
    {
        if (string.IsNullOrWhiteSpace(verbInNounForm))
            return verbInNounForm;
        if (verbInNounForm is "жүктөө")
            return "жүктө";
        verbInNounForm = УаойReplacer.ReverseReplace(verbInNounForm);


        if (verbInNounForm.EndsWith(ӨөEnding))
        {
            return verbInNounForm[..^2] + 'е';
        }

        if (verbInNounForm.EndsWith(ҮүEnding))
        {
            return verbInNounForm[..^2].UnHarmonizeVerbEndingIfNecessary();
        }

        if (verbInNounForm.EndsWith(ОоEnding))
        {
            return verbInNounForm[..^2] + 'а';
        }

        // уу case
        return verbInNounForm[..^2].UnHarmonizeVerbEndingIfNecessary();
    }

    public static bool IsInNounForm(string verb)
    {
        return verb.EndsWith(ОоEnding)
               || verb.EndsWith(УуEnding)
               || verb.EndsWith(ҮүEnding)
               || verb.EndsWith(ӨөEnding);
    }
}