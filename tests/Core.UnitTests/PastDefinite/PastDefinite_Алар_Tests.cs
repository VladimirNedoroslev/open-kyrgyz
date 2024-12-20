using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PastDefinite;

namespace UnitTests.PastDefinite;

public class PastDefiniteАларTests
{
    [Theory]
    [InlineData("бар", "барышты")]
    [InlineData("иште", "иштешти")]
    [InlineData("бол", "болушту")]
    [InlineData("көр", "көрүштү")]
    [InlineData("тап", "табышты")]
    [InlineData("чеч", "чечишти")]
    [InlineData("ук", "угушту")]
    [InlineData("күт", "күтүштү")]
    public void PastDefinite_Алар_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбашты")]
    [InlineData("иште", "иштебешти")]
    [InlineData("бол", "болбошту")]
    [InlineData("көр", "көрбөштү")]
    [InlineData("тап", "таппашты")]
    [InlineData("чеч", "чечпешти")]
    [InlineData("ук", "укпашты")]
    [InlineData("күт", "күтпөштү")]
    public void PastDefinite_Алар_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барыштыбы")]
    [InlineData("иште", "иштештиби")]
    [InlineData("бол", "болуштубу")]
    [InlineData("көр", "көрүштүбү")]
    [InlineData("тап", "табыштыбы")]
    [InlineData("чеч", "чечиштиби")]
    [InlineData("ук", "угуштубу")]
    [InlineData("күт", "күтүштүбү")]
    public void PastDefinite_Алар_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбаштыбы")]
    [InlineData("иште", "иштебештиби")]
    [InlineData("бол", "болбоштубу")]
    [InlineData("көр", "көрбөштүбү")]
    [InlineData("тап", "таппаштыбы")]
    [InlineData("чеч", "чечпештиби")]
    [InlineData("ук", "укпаштыбы")]
    [InlineData("күт", "күтпөштүбү")]
    public void PastDefinite_Алар_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}