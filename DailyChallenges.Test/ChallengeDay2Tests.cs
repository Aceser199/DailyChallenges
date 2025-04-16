namespace DailyChallenges.Test
{
    namespace DailyChallenges.Tests
    {
        public class ChallengeDay2Tests
        {
            [Fact]
            public void MergedSortedArray_BothArraysEmpty_ReturnsEmptyArray()
            {
                // Arrange
                var challenge = new ChallengeDay2();
                int[] firstArray = new int[] { };
                int[] secondArray = new int[] { };

                // Act
                var result = challenge.MergedSortedArray(firstArray, secondArray);

                // Assert
                Assert.Empty(result);
            }

            [Fact]
            public void MergedSortedArray_FirstArrayEmpty_ReturnsSecondArray()
            {
                // Arrange
                var challenge = new ChallengeDay2();
                int[] firstArray = new int[] { };
                int[] secondArray = new int[] { 4, 6, 30 };

                // Act
                var result = challenge.MergedSortedArray(firstArray, secondArray);

                // Assert
                Assert.Equal(secondArray, result);
            }

            [Fact]
            public void MergedSortedArray_SecondArrayEmpty_ReturnsFirstArray()
            {
                // Arrange
                var challenge = new ChallengeDay2();
                int[] firstArray = new int[] { 0, 3, 4, 31 };
                int[] secondArray = new int[] { };

                // Act
                var result = challenge.MergedSortedArray(firstArray, secondArray);

                // Assert
                Assert.Equal(firstArray, result);
            }

            [Fact]
            public void MergedSortedArray_BothArraysNonEmpty_ReturnsMergedSortedArray()
            {
                // Arrange
                var challenge = new ChallengeDay2();
                int[] firstArray = new int[] { 0, 3, 4, 31 };
                int[] secondArray = new int[] { 4, 6, 30 };

                // Act
                var result = challenge.MergedSortedArray(firstArray, secondArray);

                // Assert
                int[] expected = new int[] { 0, 3, 4, 4, 6, 30, 31 };
                Assert.Equal(expected, result);
            }

            [Fact]
            public void MergedSortedArray_DuplicateElements_ReturnsMergedSortedArrayWithDuplicates()
            {
                // Arrange
                var challenge = new ChallengeDay2();
                int[] firstArray = new int[] { 1, 3, 5, 7 };
                int[] secondArray = new int[] { 2, 3, 6, 7 };

                // Act
                var result = challenge.MergedSortedArray(firstArray, secondArray);

                // Assert
                int[] expected = new int[] { 1, 2, 3, 3, 5, 6, 7, 7 };
                Assert.Equal(expected, result);
            }
        }
    }

}
