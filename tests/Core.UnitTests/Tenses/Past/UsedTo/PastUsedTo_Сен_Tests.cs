using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.WithDifferentNegative.PastUsedTo;

namespace UnitTests.PastUsedTo;

public class PasUsedToСенTests
{
    [Theory]
    [InlineData("бар", "барчусуң")]
    [InlineData("иште", "иштечүсүң")]
    [InlineData("бол", "болчусуң")]
    [InlineData("көр", "көрчүсүң")]
    [InlineData("тап", "тапчусуң")]
    [InlineData("чеч", "чеччүсүң")]
    [InlineData("ук", "укчусуң")]
    [InlineData("күт", "күтчүсүң")]
    public void PastUsedTo_Сен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчу эмессиң")]
    [InlineData("иште", "иштечү эмессиң")]
    [InlineData("бол", "болчу эмессиң")]
    [InlineData("көр", "көрчү эмессиң")]
    [InlineData("тап", "тапчу эмессиң")]
    [InlineData("чеч", "чеччү эмессиң")]
    [InlineData("ук", "укчу эмессиң")]
    [InlineData("күт", "күтчү эмессиң")]
    public void PastUsedTo_Сен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчусуңбу")]
    [InlineData("иште", "иштечүсүңбү")]
    [InlineData("бол", "болчусуңбу")]
    [InlineData("көр", "көрчүсүңбү")]
    [InlineData("тап", "тапчусуңбу")]
    [InlineData("чеч", "чеччүсүңбү")]
    [InlineData("ук", "укчусуңбу")]
    [InlineData("күт", "күтчүсүңбү")]
    public void PastUsedTo_Сен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барчу эмессиңби")]
    [InlineData("иште", "иштечү эмессиңби")]
    [InlineData("бол", "болчу эмессиңби")]
    [InlineData("көр", "көрчү эмессиңби")]
    [InlineData("тап", "тапчу эмессиңби")]
    [InlineData("чеч", "чеччү эмессиңби")]
    [InlineData("ук", "укчу эмессиңби")]
    [InlineData("күт", "күтчү эмессиңби")]
    public void PastUsedTo_Сен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}