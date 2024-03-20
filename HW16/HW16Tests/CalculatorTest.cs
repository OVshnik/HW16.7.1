using HW16;

namespace HW16Tests
{
    public class Tests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.True(calc.Additional(45,23)==68);
        }
        [Test]
        public void SubtructionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.True(calc.Subtraction(50, 23) == 27);
        }
        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.True(calc.Multiplication(25, 5) == 125);
        }
        [Test]
        public void DivisionMustNotDivideByZero()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Division(4, 0));
        }
    }
}