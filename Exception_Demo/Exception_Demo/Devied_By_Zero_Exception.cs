using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    public class Devied_By_Zero_Exception
    {
        public void Costom()
        {
            try
            {
                int a = 0;
                int b = 100 / a;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
