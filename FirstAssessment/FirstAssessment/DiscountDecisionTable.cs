using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssessment
{
    class DiscountDecisionTable
    {
        public void DiscountDecision()
        {
            Console.WriteLine("Insert a Quantity");
            int quantity = Convert.ToInt16(Console.ReadLine());
            double result = DiscountToApply(quantity);

            Console.WriteLine("the discount is: {0}", result);
            Console.ReadLine();
        }

        static double DiscountToApply(int quantity)
        {
            double discount = 0.0;
            if (quantity < 10)
            {
                discount = .05 * quantity;
            }
            else if (quantity < 50)
            {
                Console.WriteLine("the available discounts are 5% and 10% please choose one typing 1- 5%, 2- 10%");
                int availableDiscounts = Convert.ToInt16(Console.ReadLine());
                switch (availableDiscounts)
                {
                    case 1:
                        discount = quantity * .05;
                        break;
                    case 2:
                        discount = quantity * .10;
                        break;
                    default:
                        Console.WriteLine("Discount not available");
                        break;
                }
            }
            else
            {
                Console.WriteLine("please choose one typing 1- 5%, 2- 10%, 3- 15%");
                int availableDiscounts = Convert.ToInt16(Console.ReadLine());
                switch (availableDiscounts)
                {
                    case 1:
                        discount = quantity * .05;
                        break;
                    case 2:
                        discount = quantity * .10;
                        break;
                    case 3:
                        discount = quantity * .15;
                        break;
                    default:
                        Console.WriteLine("Discount not available");
                        break;
                }
            }

            return discount;
        }

    }
}
