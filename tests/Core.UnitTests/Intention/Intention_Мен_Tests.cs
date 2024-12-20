using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.WithDifferentNegative.Intention;

namespace UnitTests.Intention;

public class IntentionМенTests
{
    [Theory]
    [InlineData("бар", "бармакмын")]
    [InlineData("иште", "иштемекмин")]
    [InlineData("бол", "болмокмун")]
    [InlineData("көр", "көрмөкмүн")]
    [InlineData("тап", "тапмакмын")]
    [InlineData("чеч", "чечмекмин")]
    [InlineData("ук", "укмакмын")]
    [InlineData("күт", "күтмөкмүн")]
    public void Intention_Мен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "бармак эмесмин")]
    [InlineData("иште", "иштемек эмесмин")]
    [InlineData("бол", "болмок эмесмин")]
    [InlineData("көр", "көрмөк эмесмин")]
    [InlineData("тап", "тапмак эмесмин")]
    [InlineData("чеч", "чечмек эмесмин")]
    [InlineData("ук", "укмак эмесмин")]
    [InlineData("күт", "күтмөк эмесмин")]
    public void Intention_Мен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "бармакмынбы")]
    [InlineData("иште", "иштемекминби")]
    [InlineData("бол", "болмокмунбу")]
    [InlineData("көр", "көрмөкмүнбү")]
    [InlineData("тап", "тапмакмынбы")]
    [InlineData("чеч", "чечмекминби")]
    [InlineData("ук", "укмакмынбы")]
    [InlineData("күт", "күтмөкмүнбү")]
    public void Intention_Мен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    
    [Theory]
    [InlineData("бар", "бармак эмесминби")]
    [InlineData("иште", "иштемек эмесминби")]
    [InlineData("бол", "болмок эмесминби")]
    [InlineData("көр", "көрмөк эмесминби")]
    [InlineData("тап", "тапмак эмесминби")]
    [InlineData("чеч", "чечмек эмесминби")]
    [InlineData("ук", "укмак эмесминби")]
    [InlineData("күт", "күтмөк эмесминби")]
    public void Intention_Мен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}