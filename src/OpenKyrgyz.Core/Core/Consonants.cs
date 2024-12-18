using OneOf;
using OneOf.Types;

namespace OpenKyrgyz.Core.Core;

public static class Consonants
{
    public static readonly HashSet<char> AllConsonants =
        ['б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'ң', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь',];

    public static readonly HashSet<char> VoicedConsonants =
        ['б', 'в', 'г', 'д', 'ж', 'з', 'й', 'л', 'м', 'н', 'ң', 'р', 'ь',];

    public static readonly HashSet<char> VoicelessConsonants =
        ['к', 'п', 'с', 'т', 'ф', 'х', 'ч', 'ш', 'щ', 'ь',];
    
    public static OneOf<No, VoicelessConsonant, VoicedConsonant> IsConsonant(this char symbol)
    {
        if (VoicedConsonants.Contains(symbol))
            return new VoicedConsonant();
        if (VoicelessConsonants.Contains(symbol))
            return new VoicelessConsonant();

        return new No();
    }
}