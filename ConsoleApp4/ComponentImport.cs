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
            Console.WriteLine("{0} component is imported on {1}.", Quantity, DateImport);
        }
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
            Console.WriteLine("Component Import ID: " + ID);
            Console.WriteLine("Component Import Quantity: " + Quantity);
            Console.WriteLine("Component Import Date: " + DateImport);
        }
    }
}
