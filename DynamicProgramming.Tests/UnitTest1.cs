namespace DynamicProgramming.Tests
{
    public class UnitTestFactorial
    {
        [Fact]
        public void Test1Recursive()
        {
            // arrange

            // act
            int n = MathFunctionsRecursive.Factorial(1);
            // assert
            Assert.Equal(1, n);
        }

        [Fact]
        public void Test1DP()
        {
            // arrange

            // act
            int n = MathFunctionsDP.Factorial(1);
            // assert
            Assert.Equal(1, n);
        }

        [Fact]
        public void Test1Comparison()
        {
            // arrange
            // in the example, let's say Recursive is old and trusted
            // so what we want to test is the new one
            int value1 = MathFunctionsRecursive.Factorial(1);
            // act - the "system to test"
            int value2 = MathFunctionsDP.Factorial(1);
            // assert
            Assert.Equal(value1, value2);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        public void TestMultipleRecursive(int n, int expected)
        {
            // arrange

            // act
            int result = MathFunctionsRecursive.Factorial(n);
            // assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSum()
        {
            // arrange
            // act
            int result = MathFunctionsRecursive.Sum(1, 3);
            // assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void TestSumWithStartBiggerThanEnd()
        {
            // arrange
            // act
            int result = MathFunctionsRecursive.Sum(3, 1);
            // assert
            // the documented user requirement is that invalid sums result in 0
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestSumWithReallyBigInt()
        {
            // arrange
            Action testCode = () =>
            {
                int result = MathFunctionsRecursive.Sum(int.MaxValue - 2, int.MaxValue - 1);
            };
            // act
            var ex = Record.Exception(testCode);
            // assert
            Assert.IsType<OverflowException>(ex);
        }
    }
}