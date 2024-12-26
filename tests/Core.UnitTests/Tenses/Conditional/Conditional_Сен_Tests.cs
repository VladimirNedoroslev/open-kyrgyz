using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.Conditional;

namespace UnitTests.Tenses.Conditional;

public class ConditionalСенTests
{
    [Theory]
    [InlineData("бар", "барсаң")]
    [InlineData("иште", "иштесең")]
    [InlineData("бол", "болсоң")]
    [InlineData("көр", "көрсөң")]
    [InlineData("тап", "тапсаң")]
    [InlineData("чеч", "чечсең")]
    [InlineData("ук", "уксаң")]
    [InlineData("күт", "күтсөң")]
    public void Conditional_Сен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбасаң")]
    [InlineData("иште", "иштебесең")]
    [InlineData("бол", "болбосоң")]
    [InlineData("көр", "көрбөсөң")]
    [InlineData("тап", "таппасаң")]
    [InlineData("чеч", "чечпесең")]
    [InlineData("ук", "укпасаң")]
    [InlineData("күт", "күтпөсөң")]
    public void Conditional_Сен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барсаңбы")]
    [InlineData("иште", "иштесеңби")]
    [InlineData("бол", "болсоңбу")]
    [InlineData("көр", "көрсөңбү")]
    [InlineData("тап", "тапсаңбы")]
    [InlineData("чеч", "чечсеңби")]
    [InlineData("ук", "уксаңбы")]
    [InlineData("күт", "күтсөңбү")]
    public void Conditional_Сен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбасаңбы")]
    [InlineData("иште", "иштебесеңби")]
    [InlineData("бол", "болбосоңбу")]
    [InlineData("көр", "көрбөсөңбү")]
    [InlineData("тап", "таппасаңбы")]
    [InlineData("чеч", "чечпесеңби")]
    [InlineData("ук", "укпасаңбы")]
    [InlineData("күт", "күтпөсөңбү")]
    public void Conditional_Сен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}