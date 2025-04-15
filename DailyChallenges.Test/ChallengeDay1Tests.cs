namespace DailyChallenges.Test;

public class ChallengeDay1Tests
{
    [Fact]
    public void ReverseString_InputIsNormalString_ReturnsReversedString()
    {
        // Arrange
        var challenge = new ChallengeDay1();
        var input = "Hi there!";
        var expected = "!ereht iH";

        // Act
        var result = challenge.ReverseString(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseString_InputIsEmptyString_ReturnsEmptyString()
    {
        // Arrange
        var challenge = new ChallengeDay1();
        var input = string.Empty;
        var expected = string.Empty;

        // Act
        var result = challenge.ReverseString(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseString_InputIsSingleCharacter_ReturnsSameCharacter()
    {
        // Arrange
        var challenge = new ChallengeDay1();
        var input = "A";
        var expected = "A";

        // Act
        var result = challenge.ReverseString(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseString_InputIsPalindrome_ReturnsSameString()
    {
        // Arrange
        var challenge = new ChallengeDay1();
        var input = "madam";
        var expected = "madam";

        // Act
        var result = challenge.ReverseString(input);

        // Assert
        Assert.Equal(expected, result);
    }
}

