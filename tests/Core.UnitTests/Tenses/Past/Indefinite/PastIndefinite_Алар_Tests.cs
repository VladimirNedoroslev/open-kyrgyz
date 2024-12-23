using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.WithDifferentNegative.PastIndefinite;

namespace UnitTests.Tenses.Past.Indefinite;

public class PastIndefiniteАларTests
{
    [Theory]
    [InlineData("бар", "барышкан")]
    [InlineData("иште", "иштешкен")]
    [InlineData("бол", "болушкан")]
    [InlineData("көр", "көрүшкөн")]
    [InlineData("тап", "табышкан")]
    [InlineData("чеч", "чечишкен")]
    [InlineData("ук", "угушкан")]
    [InlineData("күт", "күтүшкөн")]
    public void PastIndefinite_Алар(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барышкан эмес")]
    [InlineData("иште", "иштешкен эмес")]
    [InlineData("бол", "болушкан эмес")]
    [InlineData("көр", "көрүшкөн эмес")]
    [InlineData("тап", "табышкан эмес")]
    [InlineData("чеч", "чечишкен эмес")]
    [InlineData("ук", "угушкан эмес")]
    [InlineData("күт", "күтүшкөн эмес")]
    public void PastIndefinite_Алар_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барышканбы")]
    [InlineData("иште", "иштешкенби")]
    [InlineData("бол", "болушканбы")]
    [InlineData("көр", "көрүшкөнбү")]
    [InlineData("тап", "табышканбы")]
    [InlineData("чеч", "чечишкенби")]
    [InlineData("ук", "угушканбы")]
    [InlineData("күт", "күтүшкөнбү")]
    public void PastIndefinite_Алар_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барышкан эмеспи")]
    [InlineData("иште", "иштешкен эмеспи")]
    [InlineData("бол", "болушкан эмеспи")]
    [InlineData("көр", "көрүшкөн эмеспи")]
    [InlineData("тап", "табышкан эмеспи")]
    [InlineData("чеч", "чечишкен эмеспи")]
    [InlineData("ук", "угушкан эмеспи")]
    [InlineData("күт", "күтүшкөн эмеспи")]
    public void PastIndefinite_Алар_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Алар, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}