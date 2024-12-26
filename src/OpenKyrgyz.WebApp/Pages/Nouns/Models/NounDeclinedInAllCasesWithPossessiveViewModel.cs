using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Models.Nouns;

namespace OpenKyrgyz.WebApp.Pages.Nouns.Models;

public class NounDeclinedInAllCasesWithPossessiveViewModel
{
    public string Name { get; set; }
    public List<NounDeclinedInAllCasesViewModel> NounDeclinedInAllCasesWithPossessive { get; set; }

    public NounDeclinedInAllCasesWithPossessiveViewModel(string name, AllNounDeclensions allNounDeclensions)
    {
        Name = name;
        NounDeclinedInAllCasesWithPossessive =
        [
            new NounDeclinedInAllCasesViewModel(allNounDeclensions.Менин, PronounEnum.Мен),
            new NounDeclinedInAllCasesViewModel(allNounDeclensions.Сенин, PronounEnum.Сен),
            new NounDeclinedInAllCasesViewModel(allNounDeclensions.Сиздин, PronounEnum.Сиз),
            new NounDeclinedInAllCasesViewModel(allNounDeclensions.Анын, PronounEnum.Ал),
            new NounDeclinedInAllCasesViewModel(allNounDeclensions.Биздин, PronounEnum.Биз),
            new NounDeclinedInAllCasesViewModel(allNounDeclensions.Силердин, PronounEnum.Силер),
            new NounDeclinedInAllCasesViewModel(allNounDeclensions.Сиздердин, PronounEnum.Сиздер),
            new NounDeclinedInAllCasesViewModel(allNounDeclensions.Алардын, PronounEnum.Алар)
        ];
    }
}