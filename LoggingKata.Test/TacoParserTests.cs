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
            var lines = File.ReadAllLines(csvPath);
            var parser = new TacoParser();
            var locations = lines.Select(parser.Parse).ToArray();

            GeoCoordinate geo1 = new GeoCoordinate();
            double longitude;
            foreach (var locA in locations) {
                longitude = locA.Location.Longitude;
            }

            geo1.Longitude = expected;
            //Act
            var actual = longitude;
            //Assert
            Assert.Equal(actual, expected);
        }


        //TODO: Create a test ShouldParseLatitude

    }
}
