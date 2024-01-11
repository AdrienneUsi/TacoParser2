using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        //Add additional inline data. Refer to your CSV file.
        [InlineData("30.39371, -87.68332, Taco Bell Fole...", -87.68332)]
        [InlineData("30.157708,-85.591198,Taco Bell Panama Cit...", -85.591198)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
             var tacoParserInstance = new TacoParser();
         
            //Act
            var actual = tacoParserInstance.Parse(line).Location.Longitude;
         
            //Assert
            Assert.Equal(expected,actual);
        }


        //TODO: Create a test called ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("30.39371, -87.68332, Taco Bell Fole...", 30.39371)]
        [InlineData("30.157708,-85.591198,Taco Bell Panama Cit...", 30.157708)]

        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange

            var tacoParseInstant = new TacoParser();

            //Act
            var actual = tacoParseInstant.Parse(line).Location.Latitude;

            //Aseert

            Assert.Equal(expected, actual);
        }

    }
}
