using FluentAssertions;
using OpenKyrgyz.Core.Plural;

namespace UnitTests;

public class PluralExtensionsTests
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
    [InlineData("эл", "дер")]
    [InlineData("жемиш", "тер")]
    [InlineData("эже", "лер")]
    [InlineData("байке", "лер")]
    [InlineData("керебет", "тер")]
    [InlineData("китеп", "тер")]
    [InlineData("ит", "тер")]
    [InlineData("миң", "дер")]
    [InlineData("кенеш", "тер")]
    [InlineData("кол", "дор")]
    [InlineData("тоо", "лор")]
    [InlineData("тор", "лор")]
    [InlineData("той", "лор")]
    [InlineData("жол", "дор")]
    [InlineData("ооз", "дор")]
    [InlineData("тоок", "тор")]
    [InlineData("кой", "лор")]
    [InlineData("көл", "дөр")]
    [InlineData("өрдөк", "төр")]
    [InlineData("үй", "лөр")]
    [InlineData("жүк", "төр")]
    [InlineData("сөйкө", "лөр")]
    [InlineData("өзөн", "дөр")]
    [InlineData("чөнтөк", "төр")]
    [InlineData("дүйнө", "лөр")]
    public void NounPlural(string verb, string expectedResult)
    {
        // act
        var actualResult = PluralExtensions.GetPluralAffix(verb);

        // assert
        actualResult.Value.Should().Be(expectedResult);
    }
}