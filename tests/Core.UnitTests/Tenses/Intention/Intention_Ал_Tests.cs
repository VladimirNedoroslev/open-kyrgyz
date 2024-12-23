using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.WithDifferentNegative.Intention;

namespace UnitTests.Tenses.Intention;

public class IntentionАлTests
{
    [Theory]
    [InlineData("бар", "бармак")]
    [InlineData("иште", "иштемек")]
    [InlineData("бол", "болмок")]
    [InlineData("көр", "көрмөк")]
    [InlineData("тап", "тапмак")]
    [InlineData("чеч", "чечмек")]
    [InlineData("ук", "укмак")]
    [InlineData("күт", "күтмөк")]
    public void Intention_Ал_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "бармак эмес")]
    [InlineData("иште", "иштемек эмес")]
    [InlineData("бол", "болмок эмес")]
    [InlineData("көр", "көрмөк эмес")]
    [InlineData("тап", "тапмак эмес")]
    [InlineData("чеч", "чечмек эмес")]
    [InlineData("ук", "укмак эмес")]
    [InlineData("күт", "күтмөк эмес")]
    public void Intention_Ал_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "бармакпы")]
    [InlineData("иште", "иштемекпи")]
    [InlineData("бол", "болмокпу")]
    [InlineData("көр", "көрмөкпү")]
    [InlineData("тап", "тапмакпы")]
    [InlineData("чеч", "чечмекпи")]
    [InlineData("ук", "укмакпы")]
    [InlineData("күт", "күтмөкпү")]
    public void Intention_Ал_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    
    [Theory]
    [InlineData("бар", "бармак эмеспи")]
    [InlineData("иште", "иштемек эмеспи")]
    [InlineData("бол", "болмок эмеспи")]
    [InlineData("көр", "көрмөк эмеспи")]
    [InlineData("тап", "тапмак эмеспи")]
    [InlineData("чеч", "чечмек эмеспи")]
    [InlineData("ук", "укмак эмеспи")]
    [InlineData("күт", "күтмөк эмеспи")]
    public void Intention_Ал_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}