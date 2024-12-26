using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.FutureProbable;

namespace UnitTests.Tenses.FutureProbable;

public class FutureProbableСиздерTests
{
    [Theory]
    [InlineData("бар", "барарсыздар")]
    [InlineData("иште", "иштерсиздер")]
    [InlineData("бол", "болорсуздар")]
    [InlineData("көр", "көрөрсүздөр")]
    [InlineData("тап", "табарсыздар")]
    [InlineData("чеч", "чечерсиздер")]
    [InlineData("ук", "угарсыздар")]
    [InlineData("күт", "күтөрсүздөр")]
    [InlineData("кой", "коёрсуздар")]
    public void FutureProbable_Сиздер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барбассыздар")]
    [InlineData("иште", "иштебессиздер")]
    [InlineData("бол", "болбоссуздар")]
    [InlineData("көр", "көрбөссүздөр")]
    [InlineData("тап", "таппассыздар")]
    [InlineData("чеч", "чечпессиздер")]
    [InlineData("ук", "укпассыздар")]
    [InlineData("күт", "күтпөссүздөр")]
    public void FutureProbable_Сиздер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барарсыздарбы")]
    [InlineData("иште", "иштерсиздерби")]
    [InlineData("бол", "болорсуздарбы")]
    [InlineData("көр", "көрөрсүздөрбү")]
    [InlineData("тап", "табарсыздарбы")]
    [InlineData("чеч", "чечерсиздерби")]
    [InlineData("ук", "угарсыздарбы")]
    [InlineData("күт", "күтөрсүздөрбү")]
    [InlineData("кой", "коёрсуздарбы")]
    public void FutureProbable_Сиздер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбассыздарбы")]
    [InlineData("иште", "иштебессиздерби")]
    [InlineData("бол", "болбоссуздарбы")]
    [InlineData("көр", "көрбөссүздөрбү")]
    [InlineData("тап", "таппассыздарбы")]
    [InlineData("чеч", "чечпессиздерби")]
    [InlineData("ук", "укпассыздарбы")]
    [InlineData("күт", "күтпөссүздөрбү")]
    public void FutureProbable_Сиздер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}