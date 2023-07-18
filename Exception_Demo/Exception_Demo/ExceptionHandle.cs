using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    //
    public class ExceptionHandle
    {
        public void Display()
        {
            try
            {
                //Code to try block goes here.
                //put a statement where we want raise exception.
                int[] ints = { 1, 2, 3 };
                for (int val = 0; val < ints.Length; val++)
                {
                    Console.WriteLine(ints[val]);
                }
                Console.WriteLine(ints[10]);
            }
            catch (Exception ex)//Some SpecificExceptiom
            {
                //Statement to handle the exception goes here.
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Statement to execute after try and possible catch block.
                //clean up code.
            }
        }
    }
}
