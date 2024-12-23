using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.PastSudden;

namespace UnitTests.Tenses.Past.Sudden;

public class PastSuddenСилерTests
{
   
    [Theory]
    [InlineData("бар", "барыптырсыңар")]
    [InlineData("иште", "иштептирсиңер")]
    [InlineData("бол", "болуптурсуңар")]
    [InlineData("көр", "көрүптүрсүңөр")]
    [InlineData("тап", "табыптырсыңар")]
    [InlineData("чеч", "чечиптирсиңер")]
    [InlineData("ук", "угуптурсуңар")]
    [InlineData("күт", "күтүптүрсүңөр")]
    [InlineData("кой", "коюптурсуңар")]
    public void PastSudden_Силер_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барбаптырсыңар")]
    [InlineData("иште", "иштебептирсиңер")]
    [InlineData("бол", "болбоптурсуңар")]
    [InlineData("көр", "көрбөптүрсүңөр")]
    [InlineData("тап", "таппаптырсыңар")]
    [InlineData("чеч", "чечпептирсиңер")]
    [InlineData("ук", "укпаптырсыңар")]
    [InlineData("күт", "күтпөптүрсүңөр")]
    public void PastSudden_Силер_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барыптырсыңарбы")]
    [InlineData("иште", "иштептирсиңерби")]
    [InlineData("бол", "болуптурсуңарбы")]
    [InlineData("көр", "көрүптүрсүңөрбү")]
    [InlineData("тап", "табыптырсыңарбы")]
    [InlineData("чеч", "чечиптирсиңерби")]
    [InlineData("ук", "угуптурсуңарбы")]
    [InlineData("күт", "күтүптүрсүңөрбү")]
    [InlineData("кой", "коюптурсуңарбы")]
    public void PastSudden_Силер_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    
    [Theory]
    [InlineData("бар", "барбаптырсыңарбы")]
    [InlineData("иште", "иштебептирсиңерби")]
    [InlineData("бол", "болбоптурсуңарбы")]
    [InlineData("көр", "көрбөптүрсүңөрбү")]
    [InlineData("тап", "таппаптырсыңарбы")]
    [InlineData("чеч", "чечпептирсиңерби")]
    [InlineData("ук", "укпаптырсыңарбы")]
    [InlineData("күт", "күтпөптүрсүңөрбү")]
    public void PastSudden_Силер_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = PastSuddenConjugator.Conjugate(verb, PronounEnum.Силер, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}