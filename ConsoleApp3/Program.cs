namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
           
            Console.WriteLine("what is the number 1");
            double x= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("what is the number 2");
            double  y= Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine($"sum is: {x+y}");
            Console.WriteLine($"sub is: {x - y}");
            Console.WriteLine($"mult is: {x * y}");
            double div = x / y;
            Console.WriteLine($"div is: {div}");
            #endregion

            //#region task2
            //Console.WriteLine("what is frist name");
            //string fristname=Console.ReadLine();
            //Console.WriteLine("what is list name");
            //string listname = Console.ReadLine();
            //string fullName=fristname+listname;
            //int fullNameLength = fullName.Length;
            //Console.WriteLine(fullNameLength);
            //Console.WriteLine($"The length of your full name is: {fullNameLength}");
            //Console.WriteLine($"the full name is: {fristname} {listname}");
            //#endregion
        }
    }
}
