using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.WithDifferentNegative.PastUsedTo;

namespace UnitTests.Tenses.Past.UsedTo;

public class PasUsedToСиздерTests
{
    [Theory]
    [InlineData("бар", "барчусуздар")]
    [InlineData("иште", "иштечүсүздөр")]
    [InlineData("бол", "болчусуздар")]
    [InlineData("көр", "көрчүсүздөр")]
    [InlineData("тап", "тапчусуздар")]
    [InlineData("чеч", "чеччүсүздөр")]
    [InlineData("ук", "укчусуздар")]
    [InlineData("күт", "күтчүсүздөр")]
    public void PastUsedTo_Сиздер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчу эмессиздер")]
    [InlineData("иште", "иштечү эмессиздер")]
    [InlineData("бол", "болчу эмессиздер")]
    [InlineData("көр", "көрчү эмессиздер")]
    [InlineData("тап", "тапчу эмессиздер")]
    [InlineData("чеч", "чеччү эмессиздер")]
    [InlineData("ук", "укчу эмессиздер")]
    [InlineData("күт", "күтчү эмессиздер")]
    public void PastUsedTo_Сиздер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчусуздарбы")]
    [InlineData("иште", "иштечүсүздөрбү")]
    [InlineData("бол", "болчусуздарбы")]
    [InlineData("көр", "көрчүсүздөрбү")]
    [InlineData("тап", "тапчусуздарбы")]
    [InlineData("чеч", "чеччүсүздөрбү")]
    [InlineData("ук", "укчусуздарбы")]
    [InlineData("күт", "күтчүсүздөрбү")]
    public void PastUsedTo_Сиздер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барчу эмессиздерби")]
    [InlineData("иште", "иштечү эмессиздерби")]
    [InlineData("бол", "болчу эмессиздерби")]
    [InlineData("көр", "көрчү эмессиздерби")]
    [InlineData("тап", "тапчу эмессиздерби")]
    [InlineData("чеч", "чеччү эмессиздерби")]
    [InlineData("ук", "укчу эмессиздерби")]
    [InlineData("күт", "күтчү эмессиздерби")]
    public void PastUsedTo_Сиздер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}