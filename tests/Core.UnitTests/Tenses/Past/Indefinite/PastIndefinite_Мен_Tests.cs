using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.WithDifferentNegative.PastIndefinite;

namespace UnitTests.Tenses.Past.Indefinite;

public class PastIndefiniteМенTests
{
    [Theory]
    [InlineData("бар", "барганмын")]
    [InlineData("иште", "иштегенмин")]
    [InlineData("бол", "болгонмун")]
    [InlineData("көр", "көргөнмүн")]
    [InlineData("тап", "тапканмын")]
    [InlineData("чеч", "чечкенмин")]
    [InlineData("ук", "укканмын")]
    [InlineData("күт", "күткөнмүн")]
    public void PastIndefinite_Мен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барган эмесмин")]
    [InlineData("иште", "иштеген эмесмин")]
    [InlineData("бол", "болгон эмесмин")]
    [InlineData("көр", "көргөн эмесмин")]
    [InlineData("тап", "тапкан эмесмин")]
    [InlineData("чеч", "чечкен эмесмин")]
    [InlineData("ук", "уккан эмесмин")]
    [InlineData("күт", "күткөн эмесмин")]
    public void PastIndefinite_Мен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барганмынбы")]
    [InlineData("иште", "иштегенминби")]
    [InlineData("бол", "болгонмунбу")]
    [InlineData("көр", "көргөнмүнбү")]
    [InlineData("тап", "тапканмынбы")]
    [InlineData("чеч", "чечкенминби")]
    [InlineData("ук", "укканмынбы")]
    [InlineData("күт", "күткөнмүнбү")]
    public void PastIndefinite_Мен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барган эмесминби")]
    [InlineData("иште", "иштеген эмесминби")]
    [InlineData("бол", "болгон эмесминби")]
    [InlineData("көр", "көргөн эмесминби")]
    [InlineData("тап", "тапкан эмесминби")]
    [InlineData("чеч", "чечкен эмесминби")]
    [InlineData("ук", "уккан эмесминби")]
    [InlineData("күт", "күткөн эмесминби")]
    public void PastIndefinite_Мен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}