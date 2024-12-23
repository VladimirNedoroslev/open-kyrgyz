using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.Conditional;

namespace UnitTests.Tenses.Conditional;

public class ConditionalСилерTests
{
    [Theory]
    [InlineData("бар", "барсаңар")]
    [InlineData("иште", "иштесеңер")]
    [InlineData("бол", "болсоңор")]
    [InlineData("көр", "көрсөңөр")]
    [InlineData("тап", "тапсаңар")]
    [InlineData("чеч", "чечсеңер")]
    [InlineData("ук", "уксаңар")]
    [InlineData("күт", "күтсөңөр")]
    public void Conditional_Силер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Силер,VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбасаңар")]
    [InlineData("иште", "иштебесеңер")]
    [InlineData("бол", "болбосоңор")]
    [InlineData("көр", "көрбөсөңөр")]
    [InlineData("тап", "таппасаңар")]
    [InlineData("чеч", "чечпесеңер")]
    [InlineData("ук", "укпасаңар")]
    [InlineData("күт", "күтпөсөңөр")]
    public void Conditional_Силер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барсаңарбы")]
    [InlineData("иште", "иштесеңерби")]
    [InlineData("бол", "болсоңорбу")]
    [InlineData("көр", "көрсөңөрбү")]
    [InlineData("тап", "тапсаңарбы")]
    [InlineData("чеч", "чечсеңерби")]
    [InlineData("ук", "уксаңарбы")]
    [InlineData("күт", "күтсөңөрбү")]
    public void Conditional_Силер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбасаңарбы")]
    [InlineData("иште", "иштебесеңерби")]
    [InlineData("бол", "болбосоңорбу")]
    [InlineData("көр", "көрбөсөңөрбү")]
    [InlineData("тап", "таппасаңарбы")]
    [InlineData("чеч", "чечпесеңерби")]
    [InlineData("ук", "укпасаңарбы")]
    [InlineData("күт", "күтпөсөңөрбү")]
    public void Conditional_Силер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}