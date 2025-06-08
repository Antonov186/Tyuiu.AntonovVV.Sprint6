using Tyuiu.AntonovVV.Sprint6.Task7.V18.Lib;
namespace Tyuiu.AntonovVV.Sprint6.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\Task7\InPutFileTask7V18.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}