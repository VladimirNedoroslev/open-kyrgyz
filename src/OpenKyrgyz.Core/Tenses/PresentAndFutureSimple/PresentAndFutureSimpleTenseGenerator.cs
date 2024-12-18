using System.Text;
using OpenKyrgyz.Core.Common;
using OpenKyrgyz.Core.Core;

namespace OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

public class PresentAndFutureSimpleTenseGenerator
{
    public static string GenerateForPronoun(string verb, PronounEnum pronoun)
    {
        if (string.IsNullOrWhiteSpace(verb))
            return verb;

        // TODO: check other edge cases with alar
        if (verb == "бол" && pronoun == PronounEnum.Алар)
            return "болушат";

        if (pronoun == PronounEnum.Алар)
            return GenerateForAlar(verb);

        var linkingLetter = PresentAndFutureSimpleLinkingLetterGenerator.GetLinkingChar(verb);

        verb = verb.HarmonizeVerbEndingIfNecessary();

        var sb = new StringBuilder(verb);
        sb.Append(linkingLetter);
        verb = sb.ToString();

        var vowelGroup = verb.GetVowelGroup();

        var endings = PresentAndFutureSimpleEndingMappings.GetEnding(vowelGroup);

        var resultEnding = endings[pronoun];
        return $"{verb}{resultEnding}";
    }

    private static string GenerateForAlar(string verb)
    {
        var lastVowelIndex = verb.GetLastVowelIndex();
        if (lastVowelIndex == verb.Length - 1)
        {
            var endingsDict = PresentAndFutureSimpleEndingMappings.GetEnding(verb.GetVowelGroup());
            return $"{verb}{endingsDict[PronounEnum.Алар]}";
        }

        var lastVowel = verb[lastVowelIndex];
        var linkingLetter = LinkingLetterForAlarCase[lastVowel];
        verb = verb.HarmonizeVerbEndingIfNecessary();

        var sb = new StringBuilder(verb);
        sb.Append(linkingLetter);
        verb = sb.ToString();

        var vowelGroup = verb.GetVowelGroup();

        var endings = PresentAndFutureSimpleEndingMappings.GetEnding(vowelGroup);

        var resultEnding = endings[PronounEnum.Алар];
        return $"{verb}{resultEnding}";
    }

    public static Dictionary<PronounEnum, string> GenerateForAllPronouns(string verb)
    {
        return new Dictionary<PronounEnum, string>
        {
            { PronounEnum.Мен, GenerateForPronoun(verb, PronounEnum.Мен) },
            { PronounEnum.Сен, GenerateForPronoun(verb, PronounEnum.Сен) },
            { PronounEnum.Сиз, GenerateForPronoun(verb, PronounEnum.Сиз) },
            { PronounEnum.Ал, GenerateForPronoun(verb, PronounEnum.Ал) },
            { PronounEnum.Биз, GenerateForPronoun(verb, PronounEnum.Биз) },
            { PronounEnum.Силер, GenerateForPronoun(verb, PronounEnum.Силер) },
            { PronounEnum.Сиздер, GenerateForPronoun(verb, PronounEnum.Сиздер) },
            { PronounEnum.Алар, GenerateForAlar(verb) },
        };
    }

    private static readonly Dictionary<char, char> LinkingLetterForAlarCase = new()
    {
        { 'а', 'ы' },
        { 'я', 'ы' },
        { 'ы', 'ы' },

        { 'у', 'у' },
        { 'ю', 'у' },

        { 'и', 'и' },
        { 'е', 'и' },
        { 'э', 'и' },

        { 'о', 'о' },
        { 'ё', 'о' },

        { 'ө', 'ү' },
        { 'ү', 'ү' },
    };
}