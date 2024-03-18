using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        //Add [Theory] keyword
        //and [InlineData()] -----below with input test data
        [Theory]
        [InlineData("tacocat", true)]
        [InlineData("racecar", true)]
        [InlineData("computer", false)]

        //create method to test
        public void PalindromeCheck(string input, bool check)
        {
            //Arrange - create new object
            var palindromeTest = new WordSmith();

            //Act - store object.method in actual variable
            var actual = palindromeTest.IsAPalindrome(input);

            //Assert
            Assert.Equal(check, actual);
        }
    }
}
