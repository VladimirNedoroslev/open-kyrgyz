using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.FutureProbable;

namespace UnitTests.Tenses.FutureProbable;

public class FutureProbableСилерTests
{
    [Theory]
    [InlineData("бар", "барарсыңар")]
    [InlineData("иште", "иштерсиңер")]
    [InlineData("бол", "болорсуңар")]
    [InlineData("көр", "көрөрсүңөр")]
    [InlineData("тап", "табарсыңар")]
    [InlineData("чеч", "чечерсиңер")]
    [InlineData("ук", "угарсыңар")]
    [InlineData("күт", "күтөрсүңөр")]
    [InlineData("кой", "коёрсуңар")]
    public void FutureProbable_Силер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барбассыңар")]
    [InlineData("иште", "иштебессиңер")]
    [InlineData("бол", "болбоссуңар")]
    [InlineData("көр", "көрбөссүңөр")]
    [InlineData("тап", "таппассыңар")]
    [InlineData("чеч", "чечпессиңер")]
    [InlineData("ук", "укпассыңар")]
    [InlineData("күт", "күтпөссүңөр")]
    public void FutureProbable_Силер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барарсыңарбы")]
    [InlineData("иште", "иштерсиңерби")]
    [InlineData("бол", "болорсуңарбы")]
    [InlineData("көр", "көрөрсүңөрбү")]
    [InlineData("тап", "табарсыңарбы")]
    [InlineData("чеч", "чечерсиңерби")]
    [InlineData("ук", "угарсыңарбы")]
    [InlineData("күт", "күтөрсүңөрбү")]
    [InlineData("кой", "коёрсуңарбы")]
    public void FutureProbable_Силер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбассыңарбы")]
    [InlineData("иште", "иштебессиңерби")]
    [InlineData("бол", "болбоссуңарбы")]
    [InlineData("көр", "көрбөссүңөрбү")]
    [InlineData("тап", "таппассыңарбы")]
    [InlineData("чеч", "чечпессиңерби")]
    [InlineData("ук", "укпассыңарбы")]
    [InlineData("күт", "күтпөссүңөрбү")]
    public void FutureProbable_Силер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}