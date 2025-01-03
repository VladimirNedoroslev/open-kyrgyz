using FluentAssertions;
using OpenKyrgyz.Core.Verbs.Tenses.Imperative;

namespace UnitTests.Tenses.Imperative;

public class ImperativeАларTests
{
    [Theory]
    [InlineData("бол", "болушсун")]
    [InlineData("иште", "иштешсин")]
    [InlineData("бар", "барышсын")]
    [InlineData("изилде", "изилдешсин")]
    [InlineData("кел", "келишсин")]
    [InlineData("ойно", "ойношсун")]
    [InlineData("күт", "күтүшсүн")]
    [InlineData("тап", "табышсын")]
    [InlineData("кир", "киришсин")]
    [InlineData("өт", "өтүшсүн")]
    [InlineData("чакыр", "чакырышсын")]
    [InlineData("текшер", "текшеришсин")]
    [InlineData("отур", "отурушсун")]
    [InlineData("үйрөт", "үйрөтүшсүн")]
    [InlineData("кой", "коюшсун")]
    public void Imperative_Алар_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeАлар.ConjugatePositive(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}