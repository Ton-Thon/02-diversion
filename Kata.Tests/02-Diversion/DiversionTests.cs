using Kata._02_Diversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Tests._02_Diversion
{
    public class DiversionTests
    {
        public static IEnumerable<object[]> TestGenerateBinaryListFromNumberData()
        {
            yield return new object[] { 1, new List<string> { "0", "1" } };
            yield return new object[] { 2, new List<string> { "00", "01", "10", "11" } };
        }

        [Theory]
        [MemberData(nameof(TestGenerateBinaryListFromNumberData))]
        public void GenerateBinaryListFromNumberTest(int number, List<string> expected)
        {
            // Arrange
            var sut = new Diversion();

            // Act
            var act = sut.GenerateBinaryListFromNumber(number);

            // Assert
            act.Should().Equal(expected);
        }

    }
}
