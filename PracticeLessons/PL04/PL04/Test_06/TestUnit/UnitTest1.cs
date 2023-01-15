using Test;

namespace TestUnit // NUnit
{
    public class Tests
    {
        public double[,] MatrixDoubles { get; set; } // матрица
        [SetUp]
        public void Setup()
        {
            MatrixDoubles = new double[4, 4]
           {
                {3,6,1,8 },
                {8,0,51,2 },
                {9,39,6,5 },
                {2,3,7,20 },
           };
        }

        [Test]
        public void Sum()
        {
            Matrix test = new Matrix();
            double expected = 88;
            double sum = test.Sum(MatrixDoubles);
            Assert.AreEqual(expected, sum);
        }
        [Test]
        public void Max()
        {
            Matrix test = new Matrix();
            double expected = 20;
            double sum = test.Max(MatrixDoubles);
            Assert.AreEqual(expected, sum);
        }
        [Test]
        public void EvenNum()
        {
            Matrix test = new Matrix();
            double expected = 2;
            double sum = test.EvenNum(MatrixDoubles);
            Assert.AreEqual(expected, sum);
        }
        [Test]
        public void Square()
        {
            Matrix test = new Matrix();
            /*bool expected = true;*/
            bool rez = test.Square(MatrixDoubles);
            Assert.IsTrue(rez);
        }
    }
}