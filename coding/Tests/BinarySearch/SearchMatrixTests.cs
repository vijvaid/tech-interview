using NUnit.Framework;
using Solutions.BinarySearch;

namespace Solutions.Tests.BinarySearch
{
    [TestFixture]
    public class SearchMatrixTests
    {
        [Test]
        public void Search2DMatrix_TargetExists_ReturnsTrue()
        {
            int[][] matrix = [
                [1, 3, 5, 7],
                [10, 11, 16, 20],
                [23, 30, 34, 60]
            ];
            int target = 3;
            Assert.That(SearchMatrix.Search2DMatrix(matrix, target), Is.True);
        }

        [Test]
        public void Search2DMatrix_TargetDoesNotExist_ReturnsFalse()
        {
            int[][] matrix = [
                [1, 3, 5, 7],
                [10, 11, 16, 20],
                [23, 30, 34, 60]
            ];
            int target = 13;
            Assert.That(SearchMatrix.Search2DMatrix(matrix, target), Is.False);
        }

        [Test]
        public void Search2DMatrix_EmptyMatrix_ReturnsFalse()
        {
            int[][] matrix = [];
            int target = 5;
            Assert.That(SearchMatrix.Search2DMatrix(matrix, target), Is.False);
        }
        
        [Test]
        public void Search2DMatrix_SingleRowMatrix_TargetExists_ReturnsTrue()
        {
            int[][] matrix = [[1, 3, 5, 7]];
            int target = 5;
            Assert.That(SearchMatrix.Search2DMatrix(matrix, target), Is.True);
        }

        [Test]
        public void Search2DMatrix_SingleRowMatrix_TargetDoesNotExist_ReturnsFalse()
        {
            int[][] matrix = [[1, 3, 5, 7]];
            int target = 2;
            Assert.That(SearchMatrix.Search2DMatrix(matrix, target), Is.False);
        }

        [Test]
        public void Search2DMatrix_SingleElementMatrix_TargetExists_ReturnsTrue()
        {
            int[][] matrix = [[5]];
            int target = 5;
            Assert.That(SearchMatrix.Search2DMatrix(matrix, target), Is.True);
        }

        [Test]
        public void Search2DMatrix_SingleElementMatrix_TargetDoesNotExist_ReturnsFalse()
        {
            int[][] matrix = [[5]];
            int target = 10;
            Assert.That(SearchMatrix.Search2DMatrix(matrix, target), Is.False);
        }

        [Test]
        public void Search2DMatrix_TargetLessThanFirstElement_ReturnsFalse()
        {
            int[][] matrix = [
                [1, 3, 5, 7],
                [10, 11, 16, 20],
                [23, 30, 34, 60]
            ];
            int target = 0;
            Assert.That(SearchMatrix.Search2DMatrix(matrix, target), Is.False);
        }

        [Test]
        public void Search2DMatrix_TargetGreaterThanLastElement_ReturnsFalse()
        {
            int[][] matrix = [
                [1, 3, 5, 7],
                [10, 11, 16, 20],
                [23, 30, 34, 60]
            ];
            int target = 61;
            Assert.That(SearchMatrix.Search2DMatrix(matrix, target), Is.False);
        }
        
        [Test]
        public void Search2DMatrix_TargetInFirstRow_ReturnsTrue()
        {
             int[][] matrix = [
                [1, 3, 5, 7],
                [10, 11, 16, 20],
                [23, 30, 34, 60]
            ];
            int target = 1;
            Assert.That(SearchMatrix.Search2DMatrix(matrix, target), Is.True);
        }

         [Test]
        public void Search2DMatrix_TargetInLastRow_ReturnsTrue()
        {
             int[][] matrix = [
                [1, 3, 5, 7],
                [10, 11, 16, 20],
                [23, 30, 34, 60]
            ];
            int target = 60;
            Assert.That(SearchMatrix.Search2DMatrix(matrix, target), Is.True);
        }

        [Test]
        public void Search2DMatrix_NegativeNumbers_ReturnsTrue()
        {
           int[][] matrix = [
                [-10, -5, 0],
                [5, 10, 15],
                [20, 25, 30]
            ];
            int target = 10;
            Assert.That(SearchMatrix.Search2DMatrix(matrix, target), Is.True);
        }
        [Test]
        public void Search2DMatrix_NegativeNumbers_ReturnsFalse()
        {
           int[][] matrix = [
                [-10, -5, 0],
                [5, 10, 15],
                [20, 25, 30]
            ];
            int target = -2;
            Assert.That(SearchMatrix.Search2DMatrix(matrix, target), Is.False);
        }

        [Test]
        public void Search2DMatrix_TargetIsFirstOfRow()
        {
             int[][] matrix = [
                [1, 3, 5, 7],
                [10, 11, 16, 20],
                [23, 30, 34, 60]
            ];
            int target = 10;
            Assert.That(SearchMatrix.Search2DMatrix(matrix, target), Is.True);
        }

        [Test]
         public void Search2DMatrix_MultipleRowsWithSameStart()
        {
             int[][] matrix = [
                [1, 3, 5, 7],
                [1, 11, 16, 20],
                [23, 30, 34, 60]
            ];
            int target = 11;
            Assert.That(SearchMatrix.Search2DMatrix(matrix, target), Is.True);
        }
    }
}
