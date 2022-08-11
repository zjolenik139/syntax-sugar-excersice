using System;

namespace syntax_and_syntax_sugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int answer = 4; // explicit typing
            //string response; // explicit typing

            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + " is greater than or equal to nine";
            //}
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";

            Console.WriteLine(response);
        }
    }
}
