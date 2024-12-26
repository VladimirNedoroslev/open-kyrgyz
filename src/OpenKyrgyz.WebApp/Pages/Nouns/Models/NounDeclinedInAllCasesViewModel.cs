using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Models.Nouns;

namespace OpenKyrgyz.WebApp.Pages.Nouns.Models;

public class NounDeclinedInAllCasesViewModel
{
    public PronounEnum? PronounEnum { get; set; }
    public string Атооч { get; set; }
    public string Илик { get; set; }
    public string Барыш { get; set; }
    public string Жатыш { get; set; }
    public string Табыш { get; set; }
    public string Чыгыш { get; set; }

    public NounDeclinedInAllCasesViewModel(NounDeclensions nounDeclensions, PronounEnum? pronounEnum)
    {
        PronounEnum = pronounEnum;
        Атооч = nounDeclensions.Атооч;
        Илик = nounDeclensions.Илик;
        Барыш = nounDeclensions.Барыш;
        Жатыш = nounDeclensions.Жатыш;
        Табыш = nounDeclensions.Табыш;
        Чыгыш = nounDeclensions.Чыгыш;
    }
}