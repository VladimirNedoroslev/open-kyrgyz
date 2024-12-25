using FluentAssertions;
using OpenKyrgyz.Core.Forms;

namespace UnitTests.Forms;

public class WithEveryFormTests
{
    [Theory]
    [InlineData("кыл","кылган сайын")]
    [InlineData("ташта","таштаган сайын")]
    [InlineData("айт","айткан сайын")]
    [InlineData("изилде","изилдеген сайын")]
    [InlineData("кет","кеткен сайын")]
    [InlineData("ойло","ойлогон сайын")]
    [InlineData("күй","күйгөн саыйн")]
    [InlineData("түш","түшкөн сайын")]
    public void WithEveryForm_Tests(string verb, string expectedResult)
    {
        var actualResult = WithEveryForm.Get(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}