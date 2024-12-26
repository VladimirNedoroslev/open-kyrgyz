using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.PastSudden;

namespace UnitTests.Tenses.Past.Sudden;

public class PastSuddenСизTests
{
    [Theory]
    [InlineData("бар", "барыптырсыз")]
    [InlineData("иште", "иштептирсиз")]
    [InlineData("бол", "болуптурсуз")]
    [InlineData("көр", "көрүптүрсүз")]
    [InlineData("тап", "табыптырсыз")]
    [InlineData("чеч", "чечиптирсиз")]
    [InlineData("ук", "угуптурсуз")]
    [InlineData("күт", "күтүптүрсүз")]
    [InlineData("кой", "коюптурсуз")]
    public void PastSudden_Сиз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбаптырсыз")]
    [InlineData("иште", "иштебептирсиз")]
    [InlineData("бол", "болбоптурсуз")]
    [InlineData("көр", "көрбөптүрсүз")]
    [InlineData("тап", "таппаптырсыз")]
    [InlineData("чеч", "чечпептирсиз")]
    [InlineData("ук", "укпаптырсыз")]
    [InlineData("күт", "күтпөптүрсүз")]
    public void PastSudden_Сиз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барыптырсызбы")]
    [InlineData("иште", "иштептирсизби")]
    [InlineData("бол", "болуптурсузбу")]
    [InlineData("көр", "көрүптүрсүзбү")]
    [InlineData("тап", "табыптырсызбы")]
    [InlineData("чеч", "чечиптирсизби")]
    [InlineData("ук", "угуптурсузбу")]
    [InlineData("күт", "күтүптүрсүзбү")]
    [InlineData("кой", "коюптурсузбу")]
    public void PastSudden_Сиз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барбаптырсызбы")]
    [InlineData("иште", "иштебептирсизби")]
    [InlineData("бол", "болбоптурсузбу")]
    [InlineData("көр", "көрбөптүрсүзбү")]
    [InlineData("тап", "таппаптырсызбы")]
    [InlineData("чеч", "чечпептирсизби")]
    [InlineData("ук", "укпаптырсызбы")]
    [InlineData("күт", "күтпөптүрсүзбү")]
    public void PastSudden_Сиз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}