
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
            Console.Write("Laptop Import ID: " + ID);
            Console.Write("Laptop Import Quantity: " + Quantity);
            Console.Write("Laptop Import Date: " + DateImport);
        }

        public override void Note()
        {
            Console.WriteLine("{1} Laptop is imported on {2}.", Quantity, DateImport);
        }
    }
}
