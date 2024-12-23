using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PastDefinite;

namespace UnitTests.PastDefinite;

public class PastDefiniteСизTests
{
    [Theory]
    [InlineData("бар", "бардыңыз")]
    [InlineData("иште", "иштедиңиз")]
    [InlineData("бол", "болдуңуз")]
    [InlineData("көр", "көрдүңүз")]
    [InlineData("тап", "таптыңыз")]
    [InlineData("чеч", "чечтиңиз")]
    [InlineData("ук", "уктуңуз")]
    [InlineData("күт", "күттүңүз")]
    public void PastDefinite_Сиз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбадыңыз")]
    [InlineData("иште", "иштебедиңиз")]
    [InlineData("бол", "болбодуңуз")]
    [InlineData("көр", "көрбөдүңүз")]
    [InlineData("тап", "таппадыңыз")]
    [InlineData("чеч", "чечпедиңиз")]
    [InlineData("ук", "укпадыңыз")]
    [InlineData("күт", "күтпөдүңүз")]
    public void PastDefinite_Сиз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бардыңызбы")]
    [InlineData("иште", "иштедиңизби")]
    [InlineData("бол", "болдуңузбу")]
    [InlineData("көр", "көрдүңүзбү")]
    [InlineData("тап", "таптыңызбы")]
    [InlineData("чеч", "чечтиңизби")]
    [InlineData("ук", "уктуңузбу")]
    [InlineData("күт", "күттүңүзбү")]
    public void PastDefinite_Сиз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барбадыңызбы")]
    [InlineData("иште", "иштебедиңизби")]
    [InlineData("бол", "болбодуңузбу")]
    [InlineData("көр", "көрбөдүңүзбү")]
    [InlineData("тап", "таппадыңызбы")]
    [InlineData("чеч", "чечпедиңизби")]
    [InlineData("ук", "укпадыңызбы")]
    [InlineData("күт", "күтпөдүңүзбү")]
    public void PastDefinite_Сиз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}