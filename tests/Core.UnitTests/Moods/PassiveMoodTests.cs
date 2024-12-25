using FluentAssertions;
using OpenKyrgyz.Core.Moods;

namespace UnitTests.Moods;

public class PassiveMoodTests
{
    [Theory]
    [InlineData("кыл", "кылын")]
    [InlineData("ташта", "таштал")]
    [InlineData("айт", "айтыл")]
    [InlineData("тап", "табыл")]
    [InlineData("изилде", "изилдел")]
    [InlineData("кет", "кетил")]
    [InlineData("ойло", "ойлон")]
    [InlineData("күй", "күйүл")]
    [InlineData("түш", "түшүл")]
    [InlineData("ич", "ичил")]
    [InlineData("же", "жел")]
    [InlineData("жаса", "жасал")]
    [InlineData("ал", "алын")]
    public void PassiveMood_Tests(string verb, string expectedResult)
    {
        var actualResult = PassiveMood.Get(verb);
    
        // assert
        actualResult.Should().Be(expectedResult);
    }
}