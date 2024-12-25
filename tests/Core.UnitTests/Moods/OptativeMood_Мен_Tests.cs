using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Moods;

namespace UnitTests.Moods;

public class OptativeMoodМенTests
{
    [Theory]
    [InlineData("кыл", "кылайын")]
    [InlineData("ташта", "таштайын")]
    [InlineData("айт", "айтайын")]
    [InlineData("тап", "табайын")]
    [InlineData("изилде", "изилдейин")]
    [InlineData("кет", "кетейин")]
    [InlineData("ойло", "ойлоюн")]
    [InlineData("кой", "коёюн")]
    [InlineData("күй", "күйөйүн")]
    [InlineData("түш", "түшөйүн")]
    [InlineData("ич", "ичейин")]
    [InlineData("же", "жейин")]
    [InlineData("жаса", "жасайын")]
    [InlineData("ал", "алайын")]
    public void OptativeMoodМен_Tests_Positive(string verb, string expectedResult)
    {
        var actualResult = OptativeMood.GetForМен(verb, VerbFormEnum.Positive);
    
        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("кыл", "кылбайын")]
    [InlineData("ташта", "таштабайын")]
    [InlineData("айт", "айтпайын")]
    [InlineData("тап", "таппайын")]
    [InlineData("изилде", "изилдебейин")]
    [InlineData("кет", "кетпейин")]
    [InlineData("ойло", "ойлобоюн")]
    [InlineData("кой", "койбоюн")]
    [InlineData("күй", "күйбөйүн")]
    [InlineData("түш", "түшпөйүн")]
    [InlineData("ич", "ичпейин")]
    [InlineData("же", "жебейин")]
    [InlineData("жаса", "жасабайын")]
    [InlineData("ал", "албайын")]
    public void OptativeMoodМен_Tests_Negative(string verb, string expectedResult)
    {
        var actualResult = OptativeMood.GetForМен(verb, VerbFormEnum.Negative);
    
        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("кыл", "кылайынбы")]
    [InlineData("ташта", "таштайынбы")]
    [InlineData("айт", "айтайынбы")]
    [InlineData("тап", "табайынбы")]
    [InlineData("изилде", "изилдейинби")]
    [InlineData("кет", "кетейинби")]
    [InlineData("ойло", "ойлоюнбу")]
    [InlineData("кой", "коёюнбу")]
    [InlineData("күй", "күйөйүнбү")]
    [InlineData("түш", "түшөйүнбү")]
    [InlineData("ич", "ичейинби")]
    [InlineData("же", "жейинби")]
    [InlineData("жаса", "жасайынбы")]
    [InlineData("ал", "алайынбы")]
    public void OptativeMoodМен_Tests_Interrogative(string verb, string expectedResult)
    {
        var actualResult = OptativeMood.GetForМен(verb, VerbFormEnum.Interrogative);
    
        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("кыл", "кылбайынбы")]
    [InlineData("ташта", "таштабайынбы")]
    [InlineData("айт", "айтпайынбы")]
    [InlineData("тап", "таппайынбы")]
    [InlineData("изилде", "изилдебейинби")]
    [InlineData("кет", "кетпейинби")]
    [InlineData("ойло", "ойлобоюнбу")]
    [InlineData("кой", "койбоюнбу")]
    [InlineData("күй", "күйбөйүнбү")]
    [InlineData("түш", "түшпөйүнбү")]
    [InlineData("ич", "ичпейинби")]
    [InlineData("же", "жебейинби")]
    [InlineData("жаса", "жасабайынбы")]
    [InlineData("ал", "албайынбы")]
    public void OptativeMoodМен_Tests_NegativeInterrogative(string verb, string expectedResult)
    {
        var actualResult = OptativeMood.GetForМен(verb, VerbFormEnum.NegativeAndInterrogative);
    
        // assert
        actualResult.Should().Be(expectedResult);
    }
}