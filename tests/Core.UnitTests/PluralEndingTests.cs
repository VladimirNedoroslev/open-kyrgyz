using FluentAssertions;
using OpenKyrgyz.Core.Plural;

namespace UnitTests;

public class PluralEndingTests
{
    [Theory]
    [InlineData("кыз", "дар")]
    [InlineData("кат", "тар")]
    [InlineData("ката", "лар")]
    [InlineData("аары", "лар")]
    [InlineData("муз", "дар")]
    [InlineData("булут", "тар")]
    [InlineData("суу", "лар")]
    [InlineData("ачкыч", "тар")]
    [InlineData("жаңгак", "тар")]
    [InlineData("согуш", "тар")]
    public void GivenWordWithFirstVowelGroupEnding_WhenAppliedPlural_ThenCorrectPluralIsReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = PluralEnding.GetPluralAffix(verb);

        // assert
        actualResult.Value.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("эл", "дер")]
    [InlineData("жемиш", "тер")]
    [InlineData("эже", "лер")]
    [InlineData("байке", "лер")]
    [InlineData("керебет", "тер")]
    [InlineData("китеп", "тер")]
    [InlineData("ит", "тер")]
    [InlineData("миң", "дер")]
    [InlineData("кенеш", "тер")]
    public void GivenWordWithSecondVowelGroupEnding_WhenAppliedPlural_ThenCorrectPluralIsReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = PluralEnding.GetPluralAffix(verb);

        // assert
        actualResult.Value.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кол", "дор")]
    [InlineData("тоо", "лор")]
    [InlineData("тор", "лор")]
    [InlineData("той", "лор")]
    [InlineData("жол", "дор")]
    [InlineData("ооз", "дор")]
    [InlineData("тоок", "тор")]
    [InlineData("кой", "лор")]
    public void GivenWordWithThirdVowelGroupEnding_WhenAppliedPlural_ThenCorrectPluralIsReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = PluralEnding.GetPluralAffix(verb);

        // assert
        actualResult.Value.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("көл", "дөр")]
    [InlineData("өрдөк", "төр")]
    [InlineData("үй", "лөр")]
    [InlineData("жүк", "төр")]
    [InlineData("сөйкө", "лөр")]
    [InlineData("өзөн", "дөр")]
    [InlineData("чөнтөк", "төр")]
    [InlineData("дүйнө", "лөр")]
    public void GivenWordWithFourthVowelGroupEnding_WhenAppliedPlural_ThenCorrectPluralIsReturned(string verb, string expectedResult)
    {
        // act
        var actualResult = PluralEnding.GetPluralAffix(verb);

        // assert
        actualResult.Value.Should().Be(expectedResult);
    }
}