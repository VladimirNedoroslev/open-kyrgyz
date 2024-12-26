using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.WithDifferentNegative.PastUsedTo;

namespace UnitTests.Tenses.Past.UsedTo;

public class PasUsedToАлTests
{
    [Theory]
    [InlineData("бар", "барчу")]
    [InlineData("иште", "иштечү")]
    [InlineData("бол", "болчу")]
    [InlineData("көр", "көрчү")]
    [InlineData("тап", "тапчу")]
    [InlineData("чеч", "чеччү")]
    [InlineData("ук", "укчу")]
    [InlineData("күт", "күтчү")]
    public void PastUsedTo_Ал_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчу эмес")]
    [InlineData("иште", "иштечү эмес")]
    [InlineData("бол", "болчу эмес")]
    [InlineData("көр", "көрчү эмес")]
    [InlineData("тап", "тапчу эмес")]
    [InlineData("чеч", "чеччү эмес")]
    [InlineData("ук", "укчу эмес")]
    [InlineData("күт", "күтчү эмес")]
    public void PastUsedTo_Ал_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчубу")]
    [InlineData("иште", "иштечүбү")]
    [InlineData("бол", "болчубу")]
    [InlineData("көр", "көрчүбү")]
    [InlineData("тап", "тапчубу")]
    [InlineData("чеч", "чеччүбү")]
    [InlineData("ук", "укчубу")]
    [InlineData("күт", "күтчүбү")]
    public void PastUsedTo_Ал_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барчу эмеспи")]
    [InlineData("иште", "иштечү эмеспи")]
    [InlineData("бол", "болчу эмеспи")]
    [InlineData("көр", "көрчү эмеспи")]
    [InlineData("тап", "тапчу эмеспи")]
    [InlineData("чеч", "чеччү эмеспи")]
    [InlineData("ук", "укчу эмеспи")]
    [InlineData("күт", "күтчү эмеспи")]
    public void PastUsedTo_Ал_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}