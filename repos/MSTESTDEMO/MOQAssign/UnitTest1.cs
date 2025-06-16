using Moq;

namespace MOQAssign
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            var mockcal = new Mock<ICalculator>();
            mockcal.Setup(x => x.Add(2,3)).Returns(5);

            int res = mockcal.Object.Add(2,3);

            Assert.That(5, Is.EqualTo(res));

            mockcal.Verify(x => x.Add(2,3),Times.Once);

        }
        [Test]
        public void Test3()  
        { 
            var mockCustomerRepo = new Mock<ICustomerRepository>();

            mockCustomerRepo.Setup(repo => repo.GetCustomerById(1)).Returns(new Customer { Name = "John" });

            var customerService = new CustomerService(mockCustomerRepo.Object);

            string customerName = customerService.GetCustomerName(1);

            Assert.That("John",Is.EqualTo(customerName));
        }


    }
}
