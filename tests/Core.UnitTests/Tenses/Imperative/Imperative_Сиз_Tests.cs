using FluentAssertions;
using OpenKyrgyz.Core.Verbs.Tenses.Imperative;

namespace UnitTests.Tenses.Imperative;

public class ImperativeСизTests
{
    [Theory]
    [InlineData("бол", "болуңуз")]
    [InlineData("иште", "иштеңиз")]
    [InlineData("бар", "барыңыз")]
    [InlineData("изилде", "изилдеңиз")]
    [InlineData("кел", "келиңиз")]
    [InlineData("ойно", "ойноңуз")]
    [InlineData("күт", "күтүңүз")]
    [InlineData("тап", "табыңыз")]
    [InlineData("кир", "кириңиз")]
    [InlineData("өт", "өтүңүз")]
    [InlineData("чакыр", "чакырыңыз")]
    [InlineData("текшер", "текшериңиз")]
    [InlineData("отур", "отуруңуз")]
    [InlineData("үйрөт", "үйрөтүңүз")]
    [InlineData("ук", "угуңуз")]
    [InlineData("кой", "коюңуз")]
    public void Imperative_Сиз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСиз.ConjugatePositive(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бол", "болбоңуз")]
    [InlineData("иште", "иштебеңиз")]
    [InlineData("бар", "барбаңыз")]
    [InlineData("изилде", "изилдебеңиз")]
    [InlineData("кел", "келбеңиз")]
    [InlineData("ойно", "ойнобоңуз")]
    [InlineData("күт", "күтпөңүз")]
    [InlineData("тап", "таппаңыз")]
    [InlineData("кир", "кирбеңиз")]
    [InlineData("өт", "өтпөңүз")]
    [InlineData("чакыр", "чакырбаңыз")]
    [InlineData("текшер", "текшербеңиз")]
    [InlineData("отур", "отурбаңыз")]
    [InlineData("үйрөт", "үйрөтпөңүз")]
    [InlineData("ук", "укпаңыз")]
    public void Imperative_Сиз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСиз.ConjugateNegative(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}