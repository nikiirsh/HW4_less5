namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter a to compare: ");
            int a, b, c, d;
            str = Console.ReadLine();
            a = int.Parse(str);

            Console.WriteLine("Input b: ");
            str = Console.ReadLine();
            b = int.Parse(str);

            Console.WriteLine($"Maximum value is {MaxValue(a, b)}");
            Console.WriteLine($"Minimum value is {MinValue(a, b)}");
            Console.WriteLine($"Sum of a and b is odd: {TrySumIfOdd(a, b, out int sum)}");

            static int MaxValue(int a, int b)
            {
                if (a == b)
                {
                    return a;
                }
                else if (b > a)
                {
                    return b;
                }
                else
                {
                    return a;
                }
            }

            static int MinValue(int a, int b)
            {
                if (a == b)
                {
                    return a;
                }
                else if (b > a)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }

            static bool TrySumIfOdd(int a, int b, out int sum)
            {
                sum = a + b;
                if (sum % 2 != 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"SUM of numbers is: {sum}");
                }
                return false;
            }

            Console.WriteLine("Input the string: ");
            str = Console.ReadLine();
            
            Console.WriteLine("Input the string: ");
            string str1 = Console.ReadLine();
            int num = int.Parse(str1);
            Repeat(str, num);

            static void Repeat(string str, int num)
            {
                for (int i = 0; i < num; i++) 
                {
                    Console.Write($"{str}");
                }
            }

            //static void MaxValue(int a, int b, int c) { }
            //static void MaxValue(int a, int b, int c, int d) { }
            //static void MinValue(int a, int b, int c) { }
            //static void MinValue(int a, int b, int c, int d) { }

            // выдает ошибку что переменная Max/MinValue уже определена, и просто не кмпилируется код

        }
    }
}