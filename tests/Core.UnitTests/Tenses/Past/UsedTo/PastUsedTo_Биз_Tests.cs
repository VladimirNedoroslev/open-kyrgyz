using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.WithDifferentNegative.PastUsedTo;

namespace UnitTests.PastUsedTo;

public class PasUsedToБизTests
{
    [Theory]
    [InlineData("бар", "барчубуз")]
    [InlineData("иште", "иштечүбүз")]
    [InlineData("бол", "болчубуз")]
    [InlineData("көр", "көрчүбүз")]
    [InlineData("тап", "тапчубуз")]
    [InlineData("чеч", "чеччүбүз")]
    [InlineData("ук", "укчубуз")]
    [InlineData("күт", "күтчүбүз")]
    public void PastUsedTo_Биз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчу эмеспиз")]
    [InlineData("иште", "иштечү эмеспиз")]
    [InlineData("бол", "болчу эмеспиз")]
    [InlineData("көр", "көрчү эмеспиз")]
    [InlineData("тап", "тапчу эмеспиз")]
    [InlineData("чеч", "чеччү эмеспиз")]
    [InlineData("ук", "укчу эмеспиз")]
    [InlineData("күт", "күтчү эмеспиз")]
    public void PastUsedTo_Биз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчубузбу")]
    [InlineData("иште", "иштечүбүзбү")]
    [InlineData("бол", "болчубузбу")]
    [InlineData("көр", "көрчүбүзбү")]
    [InlineData("тап", "тапчубузбу")]
    [InlineData("чеч", "чеччүбүзбү")]
    [InlineData("ук", "укчубузбу")]
    [InlineData("күт", "күтчүбүзбү")]
    public void PastUsedTo_Биз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барчу эмеспизби")]
    [InlineData("иште", "иштечү эмеспизби")]
    [InlineData("бол", "болчу эмеспизби")]
    [InlineData("көр", "көрчү эмеспизби")]
    [InlineData("тап", "тапчу эмеспизби")]
    [InlineData("чеч", "чеччү эмеспизби")]
    [InlineData("ук", "укчу эмеспизби")]
    [InlineData("күт", "күтчү эмеспизби")]
    public void PastUsedTo_Биз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}