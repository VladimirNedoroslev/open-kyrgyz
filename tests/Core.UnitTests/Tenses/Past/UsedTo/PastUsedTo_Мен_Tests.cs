using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.WithDifferentNegative.PastUsedTo;

namespace UnitTests.Tenses.Past.UsedTo;

public class PasUsedToМенTests
{
    [Theory]
    [InlineData("бар", "барчумун")]
    [InlineData("иште", "иштечүмүн")]
    [InlineData("бол", "болчумун")]
    [InlineData("көр", "көрчүмүн")]
    [InlineData("тап", "тапчумун")]
    [InlineData("чеч", "чеччүмүн")]
    [InlineData("ук", "укчумун")]
    [InlineData("күт", "күтчүмүн")]
    public void PastUsedTo_Мен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчу эмесмин")]
    [InlineData("иште", "иштечү эмесмин")]
    [InlineData("бол", "болчу эмесмин")]
    [InlineData("көр", "көрчү эмесмин")]
    [InlineData("тап", "тапчу эмесмин")]
    [InlineData("чеч", "чеччү эмесмин")]
    [InlineData("ук", "укчу эмесмин")]
    [InlineData("күт", "күтчү эмесмин")]
    public void PastUsedTo_Мен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчумунбу")]
    [InlineData("иште", "иштечүмүнбү")]
    [InlineData("бол", "болчумунбу")]
    [InlineData("көр", "көрчүмүнбү")]
    [InlineData("тап", "тапчумунбу")]
    [InlineData("чеч", "чеччүмүнбү")]
    [InlineData("ук", "укчумунбу")]
    [InlineData("күт", "күтчүмүнбү")]
    public void PastUsedTo_Мен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барчу эмесминби")]
    [InlineData("иште", "иштечү эмесминби")]
    [InlineData("бол", "болчу эмесминби")]
    [InlineData("көр", "көрчү эмесминби")]
    [InlineData("тап", "тапчу эмесминби")]
    [InlineData("чеч", "чеччү эмесминби")]
    [InlineData("ук", "укчу эмесминби")]
    [InlineData("күт", "күтчү эмесминби")]
    public void PastUsedTo_Мен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}