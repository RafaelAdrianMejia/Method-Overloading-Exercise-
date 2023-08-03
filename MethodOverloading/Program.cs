namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 30;
            int y = 50;

            var intAdd = Add(x, y);
            Console.WriteLine(intAdd);

            var decAdd = Add(100.50m, 200m);
            Console.WriteLine(decAdd);

            var boolAdd = Add(2, 2 , true);
            Console.WriteLine(boolAdd);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isChecked)
        {
            int sum = num1 + num2;

            if(isChecked && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isChecked && sum == 1)
            {
                return $"{sum} dollar";   
            }
            else if(isChecked && sum < 1)
            {
                return "You are broke";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
