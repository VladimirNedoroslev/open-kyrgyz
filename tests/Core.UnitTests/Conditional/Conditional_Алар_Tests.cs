using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.Conditional;

namespace UnitTests.Conditional;

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
    [InlineData("бар", "барбашса")]
    [InlineData("иште", "иштебешсе")]
    [InlineData("бол", "болбошсо")]
    [InlineData("көр", "көрбөшсө")]
    [InlineData("тап", "таппашса")]
    [InlineData("чеч", "чечпешсе")]
    [InlineData("ук", "укпашса")]
    [InlineData("күт", "күтпөшсө")]
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
    [InlineData("бар", "барбашсабы")]
    [InlineData("иште", "иштебешсеби")]
    [InlineData("бол", "болбошсобу")]
    [InlineData("көр", "көрбөшсөбү")]
    [InlineData("тап", "таппашсабы")]
    [InlineData("чеч", "чечпешсеби")]
    [InlineData("ук", "укпашсабы")]
    [InlineData("күт", "күтпөшсөбү")]
    public void Conditional_Алар_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}