using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PastSudden;

namespace UnitTests.Tenses.Past.Sudden;

public class PastSuddenАлTests
{
   
    [Theory]
    [InlineData("бар", "барыптыр")]
    [InlineData("иште", "иштептир")]
    [InlineData("бол", "болуптур")]
    [InlineData("көр", "көрүптүр")]
    [InlineData("тап", "табыптыр")]
    [InlineData("чеч", "чечиптир")]
    [InlineData("ук", "угуптур")]
    [InlineData("күт", "күтүптүр")]
    [InlineData("кой", "коюптур")]
    public void PastSudden_Ал_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барбаптыр")]
    [InlineData("иште", "иштебептир")]
    [InlineData("бол", "болбоптур")]
    [InlineData("көр", "көрбөптүр")]
    [InlineData("тап", "таппаптыр")]
    [InlineData("чеч", "чечпептир")]
    [InlineData("ук", "укпаптыр")]
    [InlineData("күт", "күтпөптүр")]
    public void PastSudden_Ал_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барыптырбы")]
    [InlineData("иште", "иштептирби")]
    [InlineData("бол", "болуптурбу")]
    [InlineData("көр", "көрүптүрбү")]
    [InlineData("тап", "табыптырбы")]
    [InlineData("чеч", "чечиптирби")]
    [InlineData("ук", "угуптурбу")]
    [InlineData("күт", "күтүптүрбү")]
    [InlineData("кой", "коюптурбу")]
    public void PastSudden_Ал_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    
    [Theory]
    [InlineData("бар", "барбаптырбы")]
    [InlineData("иште", "иштебептирби")]
    [InlineData("бол", "болбоптурбу")]
    [InlineData("көр", "көрбөптүрбү")]
    [InlineData("тап", "таппаптырбы")]
    [InlineData("чеч", "чечпептирби")]
    [InlineData("ук", "укпаптырбы")]
    [InlineData("күт", "күтпөптүрбү")]
    public void PastSudden_Ал_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}