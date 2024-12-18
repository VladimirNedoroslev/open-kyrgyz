using OpenKyrgyz.Core.Common;

namespace OpenKyrgyz.Core.Tenses.Imperative;

public class ImperativeСиздер
{
    public static string Generate(string verb)
    {
        var sizImperative = ImperativeСиз.Generate(verb);
        var sizImperativePlural = PluralApplier.Apply(sizImperative);
        return sizImperativePlural;
    }
}