using FluentAssertions;
using OpenKyrgyz.Core.Forms.TimeRelated;

namespace UnitTests.Forms.TimeRelated;

public class UntilFormTests
{
    [Theory]
    [InlineData("кыл","кылмайынча")]
    [InlineData("ташта","таштамайынча")]
    [InlineData("айт","айтмайынча")]
    [InlineData("тап","тапмайынча")]
    [InlineData("изилде","изилдемейинче")]
    [InlineData("кет","кетмейинче")]
    [InlineData("ойло","ойломоюнча")]
    [InlineData("күй","күймөйүнчө")]
    [InlineData("түш","түшмөйүнчө")]
    public void UntilForm_Tests(string verb, string expectedResult)
    {
        var actualResult = UntilForm.Get(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}