using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.Conditional;

namespace UnitTests.Conditional;

public class ConditionalАлTests
{
    [Theory]
    [InlineData("бар", "барса")]
    [InlineData("иште", "иштесе")]
    [InlineData("бол", "болсо")]
    [InlineData("көр", "көрсө")]
    [InlineData("тап", "тапса")]
    [InlineData("чеч", "чечсе")]
    [InlineData("ук", "укса")]
    [InlineData("күт", "күтсө")]
    public void Conditional_Ал_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбаса")]
    [InlineData("иште", "иштебесе")]
    [InlineData("бол", "болбосо")]
    [InlineData("көр", "көрбөсө")]
    [InlineData("тап", "таппаса")]
    [InlineData("чеч", "чечпесе")]
    [InlineData("ук", "укпаса")]
    [InlineData("күт", "күтпөсө")]
    public void Conditional_Ал_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барсабы")]
    [InlineData("иште", "иштесеби")]
    [InlineData("бол", "болсобу")]
    [InlineData("көр", "көрсөбү")]
    [InlineData("тап", "тапсабы")]
    [InlineData("чеч", "чечсеби")]
    [InlineData("ук", "уксабы")]
    [InlineData("күт", "күтсөбү")]
    public void Conditional_Ал_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбасабы")]
    [InlineData("иште", "иштебесеби")]
    [InlineData("бол", "болбособу")]
    [InlineData("көр", "көрбөсөбү")]
    [InlineData("тап", "таппасабы")]
    [InlineData("чеч", "чечпесеби")]
    [InlineData("ук", "укпасабы")]
    [InlineData("күт", "күтпөсөбү")]
    public void Conditional_Ал_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}