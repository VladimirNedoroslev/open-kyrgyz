using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.FutureProbable;

namespace UnitTests.FutureProbable;

public class FutureProbableБизTests
{
    [Theory]
    [InlineData("бар", "барарбыз")]
    [InlineData("иште", "иштербиз")]
    [InlineData("бол", "болорбуз")]
    [InlineData("көр", "көрөрбүз")]
    [InlineData("тап", "табарбыз")]
    [InlineData("чеч", "чечербиз")]
    [InlineData("ук", "угарбыз")]
    [InlineData("күт", "күтөрбүз")]
    public void FutureProbable_Биз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    
    [Theory]
    [InlineData("бар", "барбаспыз")]
    [InlineData("иште", "иштебеспиз")]
    [InlineData("бол", "болбоспуз")]
    [InlineData("көр", "көрбөспүз")]
    [InlineData("тап", "таппаспыз")]
    [InlineData("чеч", "чечпеспиз")]
    [InlineData("ук", "укпаспыз")]
    [InlineData("күт", "күтпөспүз")]
    public void FutureProbable_Биз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барарбызбы")]
    [InlineData("иште", "иштербизби")]
    [InlineData("бол", "болорбузбу")]
    [InlineData("көр", "көрөрбүзбү")]
    [InlineData("тап", "табарбызбы")]
    [InlineData("чеч", "чечербизби")]
    [InlineData("ук", "угарбызбы")]
    [InlineData("күт", "күтөрбүзбү")]
    public void FutureProbable_Биз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барбаспызбы")]
    [InlineData("иште", "иштебеспизби")]
    [InlineData("бол", "болбоспузбу")]
    [InlineData("көр", "көрбөспүзбү")]
    [InlineData("тап", "таппаспызбы")]
    [InlineData("чеч", "чечпеспизби")]
    [InlineData("ук", "укпаспызбы")]
    [InlineData("күт", "күтпөспүзбү")]
    public void FutureProbable_Биз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Биз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}