using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.Conditional;

namespace UnitTests.Tenses.Conditional;

public class ConditionalМенTests
{
    [Theory]
    [InlineData("бар", "барсам")]
    [InlineData("иште", "иштесем")]
    [InlineData("бол", "болсом")]
    [InlineData("көр", "көрсөм")]
    [InlineData("тап", "тапсам")]
    [InlineData("чеч", "чечсем")]
    [InlineData("ук", "уксам")]
    [InlineData("күт", "күтсөм")]
    public void Conditional_Мен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Мен,VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбасам")]
    [InlineData("иште", "иштебесем")]
    [InlineData("бол", "болбосом")]
    [InlineData("көр", "көрбөсөм")]
    [InlineData("тап", "таппасам")]
    [InlineData("чеч", "чечпесем")]
    [InlineData("ук", "укпасам")]
    [InlineData("күт", "күтпөсөм")]
    public void Conditional_Мен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барсамбы")]
    [InlineData("иште", "иштесемби")]
    [InlineData("бол", "болсомбу")]
    [InlineData("көр", "көрсөмбү")]
    [InlineData("тап", "тапсамбы")]
    [InlineData("чеч", "чечсемби")]
    [InlineData("ук", "уксамбы")]
    [InlineData("күт", "күтсөмбү")]
    public void Conditional_Мен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбасамбы")]
    [InlineData("иште", "иштебесемби")]
    [InlineData("бол", "болбосомбу")]
    [InlineData("көр", "көрбөсөмбү")]
    [InlineData("тап", "таппасамбы")]
    [InlineData("чеч", "чечпесемби")]
    [InlineData("ук", "укпасамбы")]
    [InlineData("күт", "күтпөсөмбү")]
    public void Conditional_Мен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}