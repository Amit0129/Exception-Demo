using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    public class Null_Exception
    {
        public void NullRefException()
        {
            //try
            //{
            //    string str = null;
            //    Console.WriteLine(str.Substring(5));
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            string str = null;
            if (str != null)
            {
                Console.WriteLine(str.Substring(5));
            }
            else
            {
                Console.WriteLine("String is null");
            }
        }
       
    }
}
