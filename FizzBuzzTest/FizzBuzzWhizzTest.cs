using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzWhizzTest
    {
        [Fact]
        public void Should_return_normal_num_when_input_normal_num()
        {
            // given
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 1;
            // when
            string res = fizzBuzzWhizz.FizzBuzzGame(num);

            // then
            Assert.Equal(num.ToString(), res);
        }

        [Fact]
        public void Should_return_Fizz_when_input_num_multiple_of_three()
        {
            // given
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 3;
            // when
            string res = fizzBuzzWhizz.FizzBuzzGame(num);

            // then
            Assert.Equal("Fizz", res);
        }

        [Fact]
        public void Should_return_Buzz_when_input_num_multiple_of_five()
        {
            // given
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 5;
            // when
            string res = fizzBuzzWhizz.FizzBuzzGame(num);

            // then
            Assert.Equal("Buzz", res);
        }

        [Fact]
        public void Should_return_Whizz_when_input_num_multiple_of_seven()
        {
            // given
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 7;
            // when
            string res = fizzBuzzWhizz.FizzBuzzGame(num);

            // then
            Assert.Equal("Whizz", res);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_input_num_multiple_of_three_and_five()
        {
            // given
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 15;
            // when
            string res = fizzBuzzWhizz.FizzBuzzGame(num);

            // then
            Assert.Equal("FizzBuzz", res);
        }

        [Fact]
        public void Should_return_FizzWhizz_when_input_num_multiple_of_three_and_seven()
        {
            // given
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 21;
            // when
            string res = fizzBuzzWhizz.FizzBuzzGame(num);

            // then
            Assert.Equal("FizzWhizz", res);
        }

        [Fact]
        public void Should_return_BuzzWhizz_when_input_num_multiple_of_five_and_seven()
        {
            // given
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 70;
            // when
            string res = fizzBuzzWhizz.FizzBuzzGame(num);

            // then
            Assert.Equal("BuzzWhizz", res);
        }

        [Fact]
        public void Should_return_FizzBuzzWhizz_when_input_num_multiple_of_three_special_num()
        {
            // given
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 105;
            // when
            string res = fizzBuzzWhizz.FizzBuzzGame(num);

            // then
            Assert.Equal("FizzBuzzWhizz", res);
        }

        [Fact]
        public void Should_return_Fizz_when_input_num_contains_three()
        {
            // given
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 13;
            // when
            string res = fizzBuzzWhizz.FizzBuzzGame(num);

            // then
            Assert.Equal("Fizz", res);
        }
    }
}