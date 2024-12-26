using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.PastDefinite;

namespace UnitTests.Tenses.Past.Definite;

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
    [InlineData("бар", "барышпады")]
    [InlineData("иште", "иштешпеди")]
    [InlineData("бол", "болушпады")]
    [InlineData("көр", "көрүшпөдү")]
    [InlineData("тап", "табышпады")]
    [InlineData("чеч", "чечишпеди")]
    [InlineData("ук", "угушпады")]
    [InlineData("күт", "күтүшпөдү")]
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
    [InlineData("бар", "барышпадыбы")]
    [InlineData("иште", "иштешпедиби")]
    [InlineData("бол", "болушпадыбы")]
    [InlineData("көр", "көрүшпөдүбү")]
    [InlineData("тап", "табышпадыбы")]
    [InlineData("чеч", "чечишпедиби")]
    [InlineData("ук", "угушпадыбы")]
    [InlineData("күт", "күтүшпөдүбү")]
    public void PastDefinite_Алар_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}