using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssessment
{
    class ConvertingFlowCharIntoCSharp
    {
        public void Factorial()
        {
            Console.WriteLine("Insert a number");
            int n = Convert.ToInt16(Console.ReadLine());
            int fact = 1;

            while (n > 1)
            {
                fact = fact * n;
                n = n - 1;
            }

            Console.WriteLine("Factorial = {0}", fact);
        
        }
    }
}
