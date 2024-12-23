using FluentAssertions;
using OpenKyrgyz.Core.Tenses.Imperative;

namespace UnitTests.Imperative;

public class ImperativeСенPoliteTests
{
    [Theory]
    [InlineData("бол", "болчу")]
    [InlineData("иште", "иштечи")]
    [InlineData("бар", "барчы")]
    [InlineData("изилде", "изилдечи")]
    [InlineData("кел", "келчи")]
    [InlineData("ойно", "ойночу")]
    [InlineData("күт", "күтчү")]
    [InlineData("тап", "тапчы")]
    [InlineData("кир", "кирчи")]
    [InlineData("өт", "өтчү")]
    [InlineData("чакыр", "чакырчы")]
    [InlineData("текшер", "текшерчи")]
    [InlineData("отур", "отурчу")]
    [InlineData("үйрөт", "үйрөтчү")]
    public void Imperative_СенPolite_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСенPolite.ConjugatePositive(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бол", "болбочу")]
    [InlineData("иште", "иштебечи")]
    [InlineData("бар", "барбачы")]
    [InlineData("изилде", "изилдебечи")]
    [InlineData("кел", "келбечи")]
    [InlineData("ойно", "ойнобочу")]
    [InlineData("күт", "күтпөчү")]
    [InlineData("тап", "таппачы")]
    [InlineData("кир", "кирбечи")]
    [InlineData("өт", "өтпөчү")]
    [InlineData("чакыр", "чакырбачы")]
    [InlineData("текшер", "текшербечи")]
    [InlineData("отур", "отурбачы")]
    [InlineData("үйрөт", "үйрөтпөчү")]
    public void Imperative_СенPolite_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСенPolite.ConjugateNegative(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}