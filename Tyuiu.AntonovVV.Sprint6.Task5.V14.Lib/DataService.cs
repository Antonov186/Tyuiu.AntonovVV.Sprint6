﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AntonovVV.Sprint6.Task5.V14.Lib
{
    public class DataService : ISprint6Task5V14
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numsArray = new double[len];

            int index = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            numsArray = numsArray.Where(val => val > 9).ToArray();

            return numsArray;
        }
    }
}