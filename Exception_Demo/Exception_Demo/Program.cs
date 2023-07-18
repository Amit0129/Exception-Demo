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
                Console.WriteLine("0.Exit");
                Console.WriteLine("Please choose an above Option\n");
                int option = Convert.ToInt32(Console.ReadLine());
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
                    default:
                        Console.WriteLine("Please choose an Above Option");
                        break;
                }
            }
            
            
        }
    }
}