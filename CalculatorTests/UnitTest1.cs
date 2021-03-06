using Assignment1;
using Calculator;

namespace CalculatorTests
{
    public class UnitTest1
    {
        [Fact]
        static void AdditionTest()
        {
            cal c = new cal();
            int result = c.Addition(1,2);
            Assert.Equal(3, result);         

        }
        [Fact]
        static void AdditionTest2()
        {
            cal c = new cal();
            int []input = {1,2,3};    
            int result = c.Addition(input);
            Assert.Equal(6, result);

        }
        [Fact]
        static void SubtractionTest()
        {
            cal c = new cal();
            int result = c.Subtraction(1, 2);
            Assert.Equal(-1, result);

        }

        [Fact]
        static void SubtractionTest2()
        {
            cal c = new cal();
            int[] input = { 1, 2, 3 };
            int result = c.Subtraction(input);
            Assert.Equal(-6, result);

        }
        [Fact]
        
        static void Multiplication()
        {
            cal c = new cal();

            int result = c.Multiplication(2,2);
            Assert.Equal(4, result);

        }
        [Fact]
        static void Multiplication2()
        {
            cal c = new cal();
            int[] input = { 1,2,3 };
            int result = c.Multiplication(input);
            Assert.Equal(6, result);

        }
        [Fact]
        static void Division()
        {
            cal c = new cal();
            double result = c.Division(3, 0);
            Assert.Equal(0, result);

        }
    }
}