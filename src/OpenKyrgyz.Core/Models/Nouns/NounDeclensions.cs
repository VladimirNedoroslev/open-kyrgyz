using OpenKyrgyz.Core.Cases;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Possessive;

namespace OpenKyrgyz.Core.Models.Nouns;

public class NounDeclensions
{
    public string Атооч { get; set; }
    public string Илик { get; set; }
    public string Барыш { get; set; }
    public string Жатыш { get; set; }
    public string Табыш { get; set; }
    public string Чыгыш { get; set; }

    public NounDeclensions(string noun, PronounEnum? pronounEnum, string? иликRelatedWord = "нерсе")
    {
        Атооч = pronounEnum.HasValue ? noun.ToPossessive(pronounEnum.Value) : noun;
        Илик = ИликCase.Decline(noun, pronounEnum, иликRelatedWord);
        Барыш = БарышCase.Decline(noun, pronounEnum);
        Жатыш = ЖатышCase.Decline(noun, pronounEnum);
        Табыш = ТабышCase.Decline(noun, pronounEnum);
        Чыгыш = ЧыгышCase.Decline(noun, pronounEnum);
    }
}