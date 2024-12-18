using OpenKyrgyz.Core.Plural;

namespace OpenKyrgyz.Core.Tenses.Imperative;

public class ImperativeСиздер
{
    public static string Generate(string verb)
    {
        var sizImperative = ImperativeСиз.Generate(verb);
        var sizImperativeAffix = PluralEnding.GetPluralAffix(sizImperative);
        return sizImperative + sizImperativeAffix.Value;
    }
}