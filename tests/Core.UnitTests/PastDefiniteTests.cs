using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PastDefinite;

namespace UnitTests;

public class PastDefiniteTests
{
    [Theory]
    [InlineData("бар", "бардым")]
    [InlineData("иште", "иштедим")]
    [InlineData("бол", "болдум")]
    [InlineData("көр", "көрдүм")]
    [InlineData("тап", "таптым")]
    [InlineData("чеч", "чечтим")]
    [InlineData("ук", "уктум")]
    [InlineData("күт", "күттүм")]
    public void PastDefinite_Мен(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseGenerator.GenerateForPronoun(verb, PronounEnum.Мен);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бардың")]
    [InlineData("иште", "иштедиң")]
    [InlineData("бол", "болдуң")]
    [InlineData("көр", "көрдүң")]
    [InlineData("тап", "таптың")]
    [InlineData("чеч", "чечтиң")]
    [InlineData("ук", "уктуң")]
    [InlineData("күт", "күттүң")]
    public void PastDefinite_Сен(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseGenerator.GenerateForPronoun(verb, PronounEnum.Сен);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бардыңыз")]
    [InlineData("иште", "иштедиңиз")]
    [InlineData("бол", "болдуңуз")]
    [InlineData("көр", "көрдүңүз")]
    [InlineData("тап", "таптыңыз")]
    [InlineData("чеч", "чечтиңиз")]
    [InlineData("ук", "уктуңуз")]
    [InlineData("күт", "күттүңүз")]
    public void PastDefinite_Сиз(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseGenerator.GenerateForPronoun(verb, PronounEnum.Сиз);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барды")]
    [InlineData("иште", "иштеди")]
    [InlineData("бол", "болду")]
    [InlineData("көр", "көрдү")]
    [InlineData("тап", "тапты")]
    [InlineData("чеч", "чечти")]
    [InlineData("ук", "укту")]
    [InlineData("күт", "күттү")]
    public void PastDefinite_Ал(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseGenerator.GenerateForPronoun(verb, PronounEnum.Ал);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бардык")]
    [InlineData("иште", "иштедик")]
    [InlineData("бол", "болдук")]
    [InlineData("көр", "көрдүк")]
    [InlineData("тап", "таптык")]
    [InlineData("чеч", "чечтик")]
    [InlineData("ук", "уктук")]
    [InlineData("күт", "күттүк")]
    public void PastDefinite_Биз(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseGenerator.GenerateForPronoun(verb, PronounEnum.Биз);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бардыңар")]
    [InlineData("иште", "иштедиңер")]
    [InlineData("бол", "болдуңар")]
    [InlineData("көр", "көрдүңөр")]
    [InlineData("тап", "таптыңар")]
    [InlineData("чеч", "чечтиңер")]
    [InlineData("ук", "уктуңар")]
    [InlineData("күт", "күттүңөр")]
    public void PastDefinite_Силер(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseGenerator.GenerateForPronoun(verb, PronounEnum.Силер);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "бардыңыздар")]
    [InlineData("иште", "иштедиңиздер")]
    [InlineData("бол", "болдуңуздар")]
    [InlineData("көр", "көрдүңүздөр")]
    [InlineData("тап", "таптыңыздар")]
    [InlineData("чеч", "чечтиңиздер")]
    [InlineData("ук", "уктуңуздар")]
    [InlineData("күт", "күттүңүздөр")]
    public void PastDefinite_Сиздер(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseGenerator.GenerateForPronoun(verb, PronounEnum.Сиздер);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("бар", "барышты")]
    [InlineData("иште", "иштешти")]
    [InlineData("бол", "болушту")]
    [InlineData("көр", "көрүштү")]
    [InlineData("тап", "табышты")]
    [InlineData("чеч", "чечишти")]
    [InlineData("ук", "угушту")]
    [InlineData("күт", "күтүштү")]
    public void PastDefinite_Алар(string verb, string expectedResult)
    {
        // act
        var actualResult = PastDefiniteTenseGenerator.GenerateForPronoun(verb, PronounEnum.Алар);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}