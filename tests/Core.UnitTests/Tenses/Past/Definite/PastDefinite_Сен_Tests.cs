using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PastDefinite;

namespace UnitTests.Tenses.Past.Definite;

public class PastDefiniteСенTests
{
    [Theory]
    [InlineData("бар", "бардың")]
    [InlineData("иште", "иштедиң")]
    [InlineData("бол", "болдуң")]
    [InlineData("көр", "көрдүң")]
    [InlineData("тап", "таптың")]
    [InlineData("чеч", "чечтиң")]
    [InlineData("ук", "уктуң")]
    [InlineData("күт", "күттүң")]
    public void PastDefinite_Сен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Сен,VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбадың")]
    [InlineData("иште", "иштебедиң")]
    [InlineData("бол", "болбодуң")]
    [InlineData("көр", "көрбөдүң")]
    [InlineData("тап", "таппадың")]
    [InlineData("чеч", "чечпедиң")]
    [InlineData("ук", "укпадың")]
    [InlineData("күт", "күтпөдүң")]
    public void PastDefinite_Сен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бардыңбы")]
    [InlineData("иште", "иштедиңби")]
    [InlineData("бол", "болдуңбу")]
    [InlineData("көр", "көрдүңбү")]
    [InlineData("тап", "таптыңбы")]
    [InlineData("чеч", "чечтиңби")]
    [InlineData("ук", "уктуңбу")]
    [InlineData("күт", "күттүңбү")]
    public void PastDefinite_Сен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбадыңбы")]
    [InlineData("иште", "иштебедиңби")]
    [InlineData("бол", "болбодуңбу")]
    [InlineData("көр", "көрбөдүңбү")]
    [InlineData("тап", "таппадыңбы")]
    [InlineData("чеч", "чечпедиңби")]
    [InlineData("ук", "укпадыңбы")]
    [InlineData("күт", "күтпөдүңбү")]
    public void PastDefinite_Сен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}