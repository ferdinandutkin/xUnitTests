
using System;
using System.IO;
using System.Linq;
using FluentAssertions;
using StringExtensions;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        #region Reverse

        [Trait("Category", "Reverse")]
        [Theory]
        [ClassData(typeof(ReverseTestData))]
        public void Reverse_ReversesString(string input, string expected)
        {

            var actual = input.Reverse();

            actual.Should()
                .Be(expected);
        }

        [Trait("Category", "Reverse")]
        [Fact]
        public void Reverse_WhenArgumentIsNull_ThrowsArgumentNullException()
        {
            string input = null;

            Action action = () => input.Reverse();

            action.Should()
                .Throw<ArgumentNullException>();

        }

        [Trait("Category", "Reverse")]
        [Fact]
        public void Reverse_WhenArgumentIsValid_DoesNotThrowException()
        {
            var input = Faker.Lorem.Sentence(20);


            input.Invoking(i => i.Reverse())
                .Should()
                .NotThrow();

        }

        #endregion

        #region InvertCase

        [Trait("Category", "Invert Case")]
        [Theory]
        [ClassData(typeof(EquivalentStringTestData))]
        public void InvertCase_ReturnsEquivalentString(string input)
        {

            var actual = input.InvertCase();

            input.Should()
                .ContainEquivalentOf(actual);
        }

        [Trait("Category", "Invert Case")]
        [Theory]
        [ClassData(typeof(InvertCaseTestData))]
        public void InvertCase_ReturnsStringWithInvertedCase(string input, string expected)
        {

            var actual = input.InvertCase();

            actual.Should()
                .Be(expected);

        }

        [Trait("Category", "Invert Case")]
        [Fact]
        public void InvertCase_WhenArgumentIsNull_ThrowsArgumentNullException()
        {

            string input = null;

            Action action = () => input.InvertCase();

            action.Should()
                .Throw<ArgumentNullException>();

        }


        #endregion

        #region ToAbbreviation

        [Trait("Category", "To Abbreviation")]
        [Fact]
        public void ToAbbreviation_WhenArgumentContainsOnlyOneWord_ReturnsFirstLetterCapitalised()
        {

            var input = Faker.Lorem.GetFirstWord();

            var expected = char.ToUpper(input[0]).ToString();

            var actual = input.ToAbbreviation();

            actual.Should()
                .Be(expected);

        }

        [Trait("Category", "To Abbreviation")]
        [Theory]
        [InlineData("alpha     beta", "AB")]
        public void ToAbbreviation_WhenTheyAreManySpacesBetweenWords_ReturnsCorrectResult(string input, string expected)
        {

            var actual = input.ToAbbreviation();

            actual.Should()
                .Be(expected);

        }


        [Trait("Category", "To Abbreviation")]
        [Theory]
        [ClassData(typeof(ToAbbreviationTestData))]
        public void ToAbbreviation_ReturnsAbbreviation(string input, string expected)
        {

            var actual = input.ToAbbreviation();

            actual.Should()
                .Be(expected);

        }

        [Trait("Category", "To Abbreviation")]
        [Fact]
        public void ToAbbreviation_WhenArgumentIsNull_ThrowsArgumentNullException()
        {

            string input = null;

            Action action = () => input.ToAbbreviation();

            action.Should()
                .Throw<ArgumentNullException>();

        }


        #endregion

        #region ToTitleCase

        [Theory]
        [Trait("Category", "ToTitleCase")]
        [ClassData(typeof(EquivalentStringTestData))]
        public void ToTitleCase_ReturnsEquivalentString(string input)
        {

            var actual = input.ToTitleCase();

            input.Should()
                .ContainEquivalentOf(actual);
        }


        [Theory]
        [Trait("Category", "ToTitleCase")]
        [InlineData("tumash stanislav igorevich", "Tumash Stanislav Igorevich")]
        [InlineData("belarusian state technological university", "Belarusian State Technological University")]
        public void ToTitleCase_ReturnsStringInTitleCase(string input, string expected)
        {

            var actual = input.ToTitleCase();

            input.Should()
                .ContainEquivalentOf(actual);
        }

        [Trait("Category", "To Abbreviation")]
        [Fact]
        public void ToTitleCase_WhenArgumentIsNull_ThrowsArgumentNullException()
        {

            string input = null;

            Action action = () => input.ToTitleCase();

            action.Should()
                .Throw<ArgumentNullException>();

        }

        #endregion

    }
}