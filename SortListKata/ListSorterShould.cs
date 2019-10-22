using System.Collections.Generic;
using Xunit;

namespace SortListKata
{
    public class ListSorterShould
    {
        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[] { new List<int>(), new List<int>() },
                new object[] { new List<int> {1}, new List<int> {1} },
                new object[] { new List<int> {1, 2}, new List<int> {1, 2} },
                new object[] { new List<int> {2, 1}, new List<int> {1, 2} },
                new object[] { new List<int> {1, 2, 3}, new List<int> {1, 2, 3} },
                new object[] { new List<int> {2, 1, 3}, new List<int> {1, 2, 3} },
                new object[] { new List<int> {1, 3, 2}, new List<int> {1, 2, 3} },
                new object[] { new List<int> {3, 2, 1}, new List<int> {1, 2, 3} },
                new object[] { new List<int> {1, 3, 5, 9, 8, 3, 2, 1}, new List<int> {1, 1 , 2, 3, 3, 5, 8, 9} },
            };

        public static IEnumerable<object[]> TestData2 =>
        new List<object[]>
        {
                new object[] { new List<int>(), new List<int>() },
                new object[] { new List<int> {1}, new List<int> {1} },
                new object[] { new List<int> {1, 2}, new List<int> {1, 2} },
                new object[] { new List<int> {2, 1}, new List<int> {1, 2} },
                new object[] { new List<int> {1, 2, 3}, new List<int> {1, 2, 3} },
                new object[] { new List<int> {2, 1, 3}, new List<int> {1, 2, 3} },
                new object[] { new List<int> {1, 3, 2}, new List<int> {1, 2, 3} },
                new object[] { new List<int> {3, 2, 1}, new List<int> {1, 2, 3} },
                new object[] { new List<int> {1, 3, 5, 9, 8, 3, 2, 1}, new List<int> {1, 1 , 2, 3, 3, 5, 8, 9} },
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void SortTheListAscending(List<int> input, List<int> expectedOutput)
        {
            Assert.Equal(expectedOutput, ListSorter.BubbleSort(input));
        }

        [Theory]
        [MemberData(nameof(TestData2))]
        public void SortTheListAscendingButBetter(List<int> input, List<int> expectedOutput)
        {
            Assert.Equal(expectedOutput, ListSorter.QuickSort(input));
        }
    }
}
