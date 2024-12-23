using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.VerbForms.Gerund;

namespace UnitTests;

public class GerundTests
{
    [Theory]
    [InlineData("иште", "иштеп")]
    [InlineData("отур", "отуруп")]
    [InlineData("кел", "келип")]
    [InlineData("ырда", "ырдап")]
    [InlineData("изилде", "изилдеп")]
    [InlineData("тап", "таап")]
    [InlineData("ич", "ичип")]
    [InlineData("корго", "коргоп")]
    [InlineData("же", "жеп")]
    [InlineData("көр", "көрүп")]
    [InlineData("кыймыл", "кыймылып")]
    [InlineData("кой", "коюп")]
    public void Gerund_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = GerundConjugator.GetGerund(verb, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    
    [Theory]
    [InlineData("иште", "иштебей")]
    [InlineData("отур", "отурбай")]
    [InlineData("кел", "келбей")]
    [InlineData("ырда", "ырдабай")]
    [InlineData("изилде", "изилдебей")]
    // [InlineData("тап", "таап")]
    [InlineData("ич", "ичпей")]
    [InlineData("корго", "коргобой")]
    [InlineData("же", "жебей")]
    [InlineData("көр", "көрбөй")]
    [InlineData("кыймыл", "кыймылбай")]
    [InlineData("кой", "койбой")]
    public void Gerund_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = GerundConjugator.GetGerund(verb, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}