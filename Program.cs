using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 6;
            int n2 = 3;
          Addition addition = new Addition();
            addition.Operate(n1,n2);

           Substraction substraction = new Substraction();
            substraction.Operate(n1,n2);

            Multiplication multiplication = new Multiplication();
            multiplication.Operate(n1,n2);

            Division division = new Division();
            division.Operate(n1,n2);

            Console.WriteLine($"addition: first number ={n1}, second number = {n2},result={addition.Operate(n1,n2)}");
            Console.WriteLine($"substraction: first number ={n1}, second number = {n2},result={substraction.Operate(n1, n2)}");
            Console.WriteLine($"multiplication: first number ={n1}, second number = {n2},result={multiplication.Operate(n1, n2)}");
            Console.WriteLine($"division: first number ={n1}, second number = {n2},result={division.Operate(n1, n2)}");
        }
       
    }
}
