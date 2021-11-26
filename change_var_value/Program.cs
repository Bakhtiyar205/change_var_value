using System;

namespace change_var_value
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 11;
            num1 = num1 * num2;
            num2 = num1 / num2;
            num1 = num1 / num2;
            Console.WriteLine(num1+" "+num2);
        }
    }
}
