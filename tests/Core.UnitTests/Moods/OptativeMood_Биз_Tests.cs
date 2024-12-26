using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Verbs.Moods;

namespace UnitTests.Moods;

public class OptativeMoodБизTests
{
    [Theory]
    [InlineData("кыл", "кылалы")]
    [InlineData("бар", "баралы")]
    [InlineData("ташта", "таштайлы")]
    [InlineData("айт", "айталы")]
    [InlineData("тап", "табалы")]
    [InlineData("изилде", "изилдейли")]
    [InlineData("кет", "кетели")]
    [InlineData("ойло", "ойлойлу")]
    [InlineData("кой", "коёлу")]
    [InlineData("күй", "күйөлү")]
    [InlineData("түш", "түшөлү")]
    [InlineData("ич", "ичели")]
    [InlineData("же", "жейли")]
    [InlineData("жаса", "жасайлы")]
    [InlineData("ал", "алалы")]
    public void OptativeMoodБиз_Tests_Positive(string verb, string expectedResult)
    {
        var actualResult = OptativeMood.GetForБиз(verb, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбайлы")]
    [InlineData("бар", "барбайлы")]
    [InlineData("ташта", "таштабайлы")]
    [InlineData("айт", "айтпайлы")]
    [InlineData("тап", "таппайлы")]
    [InlineData("изилде", "изилдебейли")]
    [InlineData("кет", "кетпейли")]
    [InlineData("ойло", "ойлобойлу")]
    [InlineData("кой", "койбойлу")]
    [InlineData("күй", "күйбөйлү")]
    [InlineData("түш", "түшпөйлү")]
    [InlineData("ич", "ичпейли")]
    [InlineData("же", "жебейли")]
    [InlineData("жаса", "жасабайлы")]
    [InlineData("ал", "албайлы")]
    public void OptativeMoodБиз_Tests_Negative(string verb, string expectedResult)
    {
        var actualResult = OptativeMood.GetForБиз(verb, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылалыбы")]
    [InlineData("бар", "баралыбы")]
    [InlineData("ташта", "таштайлыбы")]
    [InlineData("айт", "айталыбы")]
    [InlineData("тап", "табалыбы")]
    [InlineData("изилде", "изилдейлиби")]
    [InlineData("кет", "кетелиби")]
    [InlineData("ойло", "ойлойлубу")]
    [InlineData("кой", "коёлубу")]
    [InlineData("күй", "күйөлүбү")]
    [InlineData("түш", "түшөлүбү")]
    [InlineData("ич", "ичелиби")]
    [InlineData("же", "жейлиби")]
    [InlineData("жаса", "жасайлыбы")]
    [InlineData("ал", "алалыбы")]
    public void OptativeMoodБиз_Tests_Interrogative(string verb, string expectedResult)
    {
        var actualResult = OptativeMood.GetForБиз(verb, VerbFormEnum.Interrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("кыл", "кылбайлыбы")]
    [InlineData("бар", "барбайлыбы")]
    [InlineData("ташта", "таштабайлыбы")]
    [InlineData("айт", "айтпайлыбы")]
    [InlineData("тап", "таппайлыбы")]
    [InlineData("изилде", "изилдебейлиби")]
    [InlineData("кет", "кетпейлиби")]
    [InlineData("ойло", "ойлобойлубу")]
    [InlineData("кой", "койбойлубу")]
    [InlineData("күй", "күйбөйлүбү")]
    [InlineData("түш", "түшпөйлүбү")]
    [InlineData("ич", "ичпейлиби")]
    [InlineData("же", "жебейлиби")]
    [InlineData("жаса", "жасабайлыбы")]
    [InlineData("ал", "албайлыбы")]
    public void OptativeMoodБиз_Tests_NegativeInterrogative(string verb, string expectedResult)
    {
        var actualResult = OptativeMood.GetForБиз(verb, VerbFormEnum.NegativeAndInterrogative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}