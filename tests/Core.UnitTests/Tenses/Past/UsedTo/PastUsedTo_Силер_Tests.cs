using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.WithDifferentNegative.PastUsedTo;

namespace UnitTests.Tenses.Past.UsedTo;

public class PasUsedToСилерTests
{
    [Theory]
    [InlineData("бар", "барчусуңар")]
    [InlineData("иште", "иштечүсүңөр")]
    [InlineData("бол", "болчусуңар")]
    [InlineData("көр", "көрчүсүңөр")]
    [InlineData("тап", "тапчусуңар")]
    [InlineData("чеч", "чеччүсүңөр")]
    [InlineData("ук", "укчусуңар")]
    [InlineData("күт", "күтчүсүңөр")]
    public void PastUsedTo_Силер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчу эмессиңер")]
    [InlineData("иште", "иштечү эмессиңер")]
    [InlineData("бол", "болчу эмессиңер")]
    [InlineData("көр", "көрчү эмессиңер")]
    [InlineData("тап", "тапчу эмессиңер")]
    [InlineData("чеч", "чеччү эмессиңер")]
    [InlineData("ук", "укчу эмессиңер")]
    [InlineData("күт", "күтчү эмессиңер")]
    public void PastUsedTo_Силер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчусуңарбы")]
    [InlineData("иште", "иштечүсүңөрбү")]
    [InlineData("бол", "болчусуңарбы")]
    [InlineData("көр", "көрчүсүңөрбү")]
    [InlineData("тап", "тапчусуңарбы")]
    [InlineData("чеч", "чеччүсүңөрбү")]
    [InlineData("ук", "укчусуңарбы")]
    [InlineData("күт", "күтчүсүңөрбү")]
    public void PastUsedTo_Силер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барчу эмессиңерби")]
    [InlineData("иште", "иштечү эмессиңерби")]
    [InlineData("бол", "болчу эмессиңерби")]
    [InlineData("көр", "көрчү эмессиңерби")]
    [InlineData("тап", "тапчу эмессиңерби")]
    [InlineData("чеч", "чеччү эмессиңерби")]
    [InlineData("ук", "укчу эмессиңерби")]
    [InlineData("күт", "күтчү эмессиңерби")]
    public void PastUsedTo_Силер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}