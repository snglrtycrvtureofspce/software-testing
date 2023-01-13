using Test;

namespace TestFunc // MS Test (Unit Test Framework) 
{
    [TestClass]
    public class MatrixTest
    {
        public double[,] MatrixDoubles { get; set; } // матрица
        [TestInitialize]
        public void SetUp()
        {
            MatrixDoubles = new double[4, 4]
            {
                {3,6,1,8 },
                {8,0,5,2 },
                {9,3,6,5 },
                {2,3,7,1 },
            };
        }
        [TestMethod]
        public void Sum()
        {
            Matrix test = new Matrix();
            double expected = 69;
            double sum = test.Sum(MatrixDoubles);
            Assert.AreEqual(expected, sum);
        }
        [TestMethod]
        public void Max()
        {
            Matrix test = new Matrix();
            double expected = 9;
            double sum = test.Max(MatrixDoubles);
            Assert.AreEqual(expected, sum);
        }
        [TestMethod]
        public void EvenNum()
        {
            Matrix test = new Matrix();
            double expected = 1;
            double sum = test.EvenNum(MatrixDoubles);
            Assert.AreEqual(expected, sum);
        }
        [TestMethod]
        public void Square()
        {
            Matrix test = new Matrix();
            /*bool expected = true;*/
            bool rez = test.Square(MatrixDoubles);
            Assert.IsTrue(rez);
        }
    }
}