using FluentAssertions;
using OpenKyrgyz.Core.Verbs.Moods;

namespace UnitTests.Moods;

public class CooperativeMoodTests
{
    [Theory]
    [InlineData("кыл", "кылыш")]
    [InlineData("ташта", "ташташ")]
    [InlineData("айт", "айтыш")]
    [InlineData("тап", "табыш")]
    [InlineData("изилде", "изилдеш")]
    [InlineData("кет", "кетиш")]
    [InlineData("ойло", "ойлош")]
    [InlineData("күй", "күйүш")]
    [InlineData("түш", "түшүш")]
    [InlineData("ич", "ичиш")]
    [InlineData("же", "жеш")]
    [InlineData("жаса", "жасаш")]
    [InlineData("ал", "алыш")]
    public void CooperativeMood_Tests(string verb, string expectedResult)
    {
        var actualResult = CooperativeMood.Get(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}