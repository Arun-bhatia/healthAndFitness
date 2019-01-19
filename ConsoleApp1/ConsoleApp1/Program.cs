using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight, height;
            weight = Convert.ToInt32(Console.ReadLine());
            height = Convert.ToInt32(Console.ReadLine());
            
            int BMI = 0;
            BMI = weight / (height * height);
            Console.WriteLine("Your BMI is " + BMI);
        }
    }
}
