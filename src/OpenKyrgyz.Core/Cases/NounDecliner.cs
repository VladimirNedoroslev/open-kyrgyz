using OpenKyrgyz.Core.Models.Nouns;
using OpenKyrgyz.Core.Plural;

namespace OpenKyrgyz.Core.Cases;

public class NounDecliner
{
    public AllNounDeclensions GetAllNounDeclensions(string noun, bool isPlural = false)
    {
        if (isPlural)
            noun += noun.GetPluralAffix();
        return new AllNounDeclensions(noun);
    }
}