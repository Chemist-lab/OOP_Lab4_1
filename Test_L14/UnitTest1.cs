using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_L14
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int R = 90;
            int result = W1.Program.StudentRating(R);
            Assert.AreEqual(3, result);
        }
    }
}
