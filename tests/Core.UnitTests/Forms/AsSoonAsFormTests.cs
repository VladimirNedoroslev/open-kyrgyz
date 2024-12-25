using FluentAssertions;
using OpenKyrgyz.Core.Forms;

namespace UnitTests.Forms;

public class AsSoonAsFormTests
{
    [Theory]
    [InlineData("кыл","кылар замат")]
    [InlineData("ташта","таштар замат")]
    [InlineData("айт","айтар замат")]
    [InlineData("изилде","изилдер замат")]
    [InlineData("кет","кетер замат")]
    [InlineData("ойло","ойлор замат")]
    [InlineData("күй","күйөр замат")]
    [InlineData("түш","түшөр замат")]
    public void AsSoonAsForm_Tests(string verb, string expectedResult)
    {
        var actualResult = AsSoonAsForm.Get(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}