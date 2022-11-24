using System;
namespace CALCULATOR.Classes
{
    class Tables
    {
        public int X { get; set; }
        public  void Table()
        {
            X=Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i <= X; i++)
            {
            for (int n = 0; n < 11; n++)
            {
                System.Console.WriteLine($"{i} x {n} = {i * n}");
            }
            }
        }
    }
}