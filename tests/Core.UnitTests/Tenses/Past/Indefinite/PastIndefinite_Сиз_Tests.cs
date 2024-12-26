using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.WithDifferentNegative.PastIndefinite;

namespace UnitTests.Tenses.Past.Indefinite;

public class PastIndefiniteСизTests
{
    [Theory]
    [InlineData("бар", "баргансыз")]
    [InlineData("иште", "иштегенсиз")]
    [InlineData("бол", "болгонсуз")]
    [InlineData("көр", "көргөнсүз")]
    [InlineData("тап", "тапкансыз")]
    [InlineData("чеч", "чечкенсиз")]
    [InlineData("ук", "уккансыз")]
    [InlineData("күт", "күткөнсүз")]
    public void PastIndefinite_Сиз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барган эмессиз")]
    [InlineData("иште", "иштеген эмессиз")]
    [InlineData("бол", "болгон эмессиз")]
    [InlineData("көр", "көргөн эмессиз")]
    [InlineData("тап", "тапкан эмессиз")]
    [InlineData("чеч", "чечкен эмессиз")]
    [InlineData("ук", "уккан эмессиз")]
    [InlineData("күт", "күткөн эмессиз")]
    public void PastIndefinite_Сиз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "баргансызбы")]
    [InlineData("иште", "иштегенсизби")]
    [InlineData("бол", "болгонсузбу")]
    [InlineData("көр", "көргөнсүзбү")]
    [InlineData("тап", "тапкансызбы")]
    [InlineData("чеч", "чечкенсизби")]
    [InlineData("ук", "уккансызбы")]
    [InlineData("күт", "күткөнсүзбү")]
    public void PastIndefinite_Сиз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барган эмессизби")]
    [InlineData("иште", "иштеген эмессизби")]
    [InlineData("бол", "болгон эмессизби")]
    [InlineData("көр", "көргөн эмессизби")]
    [InlineData("тап", "тапкан эмессизби")]
    [InlineData("чеч", "чечкен эмессизби")]
    [InlineData("ук", "уккан эмессизби")]
    [InlineData("күт", "күткөн эмессизби")]
    public void PastIndefinite_Сиз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}