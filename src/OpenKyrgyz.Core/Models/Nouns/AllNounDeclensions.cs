using OpenKyrgyz.Core.Enums;

namespace OpenKyrgyz.Core.Models.Nouns;

public class AllNounDeclensions
{
    public string Word { get; set; }

    public NounDeclensions WithoutPossessive { get; set; }
    public NounDeclensions Менин { get; set; }
    public NounDeclensions Сенин { get; set; }
    public NounDeclensions Сиздин { get; set; }
    public NounDeclensions Анын { get; set; }
    public NounDeclensions Биздин { get; set; }
    public NounDeclensions Силердин { get; set; }
    public NounDeclensions Сиздердин { get; set; }
    public NounDeclensions Алардын { get; set; }

    public AllNounDeclensions(string word)
    {
        Word = word;
        WithoutPossessive = new NounDeclensions(word, null);
        Менин = new NounDeclensions(word, PronounEnum.Мен);
        Сенин = new NounDeclensions(word, PronounEnum.Сен);
        Сиздин = new NounDeclensions(word, PronounEnum.Сиз);
        Анын = new NounDeclensions(word, PronounEnum.Ал);
        Биздин = new NounDeclensions(word, PronounEnum.Биз);
        Силердин = new NounDeclensions(word, PronounEnum.Силер);
        Сиздердин = new NounDeclensions(word, PronounEnum.Сиздер);
        Алардын = new NounDeclensions(word, PronounEnum.Алар);
    }
}