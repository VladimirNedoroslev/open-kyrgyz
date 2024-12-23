using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.WithDifferentNegative.PastIndefinite;

namespace UnitTests.PastIndefinite;

public class PastIndefiniteСиздерTests
{
    [Theory]
    [InlineData("бар", "баргансыздар")]
    [InlineData("иште", "иштегенсиздер")]
    [InlineData("бол", "болгонсуздар")]
    [InlineData("көр", "көргөнсүздөр")]
    [InlineData("тап", "тапкансыздар")]
    [InlineData("чеч", "чечкенсиздер")]
    [InlineData("ук", "уккансыздар")]
    [InlineData("күт", "күткөнсүздөр")]
    public void PastIndefinite_Сиздер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барган эмессиздер")]
    [InlineData("иште", "иштеген эмессиздер")]
    [InlineData("бол", "болгон эмессиздер")]
    [InlineData("көр", "көргөн эмессиздер")]
    [InlineData("тап", "тапкан эмессиздер")]
    [InlineData("чеч", "чечкен эмессиздер")]
    [InlineData("ук", "уккан эмессиздер")]
    [InlineData("күт", "күткөн эмессиздер")]
    public void PastIndefinite_Сиздер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "баргансыздарбы")]
    [InlineData("иште", "иштегенсиздерби")]
    [InlineData("бол", "болгонсуздарбы")]
    [InlineData("көр", "көргөнсүздөрбү")]
    [InlineData("тап", "тапкансыздарбы")]
    [InlineData("чеч", "чечкенсиздерби")]
    [InlineData("ук", "уккансыздарбы")]
    [InlineData("күт", "күткөнсүздөрбү")]
    public void PastIndefinite_Сиздер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барган эмессиздерби")]
    [InlineData("иште", "иштеген эмессиздерби")]
    [InlineData("бол", "болгон эмессиздерби")]
    [InlineData("көр", "көргөн эмессиздерби")]
    [InlineData("тап", "тапкан эмессиздерби")]
    [InlineData("чеч", "чечкен эмессиздерби")]
    [InlineData("ук", "уккан эмессиздерби")]
    [InlineData("күт", "күткөн эмессиздерби")]
    public void PastIndefinite_Сиздер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}