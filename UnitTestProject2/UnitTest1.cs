using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] Data = new int [4] { 61, 0, 5, 0 };
            int result = ConsoleApp42.Program.test1(Data);
            Assert.AreEqual(3, result);

        }
    }
}
