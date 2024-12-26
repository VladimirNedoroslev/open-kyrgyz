using FluentAssertions;
using OpenKyrgyz.Core.Verbs.Forms.TimeRelated;

namespace UnitTests.Forms.TimeRelated;

public class AfterFormTests
{
    [Theory]
    [InlineData("кыл", "кылгандан кийин")]
    [InlineData("ташта", "таштагандан кийин")]
    [InlineData("айт", "айткандан кийин")]
    [InlineData("изилде", "изилдегенден кийин")]
    [InlineData("кет", "кеткенден кийин")]
    [InlineData("ойло", "ойлогондон кийин")]
    [InlineData("күй", "күйгөндөн кийин")]
    [InlineData("түш", "түшкөндөн кийин")]
    public void AfterForm_Tests(string verb, string expectedResult)
    {
        var actualResult = AfterForm.Get(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}