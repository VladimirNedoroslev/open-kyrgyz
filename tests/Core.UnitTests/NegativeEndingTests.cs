using FluentAssertions;
using OpenKyrgyz.Core.Negative;

namespace UnitTests;

public class NegativeEndingTests
{
    [Theory]
    [InlineData("иште", "иштебе")]
    [InlineData("кел", "келбе")]
    [InlineData("ырда", "ырдаба")]
    [InlineData("изилде", "изилдебе")]
    [InlineData("тап", "таппа")]
    [InlineData("ич", "ичпе")]
    [InlineData("корго", "коргобо")]
    [InlineData("же", "жебе")]
    [InlineData("көр", "көрбө")]
    [InlineData("кыймыл", "кыймылба")]
    public void Verb_Negative(string verb, string expectedResult)
    {
        // act
        var negativeToken = verb.GetNegativeAffix();
        var actualResult = verb + negativeToken.Value;

        // assert
        actualResult.Should().Be(expectedResult);
    }
}