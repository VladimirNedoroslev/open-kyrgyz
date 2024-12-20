using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.FutureProbable;

namespace UnitTests.FutureProbable;

public class FutureProbableАлTests
{
    [Theory]
    [InlineData("бар", "барар")]
    [InlineData("иште", "иштер")]
    [InlineData("бол", "болор")]
    [InlineData("көр", "көрөр")]
    [InlineData("тап", "табар")]
    [InlineData("чеч", "чечер")]
    [InlineData("ук", "угар")]
    [InlineData("күт", "күтөр")]
    public void FutureProbable_Ал_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    
    [Theory]
    [InlineData("бар", "барбас")]
    [InlineData("иште", "иштебес")]
    [InlineData("бол", "болбос")]
    [InlineData("көр", "көрбөс")]
    [InlineData("тап", "таппас")]
    [InlineData("чеч", "чечпес")]
    [InlineData("ук", "укпас")]
    [InlineData("күт", "күтпөс")]
    public void FutureProbable_Ал_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барарбы")]
    [InlineData("иште", "иштерби")]
    [InlineData("бол", "болорбу")]
    [InlineData("көр", "көрөрбү")]
    [InlineData("тап", "табарбы")]
    [InlineData("чеч", "чечерби")]
    [InlineData("ук", "угарбы")]
    [InlineData("күт", "күтөрбү")]
    public void FutureProbable_Ал_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барбаспы")]
    [InlineData("иште", "иштебеспи")]
    [InlineData("бол", "болбоспу")]
    [InlineData("көр", "көрбөспү")]
    [InlineData("тап", "таппаспы")]
    [InlineData("чеч", "чечпеспи")]
    [InlineData("ук", "укпаспы")]
    [InlineData("күт", "күтпөспү")]
    public void FutureProbable_Ал_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}