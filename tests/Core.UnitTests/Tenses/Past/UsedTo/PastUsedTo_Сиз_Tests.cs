using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.WithDifferentNegative.PastUsedTo;

namespace UnitTests.Tenses.Past.UsedTo;

public class PasUsedToСизTests
{
    [Theory]
    [InlineData("бар", "барчусуз")]
    [InlineData("иште", "иштечүсүз")]
    [InlineData("бол", "болчусуз")]
    [InlineData("көр", "көрчүсүз")]
    [InlineData("тап", "тапчусуз")]
    [InlineData("чеч", "чеччүсүз")]
    [InlineData("ук", "укчусуз")]
    [InlineData("күт", "күтчүсүз")]
    public void PastUsedTo_Сиз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчу эмессиз")]
    [InlineData("иште", "иштечү эмессиз")]
    [InlineData("бол", "болчу эмессиз")]
    [InlineData("көр", "көрчү эмессиз")]
    [InlineData("тап", "тапчу эмессиз")]
    [InlineData("чеч", "чеччү эмессиз")]
    [InlineData("ук", "укчу эмессиз")]
    [InlineData("күт", "күтчү эмессиз")]
    public void PastUsedTo_Сиз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчусузбу")]
    [InlineData("иште", "иштечүсүзбү")]
    [InlineData("бол", "болчусузбу")]
    [InlineData("көр", "көрчүсүзбү")]
    [InlineData("тап", "тапчусузбу")]
    [InlineData("чеч", "чеччүсүзбү")]
    [InlineData("ук", "укчусузбу")]
    [InlineData("күт", "күтчүсүзбү")]
    public void PastUsedTo_Сиз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барчу эмессизби")]
    [InlineData("иште", "иштечү эмессизби")]
    [InlineData("бол", "болчу эмессизби")]
    [InlineData("көр", "көрчү эмессизби")]
    [InlineData("тап", "тапчу эмессизби")]
    [InlineData("чеч", "чеччү эмессизби")]
    [InlineData("ук", "укчу эмессизби")]
    [InlineData("күт", "күтчү эмессизби")]
    public void PastUsedTo_Сиз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}