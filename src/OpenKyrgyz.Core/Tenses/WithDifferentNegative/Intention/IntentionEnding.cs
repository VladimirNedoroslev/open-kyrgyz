using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Tenses.WithDifferentNegative.Intention;

public static class IntentionEnding
{
    private static readonly Dictionary<VowelGroupEnum, string> IntentionMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "мак" },
        { VowelGroupEnum.и_е_э, "мек" },
        { VowelGroupEnum.у_ю, "мак" },
        { VowelGroupEnum.о_ё, "мок" },
        { VowelGroupEnum.ө_ү, "мөк" },
    };

     private static readonly Dictionary<VowelGroupEnum, Dictionary<PronounEnum, string>> PronounMapping = new()
    {
        {
            VowelGroupEnum.а_я_ы, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "мын" },
                { PronounEnum.Сен, "сың" },
                { PronounEnum.Сиз, "сыз" },
                { PronounEnum.Ал, "" },
                { PronounEnum.Биз, "пыз" },
                { PronounEnum.Силер, "сыңар" },
                { PronounEnum.Сиздер, "сыздар" },
                { PronounEnum.Алар, "шмак" },
            }
        },
        {
            VowelGroupEnum.и_е_э, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "мин" },
                { PronounEnum.Сен, "сиң" },
                { PronounEnum.Сиз, "сиз" },
                { PronounEnum.Ал, "" },
                { PronounEnum.Биз, "пиз" },
                { PronounEnum.Силер, "сиңер" },
                { PronounEnum.Сиздер, "сиздер" },
                { PronounEnum.Алар, "шмек" },
            }
        },
        {
            VowelGroupEnum.у_ю, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "мын" },
                { PronounEnum.Сен, "сың" },
                { PronounEnum.Сиз, "сыз" },
                { PronounEnum.Ал, "" },
                { PronounEnum.Биз, "пыз" },
                { PronounEnum.Силер, "сыңар" },
                { PronounEnum.Сиздер, "сыздар" },
                { PronounEnum.Алар, "шмак" },
            }
        },
        {
            VowelGroupEnum.о_ё, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "мун" },
                { PronounEnum.Сен, "суң" },
                { PronounEnum.Сиз, "суз" },
                { PronounEnum.Ал, "" },
                { PronounEnum.Биз, "пуз" },
                { PronounEnum.Силер, "суңар" },
                { PronounEnum.Сиздер, "суздар" },
                { PronounEnum.Алар, "шмок" },
            }
        },
        {
            VowelGroupEnum.ө_ү, new Dictionary<PronounEnum, string>
            {
                { PronounEnum.Мен, "мүн" },
                { PronounEnum.Сен, "сүң" },
                { PronounEnum.Сиз, "сүз" },
                { PronounEnum.Ал, "" },
                { PronounEnum.Биз, "пүз" },
                { PronounEnum.Силер, "сүңөр" },
                { PronounEnum.Сиздер, "сүздөр" },
                { PronounEnum.Алар, "шмөк" },
            }
        }
    };
    
    public static string GetIntentionEnding(string word)
    {
        var vowelGroup = word.GetVowelGroup();
        return IntentionMapping[vowelGroup];
    }

    public static string GetEnding(string verb, PronounEnum pronoun)
    {
        var vowelGroup = verb.GetVowelGroup();
        var secondConditional = PronounMapping[vowelGroup][pronoun];
        if (pronoun == PronounEnum.Алар)
            return secondConditional;
        
        var pastEnding = IntentionMapping[vowelGroup];
        return pastEnding + secondConditional;
    }
}