using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Tenses.FutureProbable;

namespace UnitTests.Tenses.FutureProbable;

public class FutureProbableСизTests
{
    [Theory]
    [InlineData("бар", "барарсыз")]
    [InlineData("иште", "иштерсиз")]
    [InlineData("бол", "болорсуз")]
    [InlineData("көр", "көрөрсүз")]
    [InlineData("тап", "табарсыз")]
    [InlineData("чеч", "чечерсиз")]
    [InlineData("ук", "угарсыз")]
    [InlineData("күт", "күтөрсүз")]
    [InlineData("кой", "коёрсуз")]
    public void FutureProbable_Сиз_Positive(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    
    [Theory]
    [InlineData("бар", "барбассыз")]
    [InlineData("иште", "иштебессиз")]
    [InlineData("бол", "болбоссуз")]
    [InlineData("көр", "көрбөссүз")]
    [InlineData("тап", "таппассыз")]
    [InlineData("чеч", "чечпессиз")]
    [InlineData("ук", "укпассыз")]
    [InlineData("күт", "күтпөссүз")]
    public void FutureProbable_Сиз_Negative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барарсызбы")]
    [InlineData("иште", "иштерсизби")]
    [InlineData("бол", "болорсузбу")]
    [InlineData("көр", "көрөрсүзбү")]
    [InlineData("тап", "табарсызбы")]
    [InlineData("чеч", "чечерсизби")]
    [InlineData("ук", "угарсызбы")]
    [InlineData("күт", "күтөрсүзбү")]
    [InlineData("кой", "коёрсузбу")]
    public void FutureProbable_Сиз_Interrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("бар", "барбассызбы")]
    [InlineData("иште", "иштебессизби")]
    [InlineData("бол", "болбоссузбу")]
    [InlineData("көр", "көрбөссүзбү")]
    [InlineData("тап", "таппассызбы")]
    [InlineData("чеч", "чечпессизби")]
    [InlineData("ук", "укпассызбы")]
    [InlineData("күт", "күтпөссүзбү")]
    public void FutureProbable_Сиз_NegativeInterrogative(string verb, string expectedResult)
    {
        // act
        var actualResult = FutureProbableConjugator.Conjugate(verb, PronounEnum.Сиз, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}