using FluentAssertions;
using OpenKyrgyz.Core.Forms.Noun;

namespace UnitTests.Forms.Noun;

public class VerbToNounFormTests
{
    [Theory]
    [InlineData("айт", "айтуу")]
    [InlineData("бар", "баруу")]
    [InlineData("жаз", "жазуу")]
    [InlineData("жат", "жатуу")]
    [InlineData("тур", "туруу")]
    [InlineData("отур", "отуруу")]
    [InlineData("тап", "табуу")]
    [InlineData("сал", "салуу")]
    [InlineData("кой", "коюу")]
    [InlineData("ал", "алуу")]
    [InlineData("сат", "сатуу")]
    [InlineData("алмаштыр", "алмаштыруу")]
    [InlineData("кач", "качуу")]
    [InlineData("созул", "созулуу")]
    [InlineData("корк", "коркуу")]
    [InlineData("буз", "бузуу")]
    [InlineData("кыл", "кылуу")]
    [InlineData("жап", "жабуу")]
    [InlineData("ач", "ачуу")]
    [InlineData("жыл", "жылуу")]
    [InlineData("котор", "которуу")]
    [InlineData("колдон", "колдонуу")]
    [InlineData("кош", "кошуу")]
    [InlineData("аткар", "аткаруу")]
    [InlineData("чоңой", "чоңоюу")]
    [InlineData("жашыр", "жашыруу")]
    [InlineData("кыйкыр", "кыйкыруу")]
    [InlineData("бол", "болуу")]
    [InlineData("жарат", "жаратуу")]
    [InlineData("чык", "чыгуу")]
    [InlineData("чагылыш", "чагылышуу")]
    [InlineData("ачуулан", "ачуулануу")]
    [InlineData("бас", "басуу")]
    [InlineData("жолук", "жолугуу")]
    [InlineData("тос", "тосуу")]
    [InlineData("ат", "атуу")]
    [InlineData("ук", "угуу")]
    [InlineData("тарт", "тартуу")]
    [InlineData("сугар", "сугаруу")]
    [InlineData("учураш", "учурашуу")]
    [InlineData("ур", "уруу")]
    [InlineData("сок", "согуу")]
    [InlineData("тааныш", "таанышуу")]
    public void ToNounForm_уу(string verb, string expectedResult)
    {
        // act
        var actualResult = NounForm.GetNounFormPositive(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("кел", "келүү")]
    [InlineData("көн", "көнүү")]
    [InlineData("ишен", "ишенүү")]
    [InlineData("ич", "ичүү")]
    [InlineData("кир", "кирүү")]
    [InlineData("кет", "кетүү")]
    [InlineData("түшүн", "түшүнүү")]
    [InlineData("жүр", "жүрүү")]
    [InlineData("бер", "берүү")]
    [InlineData("күл", "күлүү")]
    [InlineData("көч", "көчүү")]
    [InlineData("өт", "өтүү")]
    [InlineData("көр", "көрүү")]
    [InlineData("өс", "өсүү")]
    [InlineData("үмүттөн", "үмүттөнүү")]
    [InlineData("түз", "түзүү")]
    [InlineData("түш", "түшүү")]
    [InlineData("көтөрүл", "көтөрүлүү")]
    [InlineData("кечик", "кечигүү")]
    [InlineData("сүз", "сүзүү")]
    [InlineData("секир", "секирүү")]
    [InlineData("өл", "өлүү")]
    [InlineData("көрсөт", "көрсөтүү")]
    [InlineData("түрт", "түртүү")]
    [InlineData("күй", "күйүү")]
    [InlineData("теп", "тебүү")]
    public void ToNounForm_үү(string verb, string expectedResult)
    {
        // act
        var actualResult = NounForm.GetNounFormPositive(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("байка", "байкоо")]
    [InlineData("чурка", "чуркоо")]
    [InlineData("урматта", "урматтоо")]
    [InlineData("кадырла", "кадырлоо")]
    [InlineData("ырда", "ырдоо")]
    [InlineData("жаса", "жасоо")]
    [InlineData("талда", "талдоо")]
    [InlineData("аныкта", "аныктоо")]
    [InlineData("кара", "кароо")]
    [InlineData("сана", "саноо")]
    [InlineData("ташта", "таштоо")]
    [InlineData("алда", "алдоо")]
    [InlineData("ата", "атоо")]
    [InlineData("укта", "уктоо")]
    [InlineData("сакта", "сактоо")]
    public void ToNounForm_оо(string verb, string expectedResult)
    {
        // act
        var actualResult = NounForm.GetNounFormPositive(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("изилде", "изилдөө")]
    [InlineData("бийле", "бийлөө")]
    [InlineData("иште", "иштөө")]
    [InlineData("эсепте", "эсептөө")]
   
    public void ToNounForm_өө(string verb, string expectedResult)
    {
        // act
        var actualResult = NounForm.GetNounFormPositive(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
}