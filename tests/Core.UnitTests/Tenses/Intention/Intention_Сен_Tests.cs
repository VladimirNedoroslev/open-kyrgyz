using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.WithDifferentNegative.Intention;

namespace UnitTests.Tenses.Intention;

public class IntentionСенTests
{
    [Theory]
    [InlineData("бар", "бармаксың")]
    [InlineData("иште", "иштемексиң")]
    [InlineData("бол", "болмоксуң")]
    [InlineData("көр", "көрмөксүң")]
    [InlineData("тап", "тапмаксың")]
    [InlineData("чеч", "чечмексиң")]
    [InlineData("ук", "укмаксың")]
    [InlineData("күт", "күтмөксүң")]
    public void Intention_Сен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "бармак эмессиң")]
    [InlineData("иште", "иштемек эмессиң")]
    [InlineData("бол", "болмок эмессиң")]
    [InlineData("көр", "көрмөк эмессиң")]
    [InlineData("тап", "тапмак эмессиң")]
    [InlineData("чеч", "чечмек эмессиң")]
    [InlineData("ук", "укмак эмессиң")]
    [InlineData("күт", "күтмөк эмессиң")]
    public void Intention_Сен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "бармаксыңбы")]
    [InlineData("иште", "иштемексиңби")]
    [InlineData("бол", "болмоксуңбу")]
    [InlineData("көр", "көрмөксүңбү")]
    [InlineData("тап", "тапмаксыңбы")]
    [InlineData("чеч", "чечмексиңби")]
    [InlineData("ук", "укмаксыңбы")]
    [InlineData("күт", "күтмөксүңбү")]
    public void Intention_Сен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    
    [Theory]
    [InlineData("бар", "бармак эмессиңби")]
    [InlineData("иште", "иштемек эмессиңби")]
    [InlineData("бол", "болмок эмессиңби")]
    [InlineData("көр", "көрмөк эмессиңби")]
    [InlineData("тап", "тапмак эмессиңби")]
    [InlineData("чеч", "чечмек эмессиңби")]
    [InlineData("ук", "укмак эмессиңби")]
    [InlineData("күт", "күтмөк эмессиңби")]
    public void Intention_Сен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}