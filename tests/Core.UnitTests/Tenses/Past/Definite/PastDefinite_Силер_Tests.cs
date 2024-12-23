using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PastDefinite;

namespace UnitTests.PastDefinite;

public class PastDefiniteСилерTests
{
    [Theory]
    [InlineData("бар", "бардыңар")]
    [InlineData("иште", "иштедиңер")]
    [InlineData("бол", "болдуңар")]
    [InlineData("көр", "көрдүңөр")]
    [InlineData("тап", "таптыңар")]
    [InlineData("чеч", "чечтиңер")]
    [InlineData("ук", "уктуңар")]
    [InlineData("күт", "күттүңөр")]
    public void PastDefinite_Силер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Силер,VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбадыңар")]
    [InlineData("иште", "иштебедиңер")]
    [InlineData("бол", "болбодуңар")]
    [InlineData("көр", "көрбөдүңөр")]
    [InlineData("тап", "таппадыңар")]
    [InlineData("чеч", "чечпедиңер")]
    [InlineData("ук", "укпадыңар")]
    [InlineData("күт", "күтпөдүңөр")]
    public void PastDefinite_Силер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бардыңарбы")]
    [InlineData("иште", "иштедиңерби")]
    [InlineData("бол", "болдуңарбы")]
    [InlineData("көр", "көрдүңөрбү")]
    [InlineData("тап", "таптыңарбы")]
    [InlineData("чеч", "чечтиңерби")]
    [InlineData("ук", "уктуңарбы")]
    [InlineData("күт", "күттүңөрбү")]
    public void PastDefinite_Силер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбадыңарбы")]
    [InlineData("иште", "иштебедиңерби")]
    [InlineData("бол", "болбодуңарбы")]
    [InlineData("көр", "көрбөдүңөрбү")]
    [InlineData("тап", "таппадыңарбы")]
    [InlineData("чеч", "чечпедиңерби")]
    [InlineData("ук", "укпадыңарбы")]
    [InlineData("күт", "күтпөдүңөрбү")]
    public void PastDefinite_Силер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}