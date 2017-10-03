using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssessment
{
    class HandlingExeptionEjercice
    {
        public double Divide(int x, int y)
        {
            double result = 0.0;
            try
            {
                result = x / y;
                
            }
            catch (InvalidCastException ie)
            {

                Console.WriteLine("Not Valid operation: {0} ",ie.ToString());
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("Not Valid operation dividing by zero: {0} ", de.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine("Not Valid operation: {0} ", e.ToString());
            }

            return result;
        }
    }
}
