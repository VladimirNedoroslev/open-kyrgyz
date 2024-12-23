using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.Conditional;

namespace UnitTests.Tenses.Conditional;

public class ConditionalАларTests
{
    [Theory]
    [InlineData("бар", "барышса")]
    [InlineData("иште", "иштешсе")]
    [InlineData("бол", "болушса")]
    [InlineData("көр", "көрүшсө")]
    [InlineData("тап", "табышса")]
    [InlineData("чеч", "чечишсе")]
    [InlineData("ук", "угушса")]
    [InlineData("күт", "күтүшсө")]
    public void Conditional_Алар_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барышпаса")]
    [InlineData("иште", "иштешпесе")]
    [InlineData("бол", "болушпаса")]
    [InlineData("көр", "көрүшпөсө")]
    [InlineData("тап", "табышпаса")]
    [InlineData("чеч", "чечишпесе")]
    [InlineData("ук", "угушпаса")]
    [InlineData("күт", "күтүшпөсө")]
    public void Conditional_Алар_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барышсабы")]
    [InlineData("иште", "иштешсеби")]
    [InlineData("бол", "болушсабы")]
    [InlineData("көр", "көрүшсөбү")]
    [InlineData("тап", "табышсабы")]
    [InlineData("чеч", "чечишсеби")]
    [InlineData("ук", "угушсабы")]
    [InlineData("күт", "күтүшсөбү")]
    public void Conditional_Алар_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барышпасабы")]
    [InlineData("иште", "иштешпесеби")]
    [InlineData("бол", "болушпасабы")]
    [InlineData("көр", "көрүшпөсөбү")]
    [InlineData("тап", "табышпасабы")]
    [InlineData("чеч", "чечишпесеби")]
    [InlineData("ук", "угушпасабы")]
    [InlineData("күт", "күтүшпөсөбү")]
    public void Conditional_Алар_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}