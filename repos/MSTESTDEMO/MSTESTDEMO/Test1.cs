using MyClassLib;
namespace MSTESTDEMO
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange - Act - Assert 

            //5 + 6 = 11

            //Arrange : storing all variables objects which is required for unit testing 
            int a = 5;
            int b = 6;
            int c = a + b; //Act (keep the result ready) 

            //Assert - it takes all 2 parameters one is actual and another is excepted
            Assert.AreEqual(11,c);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //some logic will be tested here

            MyClass ob = new MyClass(); //arrange

            int c = ob.AddNums(10, 20); //act

            Assert.AreEqual(30,c);
        }

        [TestMethod]
        public void Greatest_twonums_returnsgreat()
        {
            //test greatest of two numbers

            MyClass ob = new MyClass();

            int c = ob.Greatest(10, 100);

            Assert.AreEqual(100, c);
        }

        //what kind of testing does mphasis follows? 
        //tdd Approach --> (test driven development)
        [TestMethod]
        public void Multiplication_twonums_returnsresult()
        {
            //5 * 10 

            MyClass ob = new MyClass();

            int c = ob.Multiply(10, 100);
            Assert.AreEqual(1000, c);
        }

        [TestMethod]
        [DataRow(new int[] {10,-20,30},10)]
        [DataRow(new int[] { -10, -20, -30 }, -60)]
        [DataRow(new int[] { 10, -20, 0 }, -10)]
        public void Array_Sumofarrays_returnsarray(int[]a,int b)
        {
            MyClass ob = new MyClass();
            int[] arr = { 1, 2, 3 };
            int c = ob.Arraysum(arr);
            Assert.AreEqual(6, c);
        }

        [TestMethod]
        [DataRow(10,20,30)]
        [DataRow(-1,-2,-4)]
        [DataRow(0,-1,-1)]
        //same method different test cases
        public void TestMethod3(int a,int b,int d)
        {
            //some logic will be tested here

            MyClass ob = new MyClass(); //arrange
            int c = ob.AddNums(10, 20); //act
            Assert.AreEqual(30, c);
        }
    }
}
