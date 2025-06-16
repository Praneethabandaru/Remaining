namespace MyClassLib
{
    public class MyClass
    {
        //program to add two numbers
        //program to check the greatest of 2 numbers

        public int AddNums(int num1,int num2)
        {
            return num1+num2;
        }

        public int Greatest(int num1,int num2)
        {
            if(num1 > num2) 
                return num1;
            else return num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Arraysum(int[] arr)
        {
            int sum = 0;
            foreach (var i in arr)
            {
                sum += i;
            }
            return sum;
        }

        public int Divide(int v1, int v2)
        {
            try
            {
                return v1 / v2;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            var reversed = new string(input.Reverse().ToArray());
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        public bool IsWeekend(DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek ==
            DayOfWeek.Sunday;
        }

        public bool IsEven(int number) => number % 2 == 0;

        public void CheckAge(int age)
        {
            if (age < 18)
                throw new ArgumentException("Age must be 18 or older");
        }

    }
}
