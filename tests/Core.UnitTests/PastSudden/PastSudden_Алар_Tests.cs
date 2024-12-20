using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PastSudden;

namespace UnitTests.PastSudden;

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
    public void PastSudden_Алар_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барбашыптыр")]
    [InlineData("иште", "иштебешиптир")]
    [InlineData("бол", "болбошуптур")]
    [InlineData("көр", "көрбөшүптүр")]
    [InlineData("тап", "таппашыптыр")]
    [InlineData("чеч", "чечпешиптир")]
    [InlineData("ук", "укпашыптыр")]
    [InlineData("күт", "күтпөшүптүр")]
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
    public void PastSudden_Алар_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    
    [Theory]
    [InlineData("бар", "барбашыптырбы")]
    [InlineData("иште", "иштебешиптирби")]
    [InlineData("бол", "болбошуптурбу")]
    [InlineData("көр", "көрбөшүптүрбү")]
    [InlineData("тап", "таппашыптырбы")]
    [InlineData("чеч", "чечпешиптирби")]
    [InlineData("ук", "укпашыптырбы")]
    [InlineData("күт", "күтпөшүптүрбү")]
    public void PastSudden_Алар_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}