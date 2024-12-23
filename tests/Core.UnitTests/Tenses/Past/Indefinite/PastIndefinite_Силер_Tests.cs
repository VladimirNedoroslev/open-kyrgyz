using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.WithDifferentNegative.PastIndefinite;

namespace UnitTests.PastIndefinite;

public class PastIndefiniteСилерTests
{
    [Theory]
    [InlineData("бар", "баргансыңар")]
    [InlineData("иште", "иштегенсиңер")]
    [InlineData("бол", "болгонсуңар")]
    [InlineData("көр", "көргөнсүңөр")]
    [InlineData("тап", "тапкансыңар")]
    [InlineData("чеч", "чечкенсиңер")]
    [InlineData("ук", "уккансыңар")]
    [InlineData("күт", "күткөнсүңөр")]
    public void PastIndefinite_Силер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барган эмессиңер")]
    [InlineData("иште", "иштеген эмессиңер")]
    [InlineData("бол", "болгон эмессиңер")]
    [InlineData("көр", "көргөн эмессиңер")]
    [InlineData("тап", "тапкан эмессиңер")]
    [InlineData("чеч", "чечкен эмессиңер")]
    [InlineData("ук", "уккан эмессиңер")]
    [InlineData("күт", "күткөн эмессиңер")]
    public void PastIndefinite_Силер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "баргансыңарбы")]
    [InlineData("иште", "иштегенсиңерби")]
    [InlineData("бол", "болгонсуңарбы")]
    [InlineData("көр", "көргөнсүңөрбү")]
    [InlineData("тап", "тапкансыңарбы")]
    [InlineData("чеч", "чечкенсиңерби")]
    [InlineData("ук", "уккансыңарбы")]
    [InlineData("күт", "күткөнсүңөрбү")]
    public void PastIndefinite_Силер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барган эмессиңерби")]
    [InlineData("иште", "иштеген эмессиңерби")]
    [InlineData("бол", "болгон эмессиңерби")]
    [InlineData("көр", "көргөн эмессиңерби")]
    [InlineData("тап", "тапкан эмессиңерби")]
    [InlineData("чеч", "чечкен эмессиңерби")]
    [InlineData("ук", "уккан эмессиңерби")]
    [InlineData("күт", "күткөн эмессиңерби")]
    public void PastIndefinite_Силер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastIndefiniteConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}