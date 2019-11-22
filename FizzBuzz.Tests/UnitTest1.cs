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
        public void Returns_Number()
        {
            Assert.That(program.FizzBuzz(1), Is.EqualTo("1"));
        }

        [Test]
        public void Fizz_For_Multiple_Of_3()
        {
            Assert.Multiple(() =>
            {
                Assert.That(program.FizzBuzz(3), Is.EqualTo("Fizz"));
                Assert.That(program.FizzBuzz(6), Is.EqualTo("Fizz"));
            });
        }

        [Test]
        public void Buzz_For_Multiple_Of_5()
        {
            Assert.Multiple(() =>
            {
                Assert.That(program.FizzBuzz(5), Is.EqualTo("Buzz"));
                Assert.That(program.FizzBuzz(10), Is.EqualTo("Buzz"));
            });
        }

        [Test]
        public void FizzBuzz_For_Multiples_Of_Both()
        {
            Assert.Multiple(() =>
            {
                Assert.That(program.FizzBuzz(15), Is.EqualTo("FizzBuzz"));
                Assert.That(program.FizzBuzz(30), Is.EqualTo("FizzBuzz"));
            });
        }
    }
}