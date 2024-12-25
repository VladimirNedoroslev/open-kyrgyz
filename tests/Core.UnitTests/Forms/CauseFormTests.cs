using FluentAssertions;
using OpenKyrgyz.Core.Enums;
using OpenKyrgyz.Core.Forms;
using OpenKyrgyz.Core.Forms.While;

namespace UnitTests.Forms;

public class CauseFormTests
{
    [Theory]
    [InlineData("кыл","кылгандыктан")]
    [InlineData("ташта","таштагандыктан")]
    [InlineData("айт","айткандыктан")]
    [InlineData("тап","тапкандыктан")]
    [InlineData("изилде","изилдегендиктен")]
    [InlineData("кет","кеткендиктен")]
    [InlineData("ойло","ойлогондуктан")]
    [InlineData("күй","күйгөндүктөн")]
    [InlineData("түш","түшкөндүктөн")]
    public void CauseForm_Tests_Positive(string verb, string expectedResult)
    {
        var actualResult = CauseForm.Get(verb, VerbFormEnum.Positive);

        // assert
        actualResult.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData("кыл","кылбагандыктан")]
    [InlineData("ташта","таштабагандыктан")]
    [InlineData("айт","айтпагандыктан")]
    [InlineData("тап","таппагандыктан")]
    [InlineData("изилде","изилдебегендиктен")]
    [InlineData("кет","кетпегендиктен")]
    [InlineData("ойло","ойлобогондуктан")]
    [InlineData("күй","күйбөгөндүктөн")]
    [InlineData("түш","түшпөгөндүктөн")]
    public void CauseForm_Tests_Negative(string verb, string expectedResult)
    {
        var actualResult = CauseForm.Get(verb, VerbFormEnum.Negative);

        // assert
        actualResult.Should().Be(expectedResult);
    }
}