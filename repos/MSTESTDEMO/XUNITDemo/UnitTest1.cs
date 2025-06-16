using System.Collections;
using System.Diagnostics;
using System.Reflection;
using MyClassLib;
using Xunit.Abstractions;

namespace XUNITDemo
{
    public class MyclassLeveldata :IDisposable
    {
        public MyclassLeveldata()
        {
            File.AppendAllText("C:\\Xunit\\xunitclass.txt", " Class Level data Initialized" );
        }
        public void Dispose()
        {
            File.AppendAllText("C:\\Xunit\\xunitclass.txt", " Class Level data Disposed");
        }
    }

    //a logic which need to be executed before all the methods 
    //a logic which need to be executed after calling the methods


    public class UnitTest1 :IClassFixture<MyclassLeveldata>
    {
        private readonly ITestOutputHelper _output;

        //this is have built-in support called DI(Dependency Injection) here reference comes dynamically
        public UnitTest1(ITestOutputHelper o)
        {
            _output = o;
        }

        [Fact]
        [Mycls]
        public void Test1()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void Test2()
        {
            MyClass ob = new MyClass();
            int c = ob.AddNums(10, 20);
            _output.WriteLine("hello world");
            Assert.Equal(30, c);
        }

        //[Fact] - Error
        [Theory]
        //[InlineData(10,20,30)]
        //[InlineData(11, 12, 30)]
        //[InlineData(20,40,60)] 
        [MemberData(nameof(MyData))]
        public void Test3(int a,int b,int c) 
        {
            MyClass ob = new MyClass();
            int res = ob.AddNums(a, b);
            Assert.Equal(c, res);
        }
        
        public static IEnumerable<object[]> TestData => new List<object[]>
        {
            new object[] {2,2,4},
            new object[] {3,3,6}
        };

        public static IEnumerable<object[]> MyData()
        {
            List<object[]> data = new List<object[]>(); // Corrected type to List<object[]>
            data.Add(new object[] { 10, 20, 30 });
            data.Add(new object[] { 11, 20, 31 }); // Corrected value to match expected result
            data.Add(new object[] { 12, 20, 32 });
            data.Add(new object[] { 13, 20, 33 });
            data.Add(new object[] { 14, 20, 34 });

            return data; // Ensure all code paths return a value
        }
    }

    public class Mycls : Xunit.Sdk.BeforeAfterTestAttribute ,IEnumerable<object[]>
    {
        public override void Before(MethodInfo methodUnderTest)
        {
            //logic to execute before calling method
            File.AppendAllText("C:\\Xunit\\xunit.txt", "Before Method i called :" +methodUnderTest.Name);
        }

        public override void After(MethodInfo methodUnderTest) 
        {
            //logic to execute after calling method 
            File.AppendAllText("C:\\Xunit\\xunit.txt", "After Method i called : " + methodUnderTest.Name);


        }

        public IEnumerator<object[]> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
