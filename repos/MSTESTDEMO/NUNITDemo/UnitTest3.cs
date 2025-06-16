using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace NUNITDemo
{
    [TestFixture]
    public  class UnitTest3
    {
        [Test]
        public void Demo1()
        {
            
            //MyServiceCls real = new MyServiceCls();

            Stubcls fake = new Stubcls();

            //MyClient m = new MyClient(real);
            MyClient m = new MyClient(fake);

            string res = m.AddClient(10, 20);
            //Assert.AreEqual("The Sum is 30",res);
            Assert.That("the sum is 30", Is.EqualTo(res));
        }
        [Test]
        public void Demo2()
        {
            FakeClass fake = new FakeClass();
            MyClient m = new MyClient(fake);
            string res = m.AddClient(10, 20);
            Assert.That("the sum is 30", Is.EqualTo(res));
        }
        [Test]
        public void Demo3()
        {
            var fakemoq = new Mock<IMath>(); //creates object without behaviour
            fakemoq.Setup(c => c.Add(10, 20)).Returns("the sum is 30"); //stub 

            MyClient m = new MyClient(fakemoq.Object);
            string res = m.AddClient(10, 20); 
            Assert.That("the sum is 30", Is.EqualTo(res)); 
        }
        //fakemoq "object without behaviour" 
        //fakemoq.Object "object with behaviour defined"(contains logic)
        
        [Test]
        public void Demo7()
        {
            var fakemoq = new Mock<IMath>();
            fakemoq.Setup(x => x.Add(It.Is<int>(i => i >5), It.IsAny<int>())).Returns("the sum is 30");
            MyClient m = new MyClient(fakemoq.Object);
            string res = m.AddClient(10, 20);
            Assert.That("the sum is 30", Is.EqualTo(res));
            fakemoq.Verify(c => c.Add(10, 20), Times.Once);
        }

        [Test]
        public void Demo8()
        {
            var fakemoq = new Mock<IMath>();
            fakemoq.Setup(x => x.Add(It.IsAny<int>(), It.IsAny<int>())).Callback<int, int>((a, b)
                => Console.WriteLine($"Method executed successfully {a} {b}")).Returns("the sum is 30");
            MyClient m = new MyClient(fakemoq.Object);
            string res = m.AddClient(10, 20);
            Assert.That("the sum is 30", Is.EqualTo(res));
            fakemoq.Verify(c => c.Add(10, 20), Times.Once);
        }

        [Test]
        public void Demo9() 
        {
            var fakemoq = new Mock<IMath>();
            fakemoq.Setup(x => x.Add(-1,-1)).Throws<ArgumentException>();
            MyClient m = new MyClient(fakemoq.Object);
            string res = m.AddClient(10, 20);
            //Assert.That("the sum is 30", Is.EqualTo(res));
            var ex=Assert.Throws<System.ArgumentException>(()=> m.AddClient(10, 20));
            Assert.That(ex.Message,Is.EqualTo("Invalid input for addition"));
        }
        [Test]
        public void Demo10()
        {
            var fakemoq = new Mock<IMath>();

            fakemoq.SetupProperty(c => c.Data, 10);

            fakemoq.SetupGet(c => c.Data).Returns(10);

            MyClient m = new MyClient(fakemoq.Object);

            Assert.That(10, Is.EqualTo(fakemoq.Object.Data));

        }
        [Test]
        public void demo11()
        {
            var fakemoq = new Mock<IMath>();

            fakemoq.Setup (x => x.Add(-1, -1)).Throws<ArgumentException>();
            MyClient m = new MyClient(fakemoq.Object);
        }
        


    }
}
