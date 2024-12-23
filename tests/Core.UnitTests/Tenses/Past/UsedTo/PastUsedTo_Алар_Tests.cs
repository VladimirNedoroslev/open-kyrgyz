using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.WithDifferentNegative.PastUsedTo;

namespace UnitTests.PastUsedTo;

public class PasUsedToАларTests
{
    [Theory]
    [InlineData("бар", "барышчу")]
    [InlineData("иште", "иштешчү")]
    [InlineData("бол", "болушчу")]
    [InlineData("көр", "көрүшчү")]
    [InlineData("тап", "табышчу")]
    [InlineData("чеч", "чечишчү")]
    [InlineData("ук", "угушчу")]
    [InlineData("күт", "күтүшчү")]
    public void PastUsedTo_Алар_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барышчу эмес")]
    [InlineData("иште", "иштешчү эмес")]
    [InlineData("бол", "болушчу эмес")]
    [InlineData("көр", "көрүшчү эмес")]
    [InlineData("тап", "табышчу эмес")]
    [InlineData("чеч", "чечишчү эмес")]
    [InlineData("ук", "угушчу эмес")]
    [InlineData("күт", "күтүшчү эмес")]
    public void PastUsedTo_Алар_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барышчубу")]
    [InlineData("иште", "иштешчүбү")]
    [InlineData("бол", "болушчубу")]
    [InlineData("көр", "көрүшчүбү")]
    [InlineData("тап", "табышчубу")]
    [InlineData("чеч", "чечишчүбү")]
    [InlineData("ук", "угушчубу")]
    [InlineData("күт", "күтүшчүбү")]
    public void PastUsedTo_Алар_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барышчу эмеспи")]
    [InlineData("иште", "иштешчү эмеспи")]
    [InlineData("бол", "болушчу эмеспи")]
    [InlineData("көр", "көрүшчү эмеспи")]
    [InlineData("тап", "табышчу эмеспи")]
    [InlineData("чеч", "чечишчү эмеспи")]
    [InlineData("ук", "угушчу эмеспи")]
    [InlineData("күт", "күтүшчү эмеспи")]
    public void PastUsedTo_Алар_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}