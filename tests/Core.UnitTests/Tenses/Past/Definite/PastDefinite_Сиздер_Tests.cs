using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.PastDefinite;

namespace UnitTests.Tenses.Past.Definite;

public class PastDefiniteСиздерTests
{
    [Theory]
    [InlineData("бар", "бардыңыздар")]
    [InlineData("иште", "иштедиңиздер")]
    [InlineData("бол", "болдуңуздар")]
    [InlineData("көр", "көрдүңүздөр")]
    [InlineData("тап", "таптыңыздар")]
    [InlineData("чеч", "чечтиңиздер")]
    [InlineData("ук", "уктуңуздар")]
    [InlineData("күт", "күттүңүздөр")]
    public void PastDefinite_Сиздер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбадыңыздар")]
    [InlineData("иште", "иштебедиңиздер")]
    [InlineData("бол", "болбодуңуздар")]
    [InlineData("көр", "көрбөдүңүздөр")]
    [InlineData("тап", "таппадыңыздар")]
    [InlineData("чеч", "чечпедиңиздер")]
    [InlineData("ук", "укпадыңыздар")]
    [InlineData("күт", "күтпөдүңүздөр")]
    public void PastDefinite_Сиздер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бардыңыздарбы")]
    [InlineData("иште", "иштедиңиздерби")]
    [InlineData("бол", "болдуңуздарбы")]
    [InlineData("көр", "көрдүңүздөрбү")]
    [InlineData("тап", "таптыңыздарбы")]
    [InlineData("чеч", "чечтиңиздерби")]
    [InlineData("ук", "уктуңуздарбы")]
    [InlineData("күт", "күттүңүздөрбү")]
    public void PastDefinite_Сиздер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбадыңыздарбы")]
    [InlineData("иште", "иштебедиңиздерби")]
    [InlineData("бол", "болбодуңуздарбы")]
    [InlineData("көр", "көрбөдүңүздөрбү")]
    [InlineData("тап", "таппадыңыздарбы")]
    [InlineData("чеч", "чечпедиңиздерби")]
    [InlineData("ук", "укпадыңыздарбы")]
    [InlineData("күт", "күтпөдүңүздөрбү")]
    public void PastDefinite_Сиздер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}