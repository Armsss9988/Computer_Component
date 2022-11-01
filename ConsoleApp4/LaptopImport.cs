
namespace ConsoleApp4
{
    internal class LaptopImport : ProductImport
    {

        public LaptopImport(int id, DateTime dateImport, int quantity) : base(id, dateImport, quantity)
        {
        }
        public LaptopImport() { }
        public override void CreateInformation()
        {
            Console.Write("Type Date Import: ");
            string importDate = Console.ReadLine();
            DateImport = DateTime.ParseExact(importDate, format, provider);
            Console.Write("Type Quantity: ");
            Quantity = int.Parse(Console.ReadLine());
        }
        public override void DisplayInformation()
        {
            Console.WriteLine("Laptop Import ID: " + ID);
            Console.WriteLine("Laptop Import Quantity: " + Quantity);
            Console.WriteLine("Laptop Import Date: " + DateImport.ToString());
        }

        public override void Note()
        {
            Console.WriteLine("{0} Laptop is imported on {1}.", Quantity, DateImport.ToString());
        }
    }
}
