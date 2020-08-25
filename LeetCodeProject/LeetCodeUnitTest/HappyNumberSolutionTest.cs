using FluentAssertions;
using LeetCodeProject.AprilWeek1;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    public class HappyNumberSolutionTest
    {
        private HappyNumberSolution _happyNumberSolution;

        [SetUp]
        public void Setup()
        {
            _happyNumberSolution = new HappyNumberSolution();
        }

        [Test]
        public void Given_19_return_true()
        {
            // Arrange
            var input = 19;

            // Act
            var actual = _happyNumberSolution.IsHappy(input);

            // Assert
            actual.Should().BeTrue();
        }

        [Test]
        public void Given_2_return_false()
        {
            // Arrange
            var input = 2;

            // Act
            var actual = _happyNumberSolution.IsHappy(input);

            // Assert
            actual.Should().BeFalse();
        }

        [Test]
        public void Given_7_return_true()
        {
            // Arrange
            var input = 7;

            // Act
            var actual = _happyNumberSolution.IsHappy(input);

            // Assert
            actual.Should().BeTrue();
        }

        [Test]
        public void Given_1111111_return_true()
        {
            // Arrange
            var input = 1111111;

            // Act
            var actual = _happyNumberSolution.IsHappy(input);

            // Assert
            actual.Should().BeTrue();
        }

        [Test]
        public void Given_1_return_true()
        {
            // Arrange
            var input = 1;

            // Act
            var actual = _happyNumberSolution.IsHappy(input);

            // Assert
            actual.Should().BeTrue();
        }
    }
}