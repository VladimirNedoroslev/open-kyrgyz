using FluentAssertions;
using OpenKyrgyz.Core.Forms;

namespace UnitTests.Forms;

public class BeforeFormTests
{
    [Theory]
    [InlineData("кыл","кылганга чейин")]
    [InlineData("ташта","таштаганга чейин")]
    [InlineData("айт","айтканга чейин")]
    [InlineData("изилде","изилдегенге чейин")]
    [InlineData("кет","кеткенге чейин")]
    [InlineData("ойло","ойлогонго чейин")]
    [InlineData("күй","күйгөнгө чейин")]
    [InlineData("түш","түшкөнгө чейин")]
    public void BeforeForm_Tests(string verb, string expectedResult)
    {
        var actualResult = BeforeForm.Get(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}