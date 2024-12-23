using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PastDefinite;

namespace UnitTests.PastDefinite;

public class PastDefiniteМенTests
{
    [Theory]
    [InlineData("бар", "бардым")]
    [InlineData("иште", "иштедим")]
    [InlineData("бол", "болдум")]
    [InlineData("көр", "көрдүм")]
    [InlineData("тап", "таптым")]
    [InlineData("чеч", "чечтим")]
    [InlineData("ук", "уктум")]
    [InlineData("күт", "күттүм")]
    public void PastDefinite_Мен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Мен,VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбадым")]
    [InlineData("иште", "иштебедим")]
    [InlineData("бол", "болбодум")]
    [InlineData("көр", "көрбөдүм")]
    [InlineData("тап", "таппадым")]
    [InlineData("чеч", "чечпедим")]
    [InlineData("ук", "укпадым")]
    [InlineData("күт", "күтпөдүм")]
    public void PastDefinite_Мен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бардымбы")]
    [InlineData("иште", "иштедимби")]
    [InlineData("бол", "болдумбу")]
    [InlineData("көр", "көрдүмбү")]
    [InlineData("тап", "таптымбы")]
    [InlineData("чеч", "чечтимби")]
    [InlineData("ук", "уктумбу")]
    [InlineData("күт", "күттүмбү")]
    public void PastDefinite_Мен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбадымбы")]
    [InlineData("иште", "иштебедимби")]
    [InlineData("бол", "болбодумбу")]
    [InlineData("көр", "көрбөдүмбү")]
    [InlineData("тап", "таппадымбы")]
    [InlineData("чеч", "чечпедимби")]
    [InlineData("ук", "укпадымбы")]
    [InlineData("күт", "күтпөдүмбү")]
    public void PastDefinite_Мен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}