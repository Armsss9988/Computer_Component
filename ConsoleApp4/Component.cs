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

        //importCRUD
        private int IdentityComponentImportID()
        {
            int max = 0;
            foreach (ComponentImport bill in ComponentImportList)
            {
                if (bill.ID >= max)
                {
                    max = bill.ID + 1;
                }
            }
            return max;
        }
        public void AddImportInformation()
        {
            ComponentImport newComponentImport = new();
            newComponentImport.ID = IdentityComponentImportID();
            newComponentImport.CreateInformation();
            ComponentImportList.Add(newComponentImport);
        }
        public ComponentImport FindByID(int id)
        {

            ComponentImport result = null;
            foreach (ComponentImport bill in ComponentImportList)
            {
                if (bill.ID == id)
                {
                    result = bill;
                }
            }
            return result;
        }

        public void DeleteImportInformation()
        {
            Console.Write("Enter deleting ComponentImport's ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            ComponentImport componentImport = FindByID(ID);
            if (componentImport != null)
            {
                ComponentImportList.Remove(componentImport);
            }
        }
        public void DisplayImportInformation()
        {
            foreach (ComponentImport bill in ComponentImportList)
            {
                bill.Note();
                bill.DisplayInformation();
            }
        }
    }
}

