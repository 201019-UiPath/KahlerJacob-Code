using System;
using Xunit;
using HerosLib;

namespace HerosTest
{
    public class HeroTest
    {
        Hero testHero = new Hero();
        [Theory]
        [InlineData("Power of Unix")]
        [InlineData("Flight")]
        [InlineData("Laser Eyes")]
        public void AddSuperPowerShouldAddSuperpower(string superPower)
        {
                // Arrange - Arranging artifacts I might need to test
                
                

                //Act - Doing the things
                testHero.AddSuperPower(superPower);

                //Assert
                Assert.Equal(superPower, Hero.superPowers.Peek());

        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]

        public void AddSuperPowerShouldThrowArgumentException(string superPower){

            Assert.Throws<ArgumentException>(() => testHero.AddSuperPower(superPower));
        }
    }
}
