namespace EmployeeWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //EmployeePayRoll.ComputeEmployeeWages("Dmart", 20, 2, 10);
           // EmployeePayRoll.ComputeEmployeeWages("Reliance", 10, 4, 20);
            EmployeePayRoll dMart = new EmployeePayRoll("Dmart", 20, 2, 10);
            EmployeePayRoll reliance = new EmployeePayRoll("Reliance", 10, 4, 20);

            dMart.ComputeEmployeeWages();
            Console.WriteLine(dMart.toString());
            reliance.ComputeEmployeeWages();
            Console.WriteLine(reliance.toString());


        }
    }
}