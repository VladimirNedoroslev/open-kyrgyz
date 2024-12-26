using FluentAssertions;
using OpenKyrgyz.Core.Verbs.Tenses.Imperative;

namespace UnitTests.Tenses.Imperative;

public class ImperativeАлTests
{
    [Theory]
    [InlineData("бол", "болсун")]
    [InlineData("иште", "иштесин")]
    [InlineData("бар", "барсын")]
    [InlineData("изилде", "изилдесин")]
    [InlineData("кел", "келсин")]
    [InlineData("ойно", "ойносун")]
    [InlineData("күт", "күтсүн")]
    [InlineData("тап", "тапсын")]
    [InlineData("кир", "кирсин")]
    [InlineData("өт", "өтсүн")]
    [InlineData("чакыр", "чакырсын")]
    [InlineData("текшер", "текшерсин")]
    [InlineData("отур", "отурсун")]
    [InlineData("үйрөт", "үйрөтсүн")]
    public void Imperative_Ал_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeАл.ConjugatePositive(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбосун")]
    [InlineData("иште", "иштебесин")]
    [InlineData("бар", "барбасын")]
    [InlineData("изилде", "изилдебесин")]
    [InlineData("кел", "келбесин")]
    [InlineData("ойно", "ойнобосун")]
    [InlineData("күт", "күтпөсүн")]
    [InlineData("тап", "таппасын")]
    [InlineData("кир", "кирбесин")]
    [InlineData("өт", "өтпөсүн")]
    [InlineData("чакыр", "чакырбасын")]
    [InlineData("текшер", "текшербесин")]
    [InlineData("отур", "отурбасын")]
    [InlineData("үйрөт", "үйрөтпөсүн")]
    public void Imperative_Ал_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeАл.ConjugateNegative(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}