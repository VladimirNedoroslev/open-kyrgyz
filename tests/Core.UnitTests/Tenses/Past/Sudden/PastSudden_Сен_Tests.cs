using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.PastSudden;

namespace UnitTests.Tenses.Past.Sudden;

public class PastSuddenСенTests
{
    [Theory]
    [InlineData("бар", "барыптырсың")]
    [InlineData("иште", "иштептирсиң")]
    [InlineData("бол", "болуптурсуң")]
    [InlineData("көр", "көрүптүрсүң")]
    [InlineData("тап", "табыптырсың")]
    [InlineData("чеч", "чечиптирсиң")]
    [InlineData("ук", "угуптурсуң")]
    [InlineData("күт", "күтүптүрсүң")]
    [InlineData("кой", "коюптурсуң")]
    public void PastSudden_Сен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбаптырсың")]
    [InlineData("иште", "иштебептирсиң")]
    [InlineData("бол", "болбоптурсуң")]
    [InlineData("көр", "көрбөптүрсүң")]
    [InlineData("тап", "таппаптырсың")]
    [InlineData("чеч", "чечпептирсиң")]
    [InlineData("ук", "укпаптырсың")]
    [InlineData("күт", "күтпөптүрсүң")]
    public void PastSudden_Сен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барыптырсыңбы")]
    [InlineData("иште", "иштептирсиңби")]
    [InlineData("бол", "болуптурсуңбу")]
    [InlineData("көр", "көрүптүрсүңбү")]
    [InlineData("тап", "табыптырсыңбы")]
    [InlineData("чеч", "чечиптирсиңби")]
    [InlineData("ук", "угуптурсуңбу")]
    [InlineData("күт", "күтүптүрсүңбү")]
    [InlineData("кой", "коюптурсуңбу")]
    public void PastSudden_Сен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барбаптырсыңбы")]
    [InlineData("иште", "иштебептирсиңби")]
    [InlineData("бол", "болбоптурсуңбу")]
    [InlineData("көр", "көрбөптүрсүңбү")]
    [InlineData("тап", "таппаптырсыңбы")]
    [InlineData("чеч", "чечпептирсиңби")]
    [InlineData("ук", "укпаптырсыңбы")]
    [InlineData("күт", "күтпөптүрсүңбү")]
    public void PastSudden_Сен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}