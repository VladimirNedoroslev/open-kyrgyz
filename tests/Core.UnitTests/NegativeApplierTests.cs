using FluentAssertions;
using OpenKyrgyz.Core.Common;

namespace UnitTests;

public class NegativeApplierTests
{
    private readonly NegativeApplier negativeApplier;

    public NegativeApplierTests()
    {
        negativeApplier = new NegativeApplier();
    }

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
    public void GivenVerbEndingInVowelsFromFirstGroup_WhenNegativeApplied_ThenReturnNegativeAppliedResult(string verb, string expectedResult)
    {
        // act
        var actualResult = negativeApplier.Apply(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}