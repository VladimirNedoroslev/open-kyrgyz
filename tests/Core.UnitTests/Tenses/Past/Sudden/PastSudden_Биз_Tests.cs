using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.PastSudden;

namespace UnitTests.Tenses.Past.Sudden;

public class PastSuddenБизTests
{
    [Theory]
    [InlineData("бар", "барыптырбыз")]
    [InlineData("иште", "иштептирбиз")]
    [InlineData("бол", "болуптурбуз")]
    [InlineData("көр", "көрүптүрбүз")]
    [InlineData("тап", "табыптырбыз")]
    [InlineData("чеч", "чечиптирбиз")]
    [InlineData("ук", "угуптурбуз")]
    [InlineData("күт", "күтүптүрбүз")]
    [InlineData("кой", "коюптурбуз")]
    public void PastSudden_Биз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбаптырбыз")]
    [InlineData("иште", "иштебептирбиз")]
    [InlineData("бол", "болбоптурбуз")]
    [InlineData("көр", "көрбөптүрбүз")]
    [InlineData("тап", "таппаптырбыз")]
    [InlineData("чеч", "чечпептирбиз")]
    [InlineData("ук", "укпаптырбыз")]
    [InlineData("күт", "күтпөптүрбүз")]
    public void PastSudden_Биз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барыптырбызбы")]
    [InlineData("иште", "иштептирбизби")]
    [InlineData("бол", "болуптурбузбу")]
    [InlineData("көр", "көрүптүрбүзбү")]
    [InlineData("тап", "табыптырбызбы")]
    [InlineData("чеч", "чечиптирбизби")]
    [InlineData("ук", "угуптурбузбу")]
    [InlineData("күт", "күтүптүрбүзбү")]
    [InlineData("кой", "коюптурбузбу")]
    public void PastSudden_Биз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барбаптырбызбы")]
    [InlineData("иште", "иштебептирбизби")]
    [InlineData("бол", "болбоптурбузбу")]
    [InlineData("көр", "көрбөптүрбүзбү")]
    [InlineData("тап", "таппаптырбызбы")]
    [InlineData("чеч", "чечпептирбизби")]
    [InlineData("ук", "укпаптырбызбы")]
    [InlineData("күт", "күтпөптүрбүзбү")]
    public void PastSudden_Биз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}