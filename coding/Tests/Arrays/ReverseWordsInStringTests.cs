using NUnit.Framework;
using Solutions.Arrays;

namespace Solutions.Tests.Arrays
{
    [TestFixture]
    public class ReverseWordsInStringTests
    {
        private ReverseWordsInString reverser;

        [SetUp]
        public void Setup()
        {
            reverser = new ReverseWordsInString();
        }

        [Test]
        public void ReverseWords_Example1()
        {
            string input = "the sky is blue";
            string expected = "blue is sky the";
            Assert.That(reverser.ReverseWords(input), Is.EqualTo(expected));
        }

        [Test]
        public void ReverseWords_Example2()
        {
            string input = "  hello world  ";
            string expected = "world hello";
            Assert.That(reverser.ReverseWords(input), Is.EqualTo(expected));
        }

        [Test]
        public void ReverseWords_Example3()
        {
            string input = "a good   example";
            string expected = "example good a";
            Assert.That(reverser.ReverseWords(input), Is.EqualTo(expected));
        }

        [Test]
        public void ReverseWords_SingleWord()
        {
            string input = "word";
            string expected = "word";
            Assert.That(reverser.ReverseWords(input), Is.EqualTo(expected));
        }

        [Test]
        public void ReverseWords_EmptyString()
        {
            string input = "";
            string expected = "";
            Assert.That(reverser.ReverseWords(input), Is.EqualTo(expected));
        }
        [Test]
        public void ReverseWords_MultipleSpacesBetween()
        {
            string input = "  hello   world   again  ";
            string expected = "again world hello";
            Assert.That(reverser.ReverseWords(input), Is.EqualTo(expected));
        }

        [Test]
        public void ReverseWords_LeadingSpaces()
        {
            string input = "   leading spaces";
            string expected = "spaces leading";
            Assert.That(reverser.ReverseWords(input), Is.EqualTo(expected));
        }

        [Test]
        public void ReverseWords_TrailingSpaces()
        {
            string input = "trailing spaces   ";
            string expected = "spaces trailing";
            Assert.That(reverser.ReverseWords(input), Is.EqualTo(expected));
        }

        [Test]
        public void ReverseWords_OnlySpaces()
        {
            string input = "     ";
            string expected = "";
            Assert.That(reverser.ReverseWords(input), Is.EqualTo(expected));
        }
        
    }
}
