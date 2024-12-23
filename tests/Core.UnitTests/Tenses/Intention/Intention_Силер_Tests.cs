using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.WithDifferentNegative.Intention;

namespace UnitTests.Tenses.Intention;

public class IntentionСилерTests
{
    [Theory]
    [InlineData("бар", "бармаксыңар")]
    [InlineData("иште", "иштемексиңер")]
    [InlineData("бол", "болмоксуңар")]
    [InlineData("көр", "көрмөксүңөр")]
    [InlineData("тап", "тапмаксыңар")]
    [InlineData("чеч", "чечмексиңер")]
    [InlineData("ук", "укмаксыңар")]
    [InlineData("күт", "күтмөксүңөр")]
    public void Intention_Силер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бармак эмессиңер")]
    [InlineData("иште", "иштемек эмессиңер")]
    [InlineData("бол", "болмок эмессиңер")]
    [InlineData("көр", "көрмөк эмессиңер")]
    [InlineData("тап", "тапмак эмессиңер")]
    [InlineData("чеч", "чечмек эмессиңер")]
    [InlineData("ук", "укмак эмессиңер")]
    [InlineData("күт", "күтмөк эмессиңер")]
    public void Intention_Силер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бармаксыңарбы")]
    [InlineData("иште", "иштемексиңерби")]
    [InlineData("бол", "болмоксуңарбы")]
    [InlineData("көр", "көрмөксүңөрбү")]
    [InlineData("тап", "тапмаксыңарбы")]
    [InlineData("чеч", "чечмексиңерби")]
    [InlineData("ук", "укмаксыңарбы")]
    [InlineData("күт", "күтмөксүңөрбү")]
    public void Intention_Силер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "бармак эмессиңерби")]
    [InlineData("иште", "иштемек эмессиңерби")]
    [InlineData("бол", "болмок эмессиңерби")]
    [InlineData("көр", "көрмөк эмессиңерби")]
    [InlineData("тап", "тапмак эмессиңерби")]
    [InlineData("чеч", "чечмек эмессиңерби")]
    [InlineData("ук", "укмак эмессиңерби")]
    [InlineData("күт", "күтмөк эмессиңерби")]
    public void Intention_Силер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}