using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.PastSudden;

namespace UnitTests.Tenses.Past.Sudden;

public class PastSuddenСиздерTests
{
    [Theory]
    [InlineData("бар", "барыптырсыздар")]
    [InlineData("иште", "иштептирсиздер")]
    [InlineData("бол", "болуптурсуздар")]
    [InlineData("көр", "көрүптүрсүздөр")]
    [InlineData("тап", "табыптырсыздар")]
    [InlineData("чеч", "чечиптирсиздер")]
    [InlineData("ук", "угуптурсуздар")]
    [InlineData("күт", "күтүптүрсүздөр")]
    [InlineData("кой", "коюптурсуздар")]
    public void PastSudden_Сиздер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбаптырсыздар")]
    [InlineData("иште", "иштебептирсиздер")]
    [InlineData("бол", "болбоптурсуздар")]
    [InlineData("көр", "көрбөптүрсүздөр")]
    [InlineData("тап", "таппаптырсыздар")]
    [InlineData("чеч", "чечпептирсиздер")]
    [InlineData("ук", "укпаптырсыздар")]
    [InlineData("күт", "күтпөптүрсүздөр")]
    public void PastSudden_Сиздер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барыптырсыздарбы")]
    [InlineData("иште", "иштептирсиздерби")]
    [InlineData("бол", "болуптурсуздарбы")]
    [InlineData("көр", "көрүптүрсүздөрбү")]
    [InlineData("тап", "табыптырсыздарбы")]
    [InlineData("чеч", "чечиптирсиздерби")]
    [InlineData("ук", "угуптурсуздарбы")]
    [InlineData("күт", "күтүптүрсүздөрбү")]
    [InlineData("кой", "коюптурсуздарбы")]
    public void PastSudden_Сиздер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барбаптырсыздарбы")]
    [InlineData("иште", "иштебептирсиздерби")]
    [InlineData("бол", "болбоптурсуздарбы")]
    [InlineData("көр", "көрбөптүрсүздөрбү")]
    [InlineData("тап", "таппаптырсыздарбы")]
    [InlineData("чеч", "чечпептирсиздерби")]
    [InlineData("ук", "укпаптырсыздарбы")]
    [InlineData("күт", "күтпөптүрсүздөрбү")]
    public void PastSudden_Сиздер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}