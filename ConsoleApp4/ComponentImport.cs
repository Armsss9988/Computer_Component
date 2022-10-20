namespace ConsoleApp4
{
    internal class ComponentImport : ProductImport
    {
        public ComponentImport(int id, DateTime dateImport, int quantity) : base(id, dateImport, quantity)
        {
        }
        public ComponentImport() { }

        public override void Note()
        {
            Console.WriteLine("{1} component {2} is imported on {2}.", Quantity, DateImport);
        }
        public override void CreateInformation()
        {
            Console.Write("Type Component Import ID: ");
            ID = int.Parse(Console.ReadLine());
            Console.Write("Type Date Import: ");
            string importDate = Console.ReadLine();
            DateImport = DateTime.ParseExact(importDate, format, provider);
            Console.Write("Type Quantity: ");
            Quantity = int.Parse(Console.ReadLine());
        }
        public override void DisplayInformation()
        {
            Console.Write("Component Import ID: " + ID);
            Console.Write("Component Import Quantity: " + Quantity);
            Console.Write("Component Import Date: " + DateImport);
        }
    }
}
