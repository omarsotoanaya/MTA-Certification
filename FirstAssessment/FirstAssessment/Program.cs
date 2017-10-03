using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssessment
{
    class Program
    {
        static void Main(string[] args)
        {

            //DiscountDecisionTable discount = new DiscountDecisionTable();
            //discount.DiscountDecision();

            //ConvertingFlowCharIntoCSharp converting = new ConvertingFlowCharIntoCSharp();
            //converting.Factorial();

            Console.WriteLine("Insert number 1");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Insert number 2");
            int num2 = Convert.ToInt16(Console.ReadLine());
            HandlingExeptionEjercice hand = new HandlingExeptionEjercice();
            Console.WriteLine("The result is: {0} ", hand.Divide(num1, num2));


            Console.ReadLine();
        }

    }
}
