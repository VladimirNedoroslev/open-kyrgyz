using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PastUsedTo;

namespace UnitTests;

public class PastUsedToTests
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
    public void PastUsedTo_Мен(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugate.Conjugate(verb, PronounEnum.Мен);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчусуң")]
    [InlineData("иште", "иштечүсүң")]
    [InlineData("бол", "болчусуң")]
    [InlineData("көр", "көрчүсүң")]
    [InlineData("тап", "тапчусуң")]
    [InlineData("чеч", "чеччүсүң")]
    [InlineData("ук", "укчусуң")]
    [InlineData("күт", "күтчүсүң")]
    public void PastUsedTo_Сен(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugate.Conjugate(verb, PronounEnum.Сен);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчусуз")]
    [InlineData("иште", "иштечүсүз")]
    [InlineData("бол", "болчусуз")]
    [InlineData("көр", "көрчүсүз")]
    [InlineData("тап", "тапчусуз")]
    [InlineData("чеч", "чеччүсүз")]
    [InlineData("ук", "укчусуз")]
    [InlineData("күт", "күтчүсүз")]
    public void PastUsedTo_Сиз(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugate.Conjugate(verb, PronounEnum.Сиз);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчу")]
    [InlineData("иште", "иштечү")]
    [InlineData("бол", "болчу")]
    [InlineData("көр", "көрчү")]
    [InlineData("тап", "тапчу")]
    [InlineData("чеч", "чеччү")]
    [InlineData("ук", "укчу")]
    [InlineData("күт", "күтчү")]
    public void PastUsedTo_Ал(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugate.Conjugate(verb, PronounEnum.Ал);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчубуз")]
    [InlineData("иште", "иштечүбүз")]
    [InlineData("бол", "болчубуз")]
    [InlineData("көр", "көрчүбүз")]
    [InlineData("тап", "тапчубуз")]
    [InlineData("чеч", "чеччүбүз")]
    [InlineData("ук", "укчубуз")]
    [InlineData("күт", "күтчүбүз")]
    public void PastUsedTo_Биз(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugate.Conjugate(verb, PronounEnum.Биз);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчусуңар")]
    [InlineData("иште", "иштечүсүңөр")]
    [InlineData("бол", "болчусуңар")]
    [InlineData("көр", "көрчүсүңөр")]
    [InlineData("тап", "тапчусуңар")]
    [InlineData("чеч", "чеччүсүңөр")]
    [InlineData("ук", "укчусуңар")]
    [InlineData("күт", "күтчүсүңөр")]
    public void PastUsedTo_Силер(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugate.Conjugate(verb, PronounEnum.Силер);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барчусуздар")]
    [InlineData("иште", "иштечүсүздөр")]
    [InlineData("бол", "болчусуздар")]
    [InlineData("көр", "көрчүсүздөр")]
    [InlineData("тап", "тапчусуздар")]
    [InlineData("чеч", "чеччүсүздөр")]
    [InlineData("ук", "укчусуздар")]
    [InlineData("күт", "күтчүсүздөр")]
    public void PastUsedTo_Сиздер(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugate.Conjugate(verb, PronounEnum.Сиздер);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барышчу")]
    [InlineData("иште", "иштешчү")]
    [InlineData("бол", "болушчу")]
    [InlineData("көр", "көрүшчү")]
    [InlineData("тап", "табышчу")]
    [InlineData("чеч", "чечишчү")]
    [InlineData("ук", "угушчу")]
    [InlineData("күт", "күтүшчү")]
    public void PastUsedTo_Алар(string verb, string expectedResult)
    {
        // act
        var actualResult = PastUsedToConjugate.Conjugate(verb, PronounEnum.Алар);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}