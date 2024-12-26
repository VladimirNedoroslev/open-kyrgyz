using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.WithDifferentNegative.Intention;

namespace UnitTests.Tenses.Intention;

public class IntentionСизTests
{
    [Theory]
    [InlineData("бар", "бармаксыз")]
    [InlineData("иште", "иштемексиз")]
    [InlineData("бол", "болмоксуз")]
    [InlineData("көр", "көрмөксүз")]
    [InlineData("тап", "тапмаксыз")]
    [InlineData("чеч", "чечмексиз")]
    [InlineData("ук", "укмаксыз")]
    [InlineData("күт", "күтмөксүз")]
    public void Intention_Сиз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бармак эмессиз")]
    [InlineData("иште", "иштемек эмессиз")]
    [InlineData("бол", "болмок эмессиз")]
    [InlineData("көр", "көрмөк эмессиз")]
    [InlineData("тап", "тапмак эмессиз")]
    [InlineData("чеч", "чечмек эмессиз")]
    [InlineData("ук", "укмак эмессиз")]
    [InlineData("күт", "күтмөк эмессиз")]
    public void Intention_Сиз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бармаксызбы")]
    [InlineData("иште", "иштемексизби")]
    [InlineData("бол", "болмоксузбу")]
    [InlineData("көр", "көрмөксүзбү")]
    [InlineData("тап", "тапмаксызбы")]
    [InlineData("чеч", "чечмексизби")]
    [InlineData("ук", "укмаксызбы")]
    [InlineData("күт", "күтмөксүзбү")]
    public void Intention_Сиз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "бармак эмессизби")]
    [InlineData("иште", "иштемек эмессизби")]
    [InlineData("бол", "болмок эмессизби")]
    [InlineData("көр", "көрмөк эмессизби")]
    [InlineData("тап", "тапмак эмессизби")]
    [InlineData("чеч", "чечмек эмессизби")]
    [InlineData("ук", "укмак эмессизби")]
    [InlineData("күт", "күтмөк эмессизби")]
    public void Intention_Сиз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}