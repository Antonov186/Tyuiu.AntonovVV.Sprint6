﻿using Tyuiu.AntonovVV.Sprint6.Task3.V1.Lib;
namespace Tyuiu.AntonovVV.Sprint6.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = { {-7, 34, -2, 25, 5},
                              {-16, -12, 30, -3, 17},
                              {3, -15, 12, 5, -5},
                              {17, 22, -3, 32, -11},
                              {9, 28, 1, -9, -2} };

            int[,] res = ds.Calculate(matrix);
            int[,] wait = { {-7, -15, -2, 25, 5},
                              {-16, -12, 30, -3, 17},
                              {3, 22, 12, 5, -5},
                              {17, 28, -3, 32, -11},
                              {9, 34, 1, -9, -2} };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
