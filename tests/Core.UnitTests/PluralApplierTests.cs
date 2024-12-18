using FluentAssertions;
using OpenKyrgyz.Core.Common;

namespace UnitTests;

public class PluralApplierTests
{
    [Theory]
    [InlineData("кыз", "кыздар")]
    [InlineData("кат", "каттар")]
    [InlineData("ката", "каталар")]
    [InlineData("аары", "аарылар")]
    [InlineData("муз", "муздар")]
    [InlineData("булут", "булуттар")]
    [InlineData("суу", "суулар")]
    [InlineData("ачкыч", "ачкычтар")]
    [InlineData("жаңгак", "жаңгактар")]
    [InlineData("согуш", "согуштар")]
    public void GivenWordWithFirstVowelGroupEnding_WhenAppliedPlural_ThenCorrectPlurarlIsReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = PluralApplier.Apply(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("эл", "элдер")]
    [InlineData("жемиш", "жемиштер")]
    [InlineData("эже", "эжелер")]
    [InlineData("байке", "байкелер")]
    [InlineData("керебет", "керебеттер")]
    [InlineData("китеп", "китептер")]
    [InlineData("ит", "иттер")]
    [InlineData("миң", "миңдер")]
    [InlineData("кенеш", "кенештер")]
    public void GivenWordWithSecondVowelGroupEnding_WhenAppliedPlural_ThenCorrectPlurarlIsReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = PluralApplier.Apply(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кол", "колдор")]
    [InlineData("тоо", "тоолор")]
    [InlineData("тор", "торлор")]
    [InlineData("той", "тойлор")]
    [InlineData("жол", "жолдор")]
    [InlineData("ооз", "ооздор")]
    [InlineData("тоок", "тооктор")]
    [InlineData("кой", "койлор")]
    public void GivenWordWithThirdVowelGroupEnding_WhenAppliedPlural_ThenCorrectPlurarlIsReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = PluralApplier.Apply(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("көл", "көлдөр")]
    [InlineData("өрдөк", "өрдөктөр")]
    [InlineData("үй", "үйлөр")]
    [InlineData("жүк", "жүктөр")]
    [InlineData("сөйкө", "сөйкөлөр")]
    [InlineData("өзөн", "өзөндөр")]
    [InlineData("чөнтөк", "чөнтөктөр")]
    [InlineData("дүйнө", "дүйнөлөр")]
    public void GivenWordWithFourthVowelGroupEnding_WhenAppliedPlural_ThenCorrectPlurarlIsReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = PluralApplier.Apply(verb);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}