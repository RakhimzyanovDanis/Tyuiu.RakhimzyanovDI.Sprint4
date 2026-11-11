using Tyuiu.RakhimzyanovDI.Sprint4.Task0.V25.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint4.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
            int expectedResult = 42;
            Assert.AreEqual(expectedResult, ds.GetSumEvenArrEl(numsArray));
        }
    }
}
