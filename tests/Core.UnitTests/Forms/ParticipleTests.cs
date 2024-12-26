using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Forms;

namespace UnitTests.Forms;

public class ParticipleTests
{
    [Theory]
    [InlineData("кыл", "кылган")]
    [InlineData("ташта", "таштаган")]
    [InlineData("айт", "айткан")]
    [InlineData("изилде", "изилдеген")]
    [InlineData("кет", "кеткен")]
    [InlineData("ойло", "ойлогон")]
    [InlineData("күй", "күйгөн")]
    [InlineData("түш", "түшкөн")]
    public void ParticiplePositive_Tests(string verb, string expectedResult)
    {
        var actualResult = Participle.Get(verb, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбаган")]
    [InlineData("ташта", "таштабаган")]
    [InlineData("айт", "айтпаган")]
    [InlineData("изилде", "изилдебеген")]
    [InlineData("кет", "кетпеген")]
    [InlineData("ойло", "ойлобогон")]
    [InlineData("күй", "күйбөгөн")]
    [InlineData("түш", "түшпөгөн")]
    public void ParticipleNegative_Tests(string verb, string expectedResult)
    {
        var actualResult = Participle.Get(verb, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}