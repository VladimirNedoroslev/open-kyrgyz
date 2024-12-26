using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.FutureProbable;

namespace UnitTests.Tenses.FutureProbable;

public class FutureProbableСенTests
{
    [Theory]
    [InlineData("бар", "барарсың")]
    [InlineData("иште", "иштерсиң")]
    [InlineData("бол", "болорсуң")]
    [InlineData("көр", "көрөрсүң")]
    [InlineData("тап", "табарсың")]
    [InlineData("чеч", "чечерсиң")]
    [InlineData("ук", "угарсың")]
    [InlineData("күт", "күтөрсүң")]
    [InlineData("кой", "коёрсуң")]
    public void FutureProbable_Сен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барбассың")]
    [InlineData("иште", "иштебессиң")]
    [InlineData("бол", "болбоссуң")]
    [InlineData("көр", "көрбөссүң")]
    [InlineData("тап", "таппассың")]
    [InlineData("чеч", "чечпессиң")]
    [InlineData("ук", "укпассың")]
    [InlineData("күт", "күтпөссүң")]
    public void FutureProbable_Сен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барарсыңбы")]
    [InlineData("иште", "иштерсиңби")]
    [InlineData("бол", "болорсуңбу")]
    [InlineData("көр", "көрөрсүңбү")]
    [InlineData("тап", "табарсыңбы")]
    [InlineData("чеч", "чечерсиңби")]
    [InlineData("ук", "угарсыңбы")]
    [InlineData("күт", "күтөрсүңбү")]
    [InlineData("кой", "коёрсуңбу")]
    public void FutureProbable_Сен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбассыңбы")]
    [InlineData("иште", "иштебессиңби")]
    [InlineData("бол", "болбоссуңбу")]
    [InlineData("көр", "көрбөссүңбү")]
    [InlineData("тап", "таппассыңбы")]
    [InlineData("чеч", "чечпессиңби")]
    [InlineData("ук", "укпассыңбы")]
    [InlineData("күт", "күтпөссүңбү")]
    public void FutureProbable_Сен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Сен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}