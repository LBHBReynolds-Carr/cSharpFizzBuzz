using NUnit.Framework;
using cSharpFizzBuzz;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void FizzBuzz_Returns_Number()
        {
            Program program = new Program();
            Assert.AreEqual(1, program.FizzBuzz(1));
        }

        [Test]
        public void FizzBuzz_Returns_Fizz_For_3()
        {
            Program program = new Program();
            Assert.AreEqual("Fizz", program.FizzBuzz(3));

        }

        [Test]
        public void FizzBuzz_Returns_Fizz_For_6()
        {
            Program program = new Program();
            Assert.AreEqual("Fizz", program.FizzBuzz(6));

        }
    }
}