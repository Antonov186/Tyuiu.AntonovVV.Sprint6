﻿using Tyuiu.AntonovVV.Sprint6.Task2.V23.Lib;
namespace Tyuiu.AntonovVV.Sprint6.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = (stopValue - startValue) + 1;
            double[] array;
            array = new double[len];
            array[0] = -15.40;
            array[1] = -13.31;
            array[2] = -11.36;
            array[3] = -8.00;
            array[4] = -2.62;
            array[5] = 1.83;
            array[6] = 4.49;
            array[7] = 6.78;
            array[8] = 10.58;
            array[9] = 17.38;
            array[10] = 23.76;
            double[] array2;
            array2 = new double[len];
            array2 = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(array, array2);
        }
    }
}