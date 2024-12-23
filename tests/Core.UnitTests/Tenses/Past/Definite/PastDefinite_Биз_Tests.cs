using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PastDefinite;

namespace UnitTests.Tenses.Past.Definite;

public class PastDefiniteБизTests
{
    [Theory]
    [InlineData("бар", "бардык")]
    [InlineData("иште", "иштедик")]
    [InlineData("бол", "болдук")]
    [InlineData("көр", "көрдүк")]
    [InlineData("тап", "таптык")]
    [InlineData("чеч", "чечтик")]
    [InlineData("ук", "уктук")]
    [InlineData("күт", "күттүк")]
    public void PastDefinite_Биз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбадык")]
    [InlineData("иште", "иштебедик")]
    [InlineData("бол", "болбодук")]
    [InlineData("көр", "көрбөдүк")]
    [InlineData("тап", "таппадык")]
    [InlineData("чеч", "чечпедик")]
    [InlineData("ук", "укпадык")]
    [InlineData("күт", "күтпөдүк")]
    public void PastDefinite_Биз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бардыкпы")]
    [InlineData("иште", "иштедикпи")]
    [InlineData("бол", "болдукпу")]
    [InlineData("көр", "көрдүкпү")]
    [InlineData("тап", "таптыкпы")]
    [InlineData("чеч", "чечтикпи")]
    [InlineData("ук", "уктукпу")]
    [InlineData("күт", "күттүкпү")]
    public void PastDefinite_Биз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбадыкпы")]
    [InlineData("иште", "иштебедикпи")]
    [InlineData("бол", "болбодукпу")]
    [InlineData("көр", "көрбөдүкпү")]
    [InlineData("тап", "таппадыкпы")]
    [InlineData("чеч", "чечпедикпи")]
    [InlineData("ук", "укпадыкпы")]
    [InlineData("күт", "күтпөдүкпү")]
    public void PastDefinite_Биз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}