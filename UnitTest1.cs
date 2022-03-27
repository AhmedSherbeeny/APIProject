using Microsoft.VisualStudio.TestTools.UnitTesting;
using SherbeenyLibrary;

namespace TestSherbeenyLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAverrage()
        {
            //Arrange

            Math math1 = new Math();
            var nums = new int[] { 10, 33, 50, 2, 100 };

            //Act

            var result = math1.Average(nums);

            //Assert

            Assert.IsTrue(result == 39);

        }

        [TestMethod]
        public void TestLargest()
        {
            //Arrange

            Math math1 = new Math();
            var nums = new int[] { 10, 33, 50, 2, 100 };

            //Act

            var result = math1.Largest(nums);

            //Assert

            Assert.IsTrue(result == 100);

        }

        [TestMethod]
        public void TestSmallest()
        {
            //Arrange

            Math math1 = new Math();
            var nums = new int[] { 10, 33, 50, 2, 100 };

            //Act

            var result = math1.Smallest(nums);

            //Assert

            Assert.IsTrue(result == 2);

        }
    }
}
