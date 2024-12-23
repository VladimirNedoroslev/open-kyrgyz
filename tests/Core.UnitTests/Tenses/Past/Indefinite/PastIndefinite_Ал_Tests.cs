using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.WithDifferentNegative.PastIndefinite;

namespace UnitTests.Tenses.Past.Indefinite;

public class PastIndefiniteАлTests
{
    [Theory]
    [InlineData("бар", "барган")]
    [InlineData("иште", "иштеген")]
    [InlineData("бол", "болгон")]
    [InlineData("көр", "көргөн")]
    [InlineData("тап", "тапкан")]
    [InlineData("чеч", "чечкен")]
    [InlineData("ук", "уккан")]
    [InlineData("күт", "күткөн")]
    public void PastIndefinite_Ал_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барган эмес")]
    [InlineData("иште", "иштеген эмес")]
    [InlineData("бол", "болгон эмес")]
    [InlineData("көр", "көргөн эмес")]
    [InlineData("тап", "тапкан эмес")]
    [InlineData("чеч", "чечкен эмес")]
    [InlineData("ук", "уккан эмес")]
    [InlineData("күт", "күткөн эмес")]
    public void PastIndefinite_Ал_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барганбы")]
    [InlineData("иште", "иштегенби")]
    [InlineData("бол", "болгонбу")]
    [InlineData("көр", "көргөнбү")]
    [InlineData("тап", "тапканбы")]
    [InlineData("чеч", "чечкенби")]
    [InlineData("ук", "укканбы")]
    [InlineData("күт", "күткөнбү")]
    public void PastIndefinite_Ал_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барган эмеспи")]
    [InlineData("иште", "иштеген эмеспи")]
    [InlineData("бол", "болгон эмеспи")]
    [InlineData("көр", "көргөн эмеспи")]
    [InlineData("тап", "тапкан эмеспи")]
    [InlineData("чеч", "чечкен эмеспи")]
    [InlineData("ук", "уккан эмеспи")]
    [InlineData("күт", "күткөн эмеспи")]
    public void PastIndefinite_Ал_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Ал, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}