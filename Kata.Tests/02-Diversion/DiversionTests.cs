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
            yield return new object[] { 0, new List<string> { } };
            yield return new object[] { 1, new List<string> { "0", "1" } };
            yield return new object[] { 2, new List<string> { "00", "01", "10", "11" } };
            yield return new object[] { 3, new List<string> { "000", "001", "010", "011", "100", "101", "110", "111" } };
            yield return new object[] { 4, new List<string> { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" } };
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


        public static IEnumerable<object[]> TestGetDiversionData()
        {
            yield return new object[] {  };
        }
        [Theory]
        [MemberData(nameof(TestGetDiversionData))]
        public void GetDiversionTest(List<string> binaryList, int expected)
        {
            // Arrange
            var sut = new Diversion();

            // Act
            var act = sut.GetDiversion(binaryList);

            // Assert
            act.Should().Be(expected);
        }
    }
}
