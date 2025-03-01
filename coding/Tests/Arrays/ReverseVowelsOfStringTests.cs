using NUnit.Framework;
using Solutions.Arrays;

namespace Solutions.Tests.Arrays
{
    [TestFixture]
    public class ReverseVowelsOfStringTests
    {
        private ReverseVowelsOfString reverser;

        [SetUp]
        public void Setup()
        {
            reverser = new ReverseVowelsOfString();
        }

        [Test]
        public void ReverseVowels_Example1()
        {
            string input = "hello";
            string expected = "holle";
            string actual = reverser.ReverseVowels(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseVowels_Example2()
        {
            string input = "leetcode";
            string expected = "leotcede";
            string actual = reverser.ReverseVowels(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseVowels_NoVowels()
        {
            string input = "bcdfgh";
            string expected = "bcdfgh";
            string actual = reverser.ReverseVowels(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseVowels_AllVowels()
        {
            string input = "aeiou";
            string expected = "uoiea";
            string actual = reverser.ReverseVowels(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void ReverseVowels_AllVowelsUppercase()
        {
            string input = "AEIOU";
            string expected = "UOIEA";
            string actual = reverser.ReverseVowels(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
        

        [Test]
        public void ReverseVowels_SingleVowel()
        {
            string input = "bca";
            string expected = "bca";
            string actual = reverser.ReverseVowels(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseVowels_EmptyString()
        {
            string input = "";
            string expected = "";
            string actual = reverser.ReverseVowels(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseVowels_SingleCharacter_Vowel()
        {
            string input = "a";
            string expected = "a";
            string actual = reverser.ReverseVowels(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseVowels_SingleCharacter_Consonant()
        {
            string input = "b";
            string expected = "b";
            string actual = reverser.ReverseVowels(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseVowels_MixedCase()
        {
            string input = "hEllO";
            string expected = "hOllE";
            string actual = reverser.ReverseVowels(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void ReverseVowels_MixedCaseComplex()
        {
            string input = "aAeiOu";
            string expected = "uOieAa";
            string actual = reverser.ReverseVowels(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void ReverseVowels_OneVowel_AtBeginning()
        {
            string input = "aBcD";
            string expected = "aBcD";
            string actual = reverser.ReverseVowels(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseVowels_OneVowel_AtEnd()
        {
            string input = "BcDa";
            string expected = "BcDa";
            string actual = reverser.ReverseVowels(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
         public void ReverseVowels_TwoSameVowels()
        {
            string input = "aaba";
            string expected = "aaba";
            string actual = reverser.ReverseVowels(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void ReverseVowels_LongString_Complex()
        {
            string input = "ProgrammingIsFunAndChallenging";
            string expected = "PrigremmangAsFunIndChillangong";
            string actual = reverser.ReverseVowels(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}
