using System.Collections.Generic;
using System;
using Xunit;
namespace LeetSpeak.Objects
{
  public class LeetSpeakTest
  {
    [Fact]
    public void LeetSpeakGenerator_userInputTree_ReturnM3()
    {
      //Arrange
      string expectedResult = "M3";
      LeetSpeakTranslator newLeetSpeakTranslator = new LeetSpeakTranslator();

      //Act
      string result = newLeetSpeakTranslator.LeetSpeakGenerator("Me");

      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void LeetSpeakGenerator_userInputBob_ReturnB0b()
    {
      //Arrange
      string expectedResult = "B0b";
      LeetSpeakTranslator newLeetSpeakTranslator = new LeetSpeakTranslator();

      //Act
      string result = newLeetSpeakTranslator.LeetSpeakGenerator("Bob");

      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void LeetSpeakGenerator_userInputTree_Return7r33()
    {
      //Arrange
      string expectedResult = "7r33";
      LeetSpeakTranslator newLeetSpeakTranslator = new LeetSpeakTranslator();

      //Act
      string result = newLeetSpeakTranslator.LeetSpeakGenerator("Tree");

      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void LeetSpeakGenerator_userInputInitiate_Return1ni7ia73()
    {
      //Arrange
      string expectedResult = "1ni7ia73";
      LeetSpeakTranslator newLeetSpeakTranslator = new LeetSpeakTranslator();

      //Act
      string result = newLeetSpeakTranslator.LeetSpeakGenerator("Initiate");

      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void LeetSpeakGenerator_userInputPass_ReturnPazz()
    {
      //Arrange
      string expectedResult = "Pazz";
      LeetSpeakTranslator newLeetSpeakTranslator = new LeetSpeakTranslator();

      //Act
      string result = newLeetSpeakTranslator.LeetSpeakGenerator("Pass");

      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void LeetSpeakGenerator_userInputSnakes_ReturnSnak3z()
    {
      //Arrange
      string expectedResult = "Snak3z";
      LeetSpeakTranslator newLeetSpeakTranslator = new LeetSpeakTranslator();

      //Act
      string result = newLeetSpeakTranslator.LeetSpeakGenerator("Snakes");

      //Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void LeetSpeakGenerator_userInputSnakesSlither_ReturnSnak3zSli7h3r()
    {
      //Arrange
      string expectedResult = "Snak3z sli7h3r";
      LeetSpeakTranslator newLeetSpeakTranslator = new LeetSpeakTranslator();

      //Act
      string result = newLeetSpeakTranslator.LeetSpeakGenerator("Snakes slither");

      //Assert
      Assert.Equal(expectedResult, result);
    }
  }
}
