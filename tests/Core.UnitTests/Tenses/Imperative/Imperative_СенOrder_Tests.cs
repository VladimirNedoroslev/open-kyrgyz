using FluentAssertions;
using OpenKyrgyz.Core.Tenses.Imperative;

namespace UnitTests.Tenses.Imperative;

public class ImperativeСенOrderTests
{
    [Theory]
    [InlineData("бол", "болгун")]
    [InlineData("иште", "иштегин")]
    [InlineData("бар", "баргын")]
    [InlineData("изилде", "изилдегин")]
    [InlineData("кел", "келгин")]
    [InlineData("ойно", "ойногун")]
    [InlineData("күт", "күткүн")]
    [InlineData("тап", "тапкын")]
    [InlineData("кир", "киргин")]
    [InlineData("өт", "өткүн")]
    [InlineData("чакыр", "чакыргын")]
    [InlineData("текшер", "текшергин")]
    [InlineData("отур", "отургун")]
    [InlineData("үйрөт", "үйрөткүн")]
    public void Imperative_СенOrder_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСенOrder.ConjugatePositive(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бол", "болбогун")]
    [InlineData("иште", "иштебегин")]
    [InlineData("бар", "барбагын")]
    [InlineData("изилде", "изилдебегин")]
    [InlineData("кел", "келбегин")]
    [InlineData("ойно", "ойнобогун")]
    [InlineData("күт", "күтпөгүн")]
    [InlineData("тап", "таппагын")]
    [InlineData("кир", "кирбегин")]
    [InlineData("өт", "өтпөгүн")]
    [InlineData("чакыр", "чакырбагын")]
    [InlineData("текшер", "текшербегин")]
    [InlineData("отур", "отурбагын")]
    [InlineData("үйрөт", "үйрөтпөгүн")]
    public void Imperative_СенOrder_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСенOrder.ConjugateNegative(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}