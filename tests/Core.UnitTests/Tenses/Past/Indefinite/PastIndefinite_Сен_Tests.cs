using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.WithDifferentNegative.PastIndefinite;

namespace UnitTests.Tenses.Past.Indefinite;

public class PastIndefiniteСенTests
{
    [Theory]
    [InlineData("бар", "баргансың")]
    [InlineData("иште", "иштегенсиң")]
    [InlineData("бол", "болгонсуң")]
    [InlineData("көр", "көргөнсүң")]
    [InlineData("тап", "тапкансың")]
    [InlineData("чеч", "чечкенсиң")]
    [InlineData("ук", "уккансың")]
    [InlineData("күт", "күткөнсүң")]
    public void PastIndefinite_Сен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барган эмессиң")]
    [InlineData("иште", "иштеген эмессиң")]
    [InlineData("бол", "болгон эмессиң")]
    [InlineData("көр", "көргөн эмессиң")]
    [InlineData("тап", "тапкан эмессиң")]
    [InlineData("чеч", "чечкен эмессиң")]
    [InlineData("ук", "уккан эмессиң")]
    [InlineData("күт", "күткөн эмессиң")]
    public void PastIndefinite_Сен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "баргансыңбы")]
    [InlineData("иште", "иштегенсиңби")]
    [InlineData("бол", "болгонсуңбу")]
    [InlineData("көр", "көргөнсүңбү")]
    [InlineData("тап", "тапкансыңбы")]
    [InlineData("чеч", "чечкенсиңби")]
    [InlineData("ук", "уккансыңбы")]
    [InlineData("күт", "күткөнсүңбү")]
    public void PastIndefinite_Сен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барган эмессиңби")]
    [InlineData("иште", "иштеген эмессиңби")]
    [InlineData("бол", "болгон эмессиңби")]
    [InlineData("көр", "көргөн эмессиңби")]
    [InlineData("тап", "тапкан эмессиңби")]
    [InlineData("чеч", "чечкен эмессиңби")]
    [InlineData("ук", "уккан эмессиңби")]
    [InlineData("күт", "күткөн эмессиңби")]
    public void PastIndefinite_Сен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}