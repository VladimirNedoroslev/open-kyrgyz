using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.WithDifferentNegative.Intention;

namespace UnitTests.Intention;

public class IntentionСиздерTests
{
    [Theory]
    [InlineData("бар", "бармаксыздар")]
    [InlineData("иште", "иштемексиздер")]
    [InlineData("бол", "болмоксуздар")]
    [InlineData("көр", "көрмөксүздөр")]
    [InlineData("тап", "тапмаксыздар")]
    [InlineData("чеч", "чечмексиздер")]
    [InlineData("ук", "укмаксыздар")]
    [InlineData("күт", "күтмөксүздөр")]
    public void Intention_Сиздер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бармак эмессиздер")]
    [InlineData("иште", "иштемек эмессиздер")]
    [InlineData("бол", "болмок эмессиздер")]
    [InlineData("көр", "көрмөк эмессиздер")]
    [InlineData("тап", "тапмак эмессиздер")]
    [InlineData("чеч", "чечмек эмессиздер")]
    [InlineData("ук", "укмак эмессиздер")]
    [InlineData("күт", "күтмөк эмессиздер")]
    public void Intention_Сиздер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бармаксыздарбы")]
    [InlineData("иште", "иштемексиздерби")]
    [InlineData("бол", "болмоксуздарбы")]
    [InlineData("көр", "көрмөксүздөрбү")]
    [InlineData("тап", "тапмаксыздарбы")]
    [InlineData("чеч", "чечмексиздерби")]
    [InlineData("ук", "укмаксыздарбы")]
    [InlineData("күт", "күтмөксүздөрбү")]
    public void Intention_Сиздер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "бармак эмессиздерби")]
    [InlineData("иште", "иштемек эмессиздерби")]
    [InlineData("бол", "болмок эмессиздерби")]
    [InlineData("көр", "көрмөк эмессиздерби")]
    [InlineData("тап", "тапмак эмессиздерби")]
    [InlineData("чеч", "чечмек эмессиздерби")]
    [InlineData("ук", "укмак эмессиздерби")]
    [InlineData("күт", "күтмөк эмессиздерби")]
    public void Intention_Сиздер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}