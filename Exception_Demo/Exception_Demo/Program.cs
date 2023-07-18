namespace Exception_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
           

            bool check = true;
            while (check)
            {
                Console.WriteLine("1.Eception handle");
                Console.WriteLine("2.Divied By Zero Inbuild Eception");
                Console.WriteLine("3.null Reference Inbuild Eception");
                Console.WriteLine("4.Arrgument out of range Inbuild Eception");
                Console.WriteLine("0.Exit\n");
                Console.WriteLine("Please choose an above Option\n");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 0:
                        check = false;
                        break;
                    case 1:
                        ExceptionHandle exception = new ExceptionHandle();
                        exception.Display();
                        break;
                    case 2:
                        Devied_By_Zero_Exception devied_By_Zero = new Devied_By_Zero_Exception();
                        devied_By_Zero.Costom();
                        break;
                    case 3:
                        Null_Exception null_Exception = new Null_Exception();
                        null_Exception.NullRefException();
                        break;
                    case 4:
                        ArrgumentoutOfRange_Exception range_Exception = new ArrgumentoutOfRange_Exception();
                        range_Exception.Exception();
                        break;
                    default:
                        Console.WriteLine("Please choose an Above Option");
                        break;
                }
            }
            
            
        }
    }
}