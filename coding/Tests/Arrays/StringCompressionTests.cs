using NUnit.Framework;
using Solutions.Arrays;

namespace Solutions.Tests.Arrays
{
    [TestFixture]
    public class StringCompressionTests
    {
        private StringCompression compressor;

        [SetUp]
        public void Setup()
        {
            compressor = new StringCompression();
        }

        [Test]
        public void Compress_Example1()
        {
            char[] chars = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            char[] expected = { 'a', '2', 'b', '2', 'c', '3' };
            int expectedLength = 6;
            int actualLength = compressor.Compress(chars);
            Assert.That(actualLength, Is.EqualTo(expectedLength));
            Assert.That(chars[..actualLength], Is.EqualTo(expected));
        }

        [Test]
        public void Compress_Example2()
        {
            char[] chars = { 'a' };
            char[] expected = { 'a' };
            int expectedLength = 1;
            int actualLength = compressor.Compress(chars);
            Assert.That(actualLength, Is.EqualTo(expectedLength));
            Assert.That(chars[..actualLength], Is.EqualTo(expected));
        }

        [Test]
        public void Compress_Example3()
        {
            char[] chars = { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
            char[] expected = { 'a', 'b', '1', '2' };
            int expectedLength = 4;
            int actualLength = compressor.Compress(chars);
            Assert.That(actualLength, Is.EqualTo(expectedLength));
             Assert.That(chars[..actualLength], Is.EqualTo(expected));
        }

        [Test]
        public void Compress_EmptyArray()
        {
            char[] chars = { };
            char[] expected = { };
            int expectedLength = 0;
            int actualLength = compressor.Compress(chars);
            Assert.That(actualLength, Is.EqualTo(expectedLength));
             Assert.That(chars[..actualLength], Is.EqualTo(expected));
        }

        [Test]
        public void Compress_AllSameCharacters()
        {
            char[] chars = { 'a', 'a', 'a', 'a', 'a' };
            char[] expected = { 'a', '5' };
            int expectedLength = 2;
            int actualLength = compressor.Compress(chars);
            Assert.That(actualLength, Is.EqualTo(expectedLength));
            Assert.That(chars[..actualLength], Is.EqualTo(expected));
        }

        [Test]
        public void Compress_NoRepeatingCharacters()
        {
            char[] chars = { 'a', 'b', 'c', 'd', 'e' };
            char[] expected = { 'a', 'b', 'c', 'd', 'e' };
            int expectedLength = 5;
            int actualLength = compressor.Compress(chars);
            Assert.That(actualLength, Is.EqualTo(expectedLength));
            Assert.That(chars[..actualLength], Is.EqualTo(expected));
        }
        
        [Test]
        public void Compress_MixedCharacters()
        {
            char[] chars = { 'a', 'a', 'a', 'b', 'b', 'c', 'c', 'c', 'c', 'd', 'd', 'd', 'd', 'd'};
            char[] expected = { 'a', '3', 'b', '2', 'c', '4', 'd', '5'};
            int expectedLength = 8;
            int actualLength = compressor.Compress(chars);
            Assert.That(actualLength, Is.EqualTo(expectedLength));
            Assert.That(chars[..actualLength], Is.EqualTo(expected));

        }
        
        [Test]
        public void Compress_LargeRepetitions()
        {
            char[] chars = new char[100];
            for(int i=0; i<100; i++)
            {
                chars[i] = 'a';
            }
            char[] expected = { 'a', '1', '0', '0' };
            int expectedLength = 4;
            int actualLength = compressor.Compress(chars);
            Assert.That(actualLength, Is.EqualTo(expectedLength));
            Assert.That(chars[..actualLength], Is.EqualTo(expected));
        }
        [Test]
         public void Compress_AllDifferentSingle()
        {
            char[] chars = { 'a', 'b','c','d','e','f','g','h','i'};
            char[] expected = { 'a', 'b','c','d','e','f','g','h','i'};
            int expectedLength = 9;
            int actualLength = compressor.Compress(chars);
            Assert.That(actualLength, Is.EqualTo(expectedLength));
             Assert.That(chars[..actualLength], Is.EqualTo(expected));
        }
        [Test]
        public void Compress_RepeatingSingleLetters()
        {
            char[] chars = {'a','a','b','c','c','d','d','d','e','e'};
            char[] expected = { 'a','2','b','c','2','d','3','e','2'};
            int expectedLength = 9;
            int actualLength = compressor.Compress(chars);
            Assert.That(actualLength, Is.EqualTo(expectedLength));
             Assert.That(chars[..actualLength], Is.EqualTo(expected));
        }
    }
}
