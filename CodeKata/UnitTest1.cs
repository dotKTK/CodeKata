using System;
using Xunit;

namespace CodeKata
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0)]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void Given_Divisible_By_3_and_5_Then_FizzBuzz(int number)
        {
            //given - Arrangr
            
            //when - Act
            var resoult = FizzBuzz(number);
            //then - Assert
            Assert.Equal("FizzBuzz", resoult);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void Given_Divisible_By_3_Then_Fizz(int number)
        {
            //given - Arrangr

            //when - Act
            var resoult = FizzBuzz(number);
            //then - Assert
            Assert.Equal("Fizz", resoult);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        public void Given_Divisible_By_5_Then_Buzz(int number)
        {
            //given - Arrangr

            //when - Act
            var resoult = FizzBuzz(number);
            //then - Assert
            Assert.Equal("Buzz", resoult);
        }

        [Fact]
        public void Given_3_Then_Fizz()
        {
            //given - Arrangr
                int value = 3;
            //when - Act
                var resoult = FizzBuzz(value);
            //then - Assert
                Assert.Equal("Fizz", resoult);
        }

        [Fact]
        public void Given_5_Then_Buzz()
        {
            //given - Arrangr
            int value = 5;
            //when - Act
            var resoult = FizzBuzz(value);
            //then - Assert
            Assert.Equal("Buzz", resoult);
        }

        [Fact]
        public void Given_15_Then_FizzBuzz()
        {
            //given - Arrangr
            int value = 15;
            //when - Act
            var resoult = FizzBuzz(value);
            //then - Assert
            Assert.Equal("FizzBuzz", resoult);
        }

        [Fact]
        public void Given_2_Then_2()
        {
            //given - Arrangr
            int value = 2;
            //when - Act
            var resoult = FizzBuzz(value);
            //then - Assert
            Assert.Equal(2, resoult);
        }

        private object FizzBuzz(int value)
        {
           // return value == 3 ? "Fizz" : "Buzz"; 
            if (value % 15 == 0) return "FizzBuzz";
            else
            if (value % 3 == 0) return "Fizz";
            else
            if (value % 5 == 0) return "Buzz";
            else return value;
        }              
                
         
    }
}
