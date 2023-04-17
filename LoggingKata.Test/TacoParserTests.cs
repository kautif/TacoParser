using GeoCoordinatePortable;
using System;
using System.IO;
using System.Linq;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        const string csvPath = "TacoBell-US-AL.csv";

        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
//            var lines = File.ReadAllLines(csvPath);
            var parser = new TacoParser();
            var location = parser.Parse(line);

            double actual = location.Location.Longitude;
            //Act

            //Assert
            Assert.Equal(actual, expected);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            //            var lines = File.ReadAllLines(csvPath);
            var parser = new TacoParser();
            var location = parser.Parse(line);

            double actual = location.Location.Latitude;
            //Act

            //Assert
            Assert.Equal(actual, expected);
        }
    }
}
