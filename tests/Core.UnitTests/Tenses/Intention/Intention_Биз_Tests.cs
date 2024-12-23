using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.WithDifferentNegative.Intention;

namespace UnitTests.Tenses.Intention;

public class IntentionБизTests
{
    [Theory]
    [InlineData("бар", "бармакпыз")]
    [InlineData("иште", "иштемекпиз")]
    [InlineData("бол", "болмокпуз")]
    [InlineData("көр", "көрмөкпүз")]
    [InlineData("тап", "тапмакпыз")]
    [InlineData("чеч", "чечмекпиз")]
    [InlineData("ук", "укмакпыз")]
    [InlineData("күт", "күтмөкпүз")]
    public void Intention_Биз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бармак эмеспиз")]
    [InlineData("иште", "иштемек эмеспиз")]
    [InlineData("бол", "болмок эмеспиз")]
    [InlineData("көр", "көрмөк эмеспиз")]
    [InlineData("тап", "тапмак эмеспиз")]
    [InlineData("чеч", "чечмек эмеспиз")]
    [InlineData("ук", "укмак эмеспиз")]
    [InlineData("күт", "күтмөк эмеспиз")]
    public void Intention_Биз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бармакпызбы")]
    [InlineData("иште", "иштемекпизби")]
    [InlineData("бол", "болмокпузбу")]
    [InlineData("көр", "көрмөкпүзбү")]
    [InlineData("тап", "тапмакпызбы")]
    [InlineData("чеч", "чечмекпизби")]
    [InlineData("ук", "укмакпызбы")]
    [InlineData("күт", "күтмөкпүзбү")]
    public void Intention_Биз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "бармак эмеспизби")]
    [InlineData("иште", "иштемек эмеспизби")]
    [InlineData("бол", "болмок эмеспизби")]
    [InlineData("көр", "көрмөк эмеспизби")]
    [InlineData("тап", "тапмак эмеспизби")]
    [InlineData("чеч", "чечмек эмеспизби")]
    [InlineData("ук", "укмак эмеспизби")]
    [InlineData("күт", "күтмөк эмеспизби")]
    public void Intention_Биз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}