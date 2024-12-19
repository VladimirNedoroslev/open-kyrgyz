using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.FutureProbable;
using OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

namespace UnitTests;

public class FutureProbableTests
{
    [Theory]
    [InlineData("бар", "барармын")]
    [InlineData("иште", "иштермин")]
    [InlineData("бол", "болормун")]
    [InlineData("көр", "көрөрмүн")]
    [InlineData("тап", "табармын")]
    [InlineData("чеч", "чечермин")]
    [InlineData("ук", "угармын")]
    [InlineData("күт", "күтөрмүн")]
    public void FutureProbable_Мен(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableTenseConjugator.Conjugate(verb, PronounEnum.Мен);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барарсың")]
    [InlineData("иште", "иштерсиң")]
    [InlineData("бол", "болорсуң")]
    [InlineData("көр", "көрөрсүң")]
    [InlineData("тап", "табарсың")]
    [InlineData("чеч", "чечерсиң")]
    [InlineData("ук", "угарсың")]
    [InlineData("күт", "күтөрсүң")]
    public void FutureProbable_Сен(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableTenseConjugator.Conjugate(verb, PronounEnum.Сен);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барарсыз")]
    [InlineData("иште", "иштерсиз")]
    [InlineData("бол", "болорсуз")]
    [InlineData("көр", "көрөрсүз")]
    [InlineData("тап", "табарсыз")]
    [InlineData("чеч", "чечерсиз")]
    [InlineData("ук", "угарсыз")]
    [InlineData("күт", "күтөрсүз")]
    public void FutureProbable_Сиз(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableTenseConjugator.Conjugate(verb, PronounEnum.Сиз);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барар")]
    [InlineData("иште", "иштер")]
    [InlineData("бол", "болор")]
    [InlineData("көр", "көрөр")]
    [InlineData("тап", "табар")]
    [InlineData("чеч", "чечер")]
    [InlineData("ук", "угар")]
    [InlineData("күт", "күтөр")]
    public void FutureProbable_Ал(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableTenseConjugator.Conjugate(verb, PronounEnum.Ал);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барарбыз")]
    [InlineData("иште", "иштербиз")]
    [InlineData("бол", "болорбуз")]
    [InlineData("көр", "көрөрбүз")]
    [InlineData("тап", "табарбыз")]
    [InlineData("чеч", "чечербиз")]
    [InlineData("ук", "угарбыз")]
    [InlineData("күт", "күтөрбүз")]
    public void FutureProbable_Биз(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableTenseConjugator.Conjugate(verb, PronounEnum.Биз);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барарсыңар")]
    [InlineData("иште", "иштерсиңер")]
    [InlineData("бол", "болорсуңар")]
    [InlineData("көр", "көрөрсүңөр")]
    [InlineData("тап", "табарсыңар")]
    [InlineData("чеч", "чечерсиңер")]
    [InlineData("ук", "угарсыңар")]
    [InlineData("күт", "күтөрсүңөр")]
    public void FutureProbable_Силер(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableTenseConjugator.Conjugate(verb, PronounEnum.Силер);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барарсыздар")]
    [InlineData("иште", "иштерсиздер")]
    [InlineData("бол", "болорсуздар")]
    [InlineData("көр", "көрөрсүздөр")]
    [InlineData("тап", "табарсыздар")]
    [InlineData("чеч", "чечерсиздер")]
    [InlineData("ук", "угарсыздар")]
    [InlineData("күт", "күтөрсүздөр")]
    public void FutureProbable_Сиздер(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableTenseConjugator.Conjugate(verb, PronounEnum.Сиздер);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барышар")]
    [InlineData("иште", "иштешер")]
    [InlineData("бол", "болушар")]
    [InlineData("көр", "көрүшөр")]
    [InlineData("тап", "табышар")]
    [InlineData("чеч", "чечишер")]
    [InlineData("ук", "угушар")]
    [InlineData("күт", "күтүшөр")]
    public void FutureProbable_Алар(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableTenseConjugator.Conjugate(verb, PronounEnum.Алар);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}