using MVCTesting.Controller;

namespace MVCTesting.Controller;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        HiController c = new HiController();

        //Act
        var result = c.Index();

        //assert
        Asset.IsType<ViewResult>(result);
    }
}