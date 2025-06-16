namespace CodeFirstApp
{
    public interface IMyinter
    {
        string AddNums(int num1, int num2);
    }
    public class MyMathService : IMyinter
    {
        public string AddNums(int num1, int num2)
        {
            return $"The sum of {num1} and {num2} is {num1 + num2}";
        }
    }
}
