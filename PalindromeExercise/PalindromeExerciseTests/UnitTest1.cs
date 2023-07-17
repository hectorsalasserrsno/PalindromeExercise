using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("salas", true)]
        [InlineData("hannah", true)]
        public void Test1(string word, bool expected )
        {
            //Arrange- prepare code
            var  instance = new WordSmith();

            //Act- call method
            var actual = instance.IsAPalindrome(word);



            //Assert- compare
            Assert.Equal(expected, actual);
        }
    }
}
