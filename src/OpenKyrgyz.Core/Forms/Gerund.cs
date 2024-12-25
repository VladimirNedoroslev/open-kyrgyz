using OpenKyrgyz.Core.Core;
using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Forms;

public static class Gerund
{
    private static readonly Dictionary<VowelGroupEnum, string> PositiveMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "ып" },
        { VowelGroupEnum.и_е_э, "ип" },
        { VowelGroupEnum.о_ё, "уп" },
        { VowelGroupEnum.у_ю, "уп" },
        { VowelGroupEnum.ө_ү, "үп" },
    };

    private const char PositiveVowelEnding = 'п';

    public static readonly Dictionary<VowelGroupEnum, string> NegativeVowelOrVoicedConsonantNegativeMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "бай" },
        { VowelGroupEnum.и_е_э, "бей" },
        { VowelGroupEnum.о_ё, "бой" },
        { VowelGroupEnum.у_ю, "бай" },
        { VowelGroupEnum.ө_ү, "бөй" },
    };

    public static readonly Dictionary<VowelGroupEnum, string> VoicelessConsonantNegativeMapping = new()
    {
        { VowelGroupEnum.а_я_ы, "пай" },
        { VowelGroupEnum.и_е_э, "пей" },
        { VowelGroupEnum.о_ё, "пой" },
        { VowelGroupEnum.у_ю, "пай" },
        { VowelGroupEnum.ө_ү, "пөй" },
    };


    public static string Get(string verb, VerbFormEnum verbFormEnum)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;

        if (verbFormEnum is VerbFormEnum.Interrogative or VerbFormEnum.NegativeAndInterrogative)
            return "-";


        var lastLetterType = verb.GetLastLetterType();
        if (verbFormEnum is VerbFormEnum.Positive)
        {
            if (verb is "тап")
                return "таап";
            if (verb is "теп")
                return "тееп";

            if (lastLetterType is LetterTypeEnum.Vowel)
                return verb + PositiveVowelEnding;
            var result = verb + PositiveMapping[verb.GetVowelGroup()];
            return УаойReplacer.Replace(result);
        }

        var mapping = lastLetterType is LetterTypeEnum.VoicelessConsonant ? VoicelessConsonantNegativeMapping : NegativeVowelOrVoicedConsonantNegativeMapping;
        var vowelGroup = verb.GetVowelGroup();
        return verb + mapping[vowelGroup];
    }
}