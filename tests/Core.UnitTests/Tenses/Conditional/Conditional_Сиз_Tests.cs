using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.Conditional;

namespace UnitTests.Conditional;

public class ConditionalСизTests
{
    [Theory]
    [InlineData("бар", "барсаңыз")]
    [InlineData("иште", "иштесеңиз")]
    [InlineData("бол", "болсоңуз")]
    [InlineData("көр", "көрсөңүз")]
    [InlineData("тап", "тапсаңыз")]
    [InlineData("чеч", "чечсеңиз")]
    [InlineData("ук", "уксаңуз")]
    [InlineData("күт", "күтсөңүз")]
    public void Conditional_Сиз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбасаңыз")]
    [InlineData("иште", "иштебесеңиз")]
    [InlineData("бол", "болбосоңуз")]
    [InlineData("көр", "көрбөсөңүз")]
    [InlineData("тап", "таппасаңыз")]
    [InlineData("чеч", "чечпесеңиз")]
    [InlineData("ук", "укпасаңыз")]
    [InlineData("күт", "күтпөсөңүз")]
    public void Conditional_Сиз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барсаңызбы")]
    [InlineData("иште", "иштесеңизби")]
    [InlineData("бол", "болсоңузбу")]
    [InlineData("көр", "көрсөңүзбү")]
    [InlineData("тап", "тапсаңызбы")]
    [InlineData("чеч", "чечсеңизби")]
    [InlineData("ук", "уксаңузбу")]
    [InlineData("күт", "күтсөңүзбү")]
    public void Conditional_Сиз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбасаңызбы")]
    [InlineData("иште", "иштебесеңизби")]
    [InlineData("бол", "болбосоңузбу")]
    [InlineData("көр", "көрбөсөңүзбү")]
    [InlineData("тап", "таппасаңызбы")]
    [InlineData("чеч", "чечпесеңизби")]
    [InlineData("ук", "укпасаңызбы")]
    [InlineData("күт", "күтпөсөңүзбү")]
    public void Conditional_Сиз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = ConditionalConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}