using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.WithDifferentNegative.PastIndefinite;

namespace UnitTests.Tenses.Past.Indefinite;

public class PastIndefiniteБизTests
{
    [Theory]
    [InlineData("бар", "барганбыз")]
    [InlineData("иште", "иштегенбиз")]
    [InlineData("бол", "болгонбуз")]
    [InlineData("көр", "көргөнбүз")]
    [InlineData("тап", "тапканбыз")]
    [InlineData("чеч", "чечкенбиз")]
    [InlineData("ук", "укканбыз")]
    [InlineData("күт", "күткөнбүз")]
    public void PastIndefinite_Биз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барган эмеспиз")]
    [InlineData("иште", "иштеген эмеспиз")]
    [InlineData("бол", "болгон эмеспиз")]
    [InlineData("көр", "көргөн эмеспиз")]
    [InlineData("тап", "тапкан эмеспиз")]
    [InlineData("чеч", "чечкен эмеспиз")]
    [InlineData("ук", "уккан эмеспиз")]
    [InlineData("күт", "күткөн эмеспиз")]
    public void PastIndefinite_Биз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барганбызбы")]
    [InlineData("иште", "иштегенбизби")]
    [InlineData("бол", "болгонбузбу")]
    [InlineData("көр", "көргөнбүзбү")]
    [InlineData("тап", "тапканбызбы")]
    [InlineData("чеч", "чечкенбизби")]
    [InlineData("ук", "укканбызбы")]
    [InlineData("күт", "күткөнбүзбү")]
    public void PastIndefinite_Биз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барган эмеспизби")]
    [InlineData("иште", "иштеген эмеспизби")]
    [InlineData("бол", "болгон эмеспизби")]
    [InlineData("көр", "көргөн эмеспизби")]
    [InlineData("тап", "тапкан эмеспизби")]
    [InlineData("чеч", "чечкен эмеспизби")]
    [InlineData("ук", "уккан эмеспизби")]
    [InlineData("күт", "күткөн эмеспизби")]
    public void PastIndefinite_Биз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}