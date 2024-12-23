using FluentAssertions;
using OpenKyrgyz.Core.Tenses.Imperative;

namespace UnitTests.Imperative;

public class ImperativeСиздерTests
{
    
    [Theory]
    [InlineData("бол", "болуңуздар")]
    [InlineData("иште", "иштеңиздер")]
    [InlineData("бар", "барыңыздар")]
    [InlineData("изилде", "изилдеңиздер")]
    [InlineData("кел", "келиңиздер")]
    [InlineData("ойно", "ойноңуздар")]
    [InlineData("күт", "күтүңүздөр")]
    [InlineData("тап", "табыңыздар")]
    [InlineData("кир", "кириңиздер")]
    [InlineData("өт", "өтүңүздөр")]
    [InlineData("чакыр", "чакырыңыздар")]
    [InlineData("текшер", "текшериңиздер")]
    [InlineData("отур", "отуруңуздар")]
    [InlineData("үйрөт", "үйрөтүңүздөр")]
    [InlineData("ук", "угуңуздар")]
    public void Imperative_Сиздер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСиздер.ConjugatePositive(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    [Theory]
    [InlineData("бол", "болбоңуздар")]
    [InlineData("иште", "иштебеңиздер")]
    [InlineData("бар", "барбаңыздар")]
    [InlineData("изилде", "изилдебеңиздер")]
    [InlineData("кел", "келбеңиздер")]
    [InlineData("ойно", "ойнобоңуздар")]
    [InlineData("күт", "күтпөңүздөр")]
    [InlineData("тап", "таппаңыздар")]
    [InlineData("кир", "кирбеңиздер")]
    [InlineData("өт", "өтпөңүздөр")]
    [InlineData("чакыр", "чакырбаңыздар")]
    [InlineData("текшер", "текшербеңиздер")]
    [InlineData("отур", "отурбаңыздар")]
    [InlineData("үйрөт", "үйрөтпөңүздөр")]
    [InlineData("ук", "укпаңыздар")]
    public void Imperative_Сиздер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = ImperativeСиздер.ConjugateNegative(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}