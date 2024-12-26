using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Tenses.Conditional;

namespace UnitTests.Tenses.Conditional;

public class ConditionalСиздерTests
{
    [Theory]
    [InlineData("бар", "барсаңыздар")]
    [InlineData("иште", "иштесеңиздер")]
    [InlineData("бол", "болсоңуздар")]
    [InlineData("көр", "көрсөңүздөр")]
    [InlineData("тап", "тапсаңыздар")]
    [InlineData("чеч", "чечсеңиздер")]
    [InlineData("ук", "уксаңыздар")]
    [InlineData("күт", "күтсөңүздөр")]
    public void Conditional_Сиздер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбасаңыздар")]
    [InlineData("иште", "иштебесеңиздер")]
    [InlineData("бол", "болбосоңуздар")]
    [InlineData("көр", "көрбөсөңүздөр")]
    [InlineData("тап", "таппасаңыздар")]
    [InlineData("чеч", "чечпесеңиздер")]
    [InlineData("ук", "укпасаңыздар")]
    [InlineData("күт", "күтпөсөңүздөр")]
    public void Conditional_Сиздер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барсаңыздарбы")]
    [InlineData("иште", "иштесеңиздерби")]
    [InlineData("бол", "болсоңуздарбы")]
    [InlineData("көр", "көрсөңүздөрбү")]
    [InlineData("тап", "тапсаңыздарбы")]
    [InlineData("чеч", "чечсеңиздерби")]
    [InlineData("ук", "уксаңыздарбы")]
    [InlineData("күт", "күтсөңүздөрбү")]
    public void Conditional_Сиздер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбасаңыздарбы")]
    [InlineData("иште", "иштебесеңиздерби")]
    [InlineData("бол", "болбосоңуздарбы")]
    [InlineData("көр", "көрбөсөңүздөрбү")]
    [InlineData("тап", "таппасаңыздарбы")]
    [InlineData("чеч", "чечпесеңиздерби")]
    [InlineData("ук", "укпасаңыздарбы")]
    [InlineData("күт", "күтпөсөңүздөрбү")]
    public void Conditional_Сиздер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Сиздер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}