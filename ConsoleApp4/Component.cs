namespace ConsoleApp4
{
    internal class Component : Product
    {
        public string Type;
        public string Parameter;
        public List<ComponentImport> ComponentImportList = new();

        public Component(int id, string name, string manufacturerName, decimal price)
            : base(id, name, manufacturerName, price)
        {
        }
        //componentCRUD
        public Component() { }
        public override void CreateInformation()
        {
            base.CreateInformation();
            Console.Write("Type Component Type: ");
            Type = Console.ReadLine();
            Console.Write("Type Component Parameter: ");
            Parameter = Console.ReadLine();
        }
        public override void UpdateInformation()
        {
            base.UpdateInformation();
            string type = Console.ReadLine();
            if (type != null && type.Length > 0)
            {
                Type = type;
            }
            string parameter = Console.ReadLine();
            if (parameter != null && parameter.Length > 0)
            {
                Parameter = parameter;
            }
        }
        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Parameter: " + Parameter);
        }


    }
}

