using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.FutureProbable;

namespace UnitTests.Tenses.FutureProbable;

public class FutureProbableАларTests
{
    [Theory]
    [InlineData("бар", "барышар")]
    [InlineData("иште", "иштешер")]
    [InlineData("бол", "болушар")]
    [InlineData("көр", "көрүшөр")]
    [InlineData("тап", "табышар")]
    [InlineData("чеч", "чечишер")]
    [InlineData("ук", "угушар")]
    [InlineData("күт", "күтүшөр")]
    [InlineData("кой", "коюшар")]
    public void FutureProbable_Алар_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барышпас")]
    [InlineData("иште", "иштешпес")]
    [InlineData("бол", "болушпас")]
    [InlineData("көр", "көрүшпөс")]
    [InlineData("тап", "табышпас")]
    [InlineData("чеч", "чечишпес")]
    [InlineData("ук", "угушпас")]
    [InlineData("күт", "күтүшпөс")]
    public void FutureProbable_Алар_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барышарбы")]
    [InlineData("иште", "иштешерби")]
    [InlineData("бол", "болушарбы")]
    [InlineData("көр", "көрүшөрбү")]
    [InlineData("тап", "табышарбы")]
    [InlineData("чеч", "чечишерби")]
    [InlineData("ук", "угушарбы")]
    [InlineData("күт", "күтүшөрбү")]
    [InlineData("кой", "коюшарбы")]
    public void FutureProbable_Алар_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барышпаспы")]
    [InlineData("иште", "иштешпеспи")]
    [InlineData("бол", "болушпаспы")]
    [InlineData("көр", "көрүшпөспү")]
    [InlineData("тап", "табышпаспы")]
    [InlineData("чеч", "чечишпеспи")]
    [InlineData("ук", "угушпаспы")]
    [InlineData("күт", "күтүшпөспү")]
    public void FutureProbable_Алар_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}