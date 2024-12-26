using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.FutureProbable;

namespace UnitTests.Tenses.FutureProbable;

public class FutureProbableМенTests
{
    [Theory]
    [InlineData("бар", "барармын")]
    [InlineData("иште", "иштермин")]
    [InlineData("бол", "болормун")]
    [InlineData("көр", "көрөрмүн")]
    [InlineData("тап", "табармын")]
    [InlineData("чеч", "чечермин")]
    [InlineData("ук", "угармын")]
    [InlineData("күт", "күтөрмүн")]
    [InlineData("кой", "коёрмун")]
    public void FutureProbable_Мен_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }


    [Theory]
    [InlineData("бар", "барбасмын")]
    [InlineData("иште", "иштебесмин")]
    [InlineData("бол", "болбосмун")]
    [InlineData("көр", "көрбөсмүн")]
    [InlineData("тап", "таппасмын")]
    [InlineData("чеч", "чечпесмин")]
    [InlineData("ук", "укпасмын")]
    [InlineData("күт", "күтпөсмүн")]
    public void FutureProbable_Мен_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барармынбы")]
    [InlineData("иште", "иштерминби")]
    [InlineData("бол", "болормунбу")]
    [InlineData("көр", "көрөрмүнбү")]
    [InlineData("тап", "табармынбы")]
    [InlineData("чеч", "чечерминби")]
    [InlineData("ук", "угармынбы")]
    [InlineData("күт", "күтөрмүнбү")]
    [InlineData("кой", "коёрмунбу")]
    public void FutureProbable_Мен_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбасмынбы")]
    [InlineData("иште", "иштебесминби")]
    [InlineData("бол", "болбосмунбу")]
    [InlineData("көр", "көрбөсмүнбү")]
    [InlineData("тап", "таппасмынбы")]
    [InlineData("чеч", "чечпесминби")]
    [InlineData("ук", "укпасмынбы")]
    [InlineData("күт", "күтпөсмүнбү")]
    public void FutureProbable_Мен_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Мен, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}