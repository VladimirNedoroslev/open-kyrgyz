using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.WithDifferentNegative.Intention;

namespace UnitTests.Tenses.Intention;

public class IntentionАларTests
{
    [Theory]
    [InlineData("бар", "барышмак")]
    [InlineData("иште", "иштешмек")]
    [InlineData("бол", "болушмак")]
    [InlineData("көр", "көрүшмөк")]
    [InlineData("тап", "табышмак")]
    [InlineData("чеч", "чечишмек")]
    [InlineData("ук", "угушмак")]
    [InlineData("күт", "күтүшмөк")]
    public void Intention_Алар_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барышмак эмес")]
    [InlineData("иште", "иштешмек эмес")]
    [InlineData("бол", "болушмак эмес")]
    [InlineData("көр", "көрүшмөк эмес")]
    [InlineData("тап", "табышмак эмес")]
    [InlineData("чеч", "чечишмек эмес")]
    [InlineData("ук", "угушмак эмес")]
    [InlineData("күт", "күтүшмөк эмес")]
    public void Intention_Алар_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барышмакпы")]
    [InlineData("иште", "иштешмекпи")]
    [InlineData("бол", "болушмакпы")]
    [InlineData("көр", "көрүшмөкпү")]
    [InlineData("тап", "табышмакпы")]
    [InlineData("чеч", "чечишмекпи")]
    [InlineData("ук", "угушмакпы")]
    [InlineData("күт", "күтүшмөкпү")]
    public void Intention_Алар_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барышмак эмеспи")]
    [InlineData("иште", "иштешмек эмеспи")]
    [InlineData("бол", "болушмак эмеспи")]
    [InlineData("көр", "көрүшмөк эмеспи")]
    [InlineData("тап", "табышмак эмеспи")]
    [InlineData("чеч", "чечишмек эмеспи")]
    [InlineData("ук", "угушмак эмеспи")]
    [InlineData("күт", "күтүшмөк эмеспи")]
    public void Intention_Алар_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = IntentionConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}