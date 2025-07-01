
using Microsoft.AspNetCore.Mvc;
using MVCTesting.Controllers;
using MySqlX.XDevAPI.Common;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            HiController c = new HiController();

            //act
            var result = c.Index();

            //assert
            Assert.IsType<ViewResult>(result);

        }
        [Fact]
        public void Test2()
        {
            //arrange
            HiController c = new HiController();

            //act
            var result = c.About();

            //assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Test3()
        {
            //arrange
            HiController c = new HiController();

            //act
            var result = c.First();

            //assert
            var viewRes = Assert.IsType<ViewResult>(result);
            Assert.IsType<string[]>(viewRes.Model);

        }
        [Fact]
        public void Test4()
        {
            HiController c = new HiController();

            //act
            var result = c.Second();

            var redirectResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index",redirectResult.ActionName);
            
        }

    }
}