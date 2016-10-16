﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests.Sorting.QuickSort
{
    [TestClass]
    public class QuickSortTests
    {
        [TestMethod]
        public void QuickSortTestOne()
        {
            int[] expected = Algorithm.Sorting.QuickSort.QuickSort.Main(new[] { 1, 5, 2, 7, 8, 4 });
            int[] actual = { 1, 2, 4, 5, 7, 8 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuickSortTestTwo()
        {
            int[] expected = Algorithm.Sorting.QuickSort.QuickSort.Main(new[] { 100, 7, 290, 07, 18, 74 });
            int[] actual = { 7, 07, 18, 74, 100, 290 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuickSortTestThree()
        {
            int[] expected = Algorithm.Sorting.QuickSort.QuickSort.Main(new[] { -1, 52, -8964, 547, -191, 0, 85976 });
            int[] actual = { -8964, -191, -1, 0, 52, 547, 85976 };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}