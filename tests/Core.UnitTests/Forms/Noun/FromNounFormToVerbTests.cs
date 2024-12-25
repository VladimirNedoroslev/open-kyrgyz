using FluentAssertions;
using OpenKyrgyz.Core.Forms;

namespace UnitTests.Forms.Noun;

public class FromNounFormToVerbTests
{
    [Theory]
    [InlineData("айтуу", "айт")]
    [InlineData("баруу", "бар")]
    [InlineData("жазуу", "жаз")]
    [InlineData("жатуу", "жат")]
    [InlineData("туруу", "тур")]
    [InlineData("отуруу", "отур")]
    [InlineData("табуу", "тап")]
    [InlineData("салуу", "сал")]
    [InlineData("коюу", "кой")]
    [InlineData("алуу", "ал")]
    [InlineData("сатуу", "сат")]
    [InlineData("алмаштыруу", "алмаштыр")]
    [InlineData("качуу", "кач")]
    [InlineData("созулуу", "созул")]
    [InlineData("коркуу", "корк")]
    [InlineData("бузуу", "буз")]
    [InlineData("кылуу", "кыл")]
    [InlineData("жабуу", "жап")]
    [InlineData("ачуу", "ач")]
    [InlineData("жылуу", "жыл")]
    [InlineData("которуу", "котор")]
    [InlineData("колдонуу", "колдон")]
    [InlineData("кошуу", "кош")]
    [InlineData("аткаруу", "аткар")]
    [InlineData("чоңоюу", "чоңой")]
    [InlineData("жашыруу", "жашыр")]
    [InlineData("кыйкыруу", "кыйкыр")]
    [InlineData("болуу", "бол")]
    [InlineData("жаратуу", "жарат")]
    [InlineData("чыгуу", "чык")]
    [InlineData("чагылышуу", "чагылыш")]
    [InlineData("ачуулануу", "ачуулан")]
    [InlineData("басуу", "бас")]
    [InlineData("жолугуу", "жолук")]
    [InlineData("тосуу", "тос")]
    [InlineData("атуу", "ат")]
    [InlineData("угуу", "ук")]
    [InlineData("тартуу", "тарт")]
    [InlineData("сугаруу", "сугар")]
    [InlineData("учурашуу", "учураш")]
    [InlineData("уруу", "ур")]
    [InlineData("согуу", "сок")]
    [InlineData("таанышуу", "тааныш")]
    public void ToVerbFrom_уу(string verb, string expectedResult)
    {
        // act
        var actualResult = NounForm.GetVerbFromNounForm(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("келүү","кел")]
    [InlineData("көнүү","көн")]
    [InlineData("ишенүү","ишен")]
    [InlineData("ичүү","ич")]
    [InlineData("кирүү","кир")]
    [InlineData("кетүү","кет")]
    [InlineData("түшүнүү","түшүн")]
    [InlineData("жүрүү","жүр")]
    [InlineData("берүү","бер")]
    [InlineData("күлүү","күл")]
    [InlineData("көчүү","көч")]
    [InlineData("өтүү","өт")]
    [InlineData("көрүү","көр")]
    [InlineData("өсүү","өс")]
    [InlineData("үмүттөнүү","үмүттөн")]
    [InlineData("түзүү","түз")]
    [InlineData("түшүү","түш")]
    [InlineData("көтөрүлүү","көтөрүл")]
    [InlineData("кечигүү","кечик")]
    [InlineData("сүзүү","сүз")]
    [InlineData("секирүү","секир")]
    [InlineData("өлүү","өл")]
    [InlineData("көрсөтүү","көрсөт")]
    [InlineData("түртүү","түрт")]
    [InlineData("күйүү","күй")]
    [InlineData("тебүү","теп")]
  
    public void ToVerbFrom_үү(string verb, string expectedResult)
    {
        // act
        var actualResult = NounForm.GetVerbFromNounForm(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData( "байкоо","байка")]
    [InlineData( "чуркоо","чурка")]
    [InlineData( "урматтоо","урматта")]
    [InlineData( "кадырлоо","кадырла")]
    [InlineData( "ырдоо","ырда")]
    [InlineData( "жасоо","жаса")]
    [InlineData( "талдоо","талда")]
    [InlineData( "аныктоо","аныкта")]
    [InlineData( "кароо","кара")]
    [InlineData( "саноо","сана")]
    [InlineData( "таштоо","ташта")]
    [InlineData( "алдоо","алда")]
    [InlineData( "атоо","ата")]
    [InlineData( "уктоо","укта")]
    [InlineData( "сактоо","сакта")]
   
    public void ToVerbFrom_оо(string verb, string expectedResult)
    {
        // act
        var actualResult = NounForm.GetVerbFromNounForm(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData( "изилдөө","изилде")]
    [InlineData( "бийлөө","бийле")]
    [InlineData( "иштөө","иште")]
    [InlineData( "эсептөө","эсепте")]
    public void ToVerbFrom_өө(string verb, string expectedResult)
    {
        // act
        var actualResult = NounForm.GetVerbFromNounForm(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}