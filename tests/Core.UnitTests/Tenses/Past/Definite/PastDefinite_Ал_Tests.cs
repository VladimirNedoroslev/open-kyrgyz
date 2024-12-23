using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PastDefinite;

namespace UnitTests.Tenses.Past.Definite;

public class PastDefiniteАлTests
{
    [Theory]
    [InlineData("бар", "барды")]
    [InlineData("иште", "иштеди")]
    [InlineData("бол", "болду")]
    [InlineData("көр", "көрдү")]
    [InlineData("тап", "тапты")]
    [InlineData("чеч", "чечти")]
    [InlineData("ук", "укту")]
    [InlineData("күт", "күттү")]
    public void PastDefinite_Ал_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбады")]
    [InlineData("иште", "иштебеди")]
    [InlineData("бол", "болбоду")]
    [InlineData("көр", "көрбөдү")]
    [InlineData("тап", "таппады")]
    [InlineData("чеч", "чечпеди")]
    [InlineData("ук", "укпады")]
    [InlineData("күт", "күтпөдү")]
    public void PastDefinite_Ал_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бардыбы")]
    [InlineData("иште", "иштедиби")]
    [InlineData("бол", "болдубу")]
    [InlineData("көр", "көрдүбү")]
    [InlineData("тап", "таптыбы")]
    [InlineData("чеч", "чечтиби")]
    [InlineData("ук", "уктубу")]
    [InlineData("күт", "күттүбү")]
    public void PastDefinite_Ал_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбадыбы")]
    [InlineData("иште", "иштебедиби")]
    [InlineData("бол", "болбодубу")]
    [InlineData("көр", "көрбөдүбү")]
    [InlineData("тап", "таппадыбы")]
    [InlineData("чеч", "чечпедиби")]
    [InlineData("ук", "укпадыбы")]
    [InlineData("күт", "күтпөдүбү")]
    public void PastDefinite_Ал_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}