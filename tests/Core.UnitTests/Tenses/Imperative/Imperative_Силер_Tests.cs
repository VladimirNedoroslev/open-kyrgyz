using FluentAssertions;
using OpenKyrgyz.Core.Verbs.Tenses.Imperative;

namespace UnitTests.Tenses.Imperative;

public class ImperativeСилерTests
{
    [Theory]
    [InlineData("бол", "болгула")]
    [InlineData("иште", "иштегиле")]
    [InlineData("бар", "баргыла")]
    [InlineData("изилде", "изилдегиле")]
    [InlineData("кел", "келгиле")]
    [InlineData("ойно", "ойногула")]
    [InlineData("күт", "күткүлө")]
    [InlineData("тап", "тапкыла")]
    [InlineData("кир", "киргиле")]
    [InlineData("өт", "өткүлө")]
    [InlineData("чакыр", "чакыргыла")]
    [InlineData("текшер", "текшергиле")]
    [InlineData("отур", "отургула")]
    [InlineData("үйрөт", "үйрөткүлө")]
    public void Imperative_Силер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСилер.ConjugatePositive(verb);

        // assert
        actualResult.Should().Be(expectedResult, verb);
    }

    [Theory]
    [InlineData("бол", "болбогула")]
    [InlineData("иште", "иштебегиле")]
    [InlineData("бар", "барбагыла")]
    [InlineData("изилде", "изилдебегиле")]
    [InlineData("кел", "келбегиле")]
    [InlineData("ойно", "ойнобогула")]
    [InlineData("күт", "күтпөгүлө")]
    [InlineData("тап", "таппагыла")]
    [InlineData("кир", "кирбегиле")]
    [InlineData("өт", "өтпөгүлө")]
    [InlineData("чакыр", "чакырбагыла")]
    [InlineData("текшер", "текшербегиле")]
    [InlineData("отур", "отурбагыла")]
    [InlineData("үйрөт", "үйрөтпөгүлө")]
    public void Imperative_Силер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСилер.ConjugateNegative(verb);

        // assert
        actualResult.Should().Be(expectedResult, verb);
    }
}