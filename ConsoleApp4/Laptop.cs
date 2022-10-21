namespace ConsoleApp4
{
    internal class Laptop : Product
    {
        public string Category;
        public List<LaptopPart> LaptopPartList = new();
        public List<LaptopImport> LaptopImportList = new();

        public Laptop(int id, string name, string manufacterName, decimal price) : base(id, name, manufacterName, price)
        {
        }
        public Laptop() { }
        //lapcrud
        public override void CreateInformation()
        {
            base.CreateInformation();
            Console.Write("Type Category: ");
            Category = Console.ReadLine();
        }
        public override void UpdateInformation()
        {
            base.UpdateInformation();
            string category = Console.ReadLine();
            if (category != null && category.Length > 0)
            {
                Category = category;
            }
        }
        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine("Category: " + Category);
        }
        //importCRUD
        private int IdentityLaptopImportID()
        {
            int max = 0;
            foreach (LaptopImport bill in LaptopImportList)
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
            LaptopImport newLaptopImport = new();
            newLaptopImport.ID = IdentityLaptopImportID();
            newLaptopImport.CreateInformation();
            LaptopImportList.Add(newLaptopImport);
        }
        public LaptopImport FindImportByID(int id)
        {

            LaptopImport result = null;
            foreach (LaptopImport bill in LaptopImportList)
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
            Console.Write("Enter deleting LaptopImport's ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            LaptopImport laptopImport = FindImportByID(ID);
            if (laptopImport != null)
            {
                LaptopImportList.Remove(laptopImport);
            }
        }
        public void DisplayImportInformation()
        {
            foreach (LaptopImport bill in LaptopImportList)
            {
                bill.Note();
                bill.DisplayInformation();
            }
        }
        //PartCRUD
        private int IdentityLaptopPartID()
        {
            int max = 0;
            foreach (LaptopPart part in LaptopPartList)
            {
                if (part.ID >= max)
                {
                    max = part.ID + 1;
                }
            }
            return max;
        }
        public LaptopPart FindPartByID(int id)
        {

            LaptopPart result = null;
            foreach (LaptopPart part in LaptopPartList)
            {
                if (part.ID == id)
                {
                    result = part;
                }
            }
            return result;
        }
        public void AddComponentInformation()
        {
            LaptopPart part = new();
            part.ID = IdentityLaptopPartID();
            part.CreatePartInformation();
            LaptopPartList.Add(part);
        }
        public void DisplayComponentInformation()
        {
            foreach (LaptopPart part in LaptopPartList)
            {
                part.DisplayPartInformation();
            }
        }
        public void DeleteComponentInformation()
        {
            Console.Write("Type Part ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (FindPartByID(id) != null)
            {
                LaptopPartList.Remove(FindPartByID(id));
            }
        }
    }
}
