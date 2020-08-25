using FluentAssertions;
using LeetCodeProject.AprilWeek1;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    public class SingleNumberSolutionTest
    {
        private SingleNumberSolution _aprilWeek1Solution;

        [SetUp]
        public void Setup()
        {
            _aprilWeek1Solution = new SingleNumberSolution();
        }

        [Test]
        public void SingleNumberTest_given_221_return_1()
        {
            // Arrange
            var input = new[] {2, 2, 1};
            var excepted = 1;

            // Act
            var actual = _aprilWeek1Solution.SingleNumber(input);

            // Assert
            actual.Should().Be(excepted);
        }

        [Test]
        public void SingleNumberTest_given_41212_return_4()
        {
            // Arrange
            var input = new[] {4, 1, 2, 1, 2};
            var excepted = 4;

            // Act
            var actual = _aprilWeek1Solution.SingleNumber(input);

            // Assert
            actual.Should().Be(excepted);
        }
    }
}