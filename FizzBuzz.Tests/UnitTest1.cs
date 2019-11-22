using NUnit.Framework;
using cSharpFizzBuzz;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        Program program;

        [SetUp] 
        public void Init()
        {
            program = new Program();
        }

        [Test]
        public void FizzBuzz_Returns_Number()
        {
            Assert.AreEqual(1, program.FizzBuzz(1));
        }

        [Test]
        public void FizzBuzz_Returns_Fizz_For_3()
        {
            Assert.AreEqual("Fizz", program.FizzBuzz(3));
        }

        [Test]
        public void FizzBuzz_Returns_Fizz_For_6()
        {
            Assert.That(program.FizzBuzz(6), Is.EqualTo("Fizz"));
        }
    }
}