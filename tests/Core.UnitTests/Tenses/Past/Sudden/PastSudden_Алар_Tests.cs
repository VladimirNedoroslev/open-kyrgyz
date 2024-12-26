using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.PastSudden;

namespace UnitTests.Tenses.Past.Sudden;

public class PastSuddenАларTests
{
    [Theory]
    [InlineData("бар", "барышыптыр")]
    [InlineData("иште", "иштешиптир")]
    [InlineData("бол", "болушуптур")]
    [InlineData("көр", "көрүшүптүр")]
    [InlineData("тап", "табышыптыр")]
    [InlineData("чеч", "чечишиптир")]
    [InlineData("ук", "угушуптур")]
    [InlineData("күт", "күтүшүптүр")]
    [InlineData("кой", "коюшуптур")]
    public void PastSudden_Алар_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барышпаптыр")]
    [InlineData("иште", "иштешпептир")]
    [InlineData("бол", "болушпаптыр")]
    [InlineData("көр", "көрүшпөптүр")]
    [InlineData("тап", "табышпаптыр")]
    [InlineData("чеч", "чечишпептир")]
    [InlineData("ук", "угушпаптыр")]
    [InlineData("күт", "күтүшпөптүр")]
    public void PastSudden_Алар_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барышыптырбы")]
    [InlineData("иште", "иштешиптирби")]
    [InlineData("бол", "болушуптурбу")]
    [InlineData("көр", "көрүшүптүрбү")]
    [InlineData("тап", "табышыптырбы")]
    [InlineData("чеч", "чечишиптирби")]
    [InlineData("ук", "угушуптурбу")]
    [InlineData("күт", "күтүшүптүрбү")]
    [InlineData("кой", "коюшуптурбу")]
    public void PastSudden_Алар_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барышпаптырбы")]
    [InlineData("иште", "иштешпептирби")]
    [InlineData("бол", "болушпаптырбы")]
    [InlineData("көр", "көрүшпөптүрбү")]
    [InlineData("тап", "табышпаптырбы")]
    [InlineData("чеч", "чечишпептирби")]
    [InlineData("ук", "угушпаптырбы")]
    [InlineData("күт", "күтүшпөптүрбү")]
    public void PastSudden_Алар_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}