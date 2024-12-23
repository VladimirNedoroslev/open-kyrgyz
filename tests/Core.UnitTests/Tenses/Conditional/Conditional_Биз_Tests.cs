using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.Conditional;

namespace UnitTests.Tenses.Conditional;

public class ConditionalБизTests
{
    [Theory]
    [InlineData("бар", "барсак")]
    [InlineData("иште", "иштесек")]
    [InlineData("бол", "болсок")]
    [InlineData("көр", "көрсөк")]
    [InlineData("тап", "тапсак")]
    [InlineData("чеч", "чечсек")]
    [InlineData("ук", "уксак")]
    [InlineData("күт", "күтсөк")]
    public void Conditional_Биз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбасак")]
    [InlineData("иште", "иштебесек")]
    [InlineData("бол", "болбосок")]
    [InlineData("көр", "көрбөсөк")]
    [InlineData("тап", "таппасак")]
    [InlineData("чеч", "чечпесек")]
    [InlineData("ук", "укпасак")]
    [InlineData("күт", "күтпөсөк")]
    public void Conditional_Биз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барсакпы")]
    [InlineData("иште", "иштесекпи")]
    [InlineData("бол", "болсокпу")]
    [InlineData("көр", "көрсөкпү")]
    [InlineData("тап", "тапсакпы")]
    [InlineData("чеч", "чечсекпи")]
    [InlineData("ук", "уксакпы")]
    [InlineData("күт", "күтсөкпү")]
    public void Conditional_Биз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбасакпы")]
    [InlineData("иште", "иштебесекпи")]
    [InlineData("бол", "болбосокпу")]
    [InlineData("көр", "көрбөсөкпү")]
    [InlineData("тап", "таппасакпы")]
    [InlineData("чеч", "чечпесекпи")]
    [InlineData("ук", "укпасакпы")]
    [InlineData("күт", "күтпөсөкпү")]
    public void Conditional_Биз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}