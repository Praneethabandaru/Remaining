using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib;

namespace MSTESTDEMO
{
    [TestClass]
    public class UnitTest2
    {

        [ClassInitialize]
        //every method has to be void public no return type
        public static void c1(TestContext t)
        {
            Console.WriteLine("class initialize  called");

        }

        [ClassCleanup]
        public static void c2()
        {
            Console.WriteLine("Class Cleanup called");
        }

        [TestInitialize]
        public void t1()
        {
            Console.WriteLine("Test Initialize called");
        }
        [TestCleanup]
        public void t2()
        {
            Console.WriteLine("Test cleanup called");
        }
        [TestMethod]
        public void m1()
        {
            Console.WriteLine("method 1 called");
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void m2()
        {
            Console.WriteLine("method 2 called");
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [DataRow(10,20,30)]
        [DataRow(-1, -2, -3)]
        public void TestMethod2(int a,int b,int c)
        {
            MyClass ob = new MyClass();
            int result = ob.AddNums(a, b);
            Assert.AreEqual(c, result);
            
        }
    }
}
