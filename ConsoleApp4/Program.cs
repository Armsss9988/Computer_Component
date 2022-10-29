namespace ConsoleApp4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ComponentStorage componentStorage = ComponentStorage.GetComponentStorage();
            LaptopStorage laptopStorage = LaptopStorage.GetLaptopStorage();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("*========================================*");
                Console.WriteLine("||     Laptop&Component Management!!    ||");
                Console.WriteLine("*=================******=================*");
                Console.WriteLine("||        1.Laptop management.          ||");
                Console.WriteLine("||        2.Component management.       ||");
                Console.WriteLine("||        3.Exit.                       ||");
                Console.WriteLine("*========================================*");
                Console.Write("Choose option: ");
                try
                {


                    int k = Convert.ToInt32(Console.ReadLine());
                    switch (k)
                    {
                        case 1:
                            bool h = true;
                            while (h)
                            {
                                Console.Clear();
                                Console.WriteLine("*========================================*");
                                Console.WriteLine("||           Laptop Management!!!       ||");
                                Console.WriteLine("*=================******=================*");
                                Console.WriteLine("||        1.Add Laptop.                 ||");
                                Console.WriteLine("||        2.Update Laptop.              ||");
                                Console.WriteLine("||        3.Delete Laptop.              ||");
                                Console.WriteLine("||        4.Display Laptop.             ||");
                                Console.WriteLine("||        5.Laptop Part.                ||");
                                Console.WriteLine("||        6.Import Laptop History.      ||");
                                Console.WriteLine("||        7.Back.                       ||");
                                Console.WriteLine("*========================================*");
                                Console.Write("Choose option:");
                                int l = Convert.ToInt32(Console.ReadLine());


                                switch (l)
                                {

                                    case 1:
                                        Console.WriteLine("Add Laptop!!!");
                                        laptopStorage.AddInformation();
                                        Console.WriteLine("Input success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        Console.WriteLine("Update Laptop!!!");
                                        laptopStorage.UpdateInformation();
                                        Console.WriteLine("Update success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 3:
                                        Console.WriteLine("Delete Laptop!!!");
                                        laptopStorage.DeleteInformation();
                                        Console.WriteLine("Delete success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 4:
                                        Console.WriteLine("Display Laptop list!!!");
                                        laptopStorage.DisplayInformation();
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 5:
                                        Console.Write("Enter laptop id: ");
                                        int id = Convert.ToInt32(Console.ReadLine());
                                        Laptop laptop = laptopStorage.FindLaptopByID(id);
                                        bool p = true;
                                        while (p)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("*========================================*");
                                            Console.WriteLine("||        1. Add Part.                  ||");
                                            Console.WriteLine("||        2. Delete Part.               ||");
                                            Console.WriteLine("||        3. Display Part.              ||");
                                            Console.WriteLine("||        4. Back.                      ||");
                                            Console.WriteLine("*========================================*");
                                            Console.Write("Choose option:");
                                            int m = Convert.ToInt32(Console.ReadLine());
                                            switch (m)
                                            {
                                                case 1:
                                                    Console.WriteLine("Add Part!!!");
                                                    laptop.AddComponentInformation();
                                                    Console.WriteLine("Input success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 2:
                                                    Console.WriteLine("Delete part!!!");
                                                    laptop.DeleteComponentInformation();
                                                    Console.WriteLine("Delete success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 3:
                                                    Console.WriteLine("Display Part!!!");
                                                    laptop.DisplayComponentInformation();
                                                    Console.WriteLine("Display success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 4:
                                                    p = false;
                                                    break;
                                                default:
                                                    Console.WriteLine("Invalid Input");
                                                    break;
                                            }
                                        }
                                        break;
                                    case 6:
                                        Console.Write("Enter laptop id: ");
                                        int pid = Convert.ToInt32(Console.ReadLine());
                                        Laptop plaptop = laptopStorage.FindLaptopByID(pid);
                                        bool kh = true;
                                        while (kh)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("*========================================*");
                                            Console.WriteLine("||        1. Add Part.                  ||");
                                            Console.WriteLine("||        2. Delete Part.               ||");
                                            Console.WriteLine("||        3. Display Part.              ||");
                                            Console.WriteLine("||        4. Back.                      ||");
                                            Console.WriteLine("*========================================*");
                                            Console.Write("Choose option:");
                                            int m = Convert.ToInt32(Console.ReadLine());
                                            switch (m)
                                            {
                                                case 1:
                                                    Console.WriteLine("Add Import!!!");
                                                    plaptop.AddImportInformation();
                                                    Console.WriteLine("Input success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 2:
                                                    Console.WriteLine("Delete Import!!!");
                                                    plaptop.DeleteImportInformation();
                                                    Console.WriteLine("Delete success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 3:
                                                    Console.WriteLine("Display Import!!!");
                                                    plaptop.DisplayImportInformation();
                                                    Console.WriteLine("Display success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 4:
                                                    kh = false;
                                                    break;
                                                default:
                                                    Console.WriteLine("Invalid Input");
                                                    break;
                                            }
                                        }
                                        break;
                                    case 7:
                                        h = false;
                                        break;

                                    default:
                                        Console.WriteLine("Invalid Input");
                                        break;
                                }
                            }
                            break;
                        case 2:
                            bool t = true;
                            while (t)
                            {
                                Console.Clear();
                                Console.WriteLine("*========================================*");
                                Console.WriteLine("||        Component Management!!!       ||");
                                Console.WriteLine("*=================******=================*");
                                Console.WriteLine("||        1.Add Component.              ||");
                                Console.WriteLine("||        2.Update Component.           ||");
                                Console.WriteLine("||        3.Delete Component.           ||");
                                Console.WriteLine("||        4.Display Component.          ||");
                                Console.WriteLine("||        5.Import Component History.   ||");
                                Console.WriteLine("||        6.Back.                       ||");
                                Console.WriteLine("*========================================*");
                                Console.Write("Choose option:");
                                int l = Convert.ToInt32(Console.ReadLine());


                                switch (l)
                                {

                                    case 1:
                                        Console.WriteLine("Add Component!!!");
                                        componentStorage.AddInformation();
                                        Console.WriteLine("Input success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        Console.WriteLine("Update Laptop!!!");
                                        componentStorage.UpdateInformation();
                                        Console.WriteLine("Update success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 3:
                                        Console.WriteLine("Delete Laptop!!!");
                                        componentStorage.DeleteInformation();
                                        Console.WriteLine("Delete success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 4:
                                        Console.WriteLine("Display Laptop list!!!");
                                        componentStorage.DisplayInformation();
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 5:
                                        Console.Write("Enter laptop id: ");
                                        int id = Convert.ToInt32(Console.ReadLine());
                                        Component component = componentStorage.FindComponentByID(id);
                                        bool p = true;
                                        while (p)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("*========================================*");
                                            Console.WriteLine("||        1. Add Import.                  ||");
                                            Console.WriteLine("||        2. Delete Import.               ||");
                                            Console.WriteLine("||        3. Display Import.              ||");
                                            Console.WriteLine("||        4. Back.                      ||");
                                            Console.WriteLine("*========================================*");
                                            Console.Write("Choose option:");
                                            int m = Convert.ToInt32(Console.ReadLine());
                                            switch (m)
                                            {
                                                case 1:
                                                    Console.WriteLine("Add Part!!!");
                                                    component.AddImportInformation();
                                                    Console.WriteLine("Input success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 2:
                                                    Console.WriteLine("Delete part!!!");
                                                    component.DeleteImportInformation();
                                                    Console.WriteLine("Delete success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 3:
                                                    Console.WriteLine("Display Part!!!");
                                                    component.DisplayImportInformation();
                                                    Console.WriteLine("Display success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 4:
                                                    p = false;
                                                    break;
                                                default:
                                                    Console.WriteLine("Invalid Input");
                                                    break;
                                            }
                                        }
                                        break;
                                    case 6:
                                        t = false;
                                        break;

                                    default:
                                        Console.WriteLine("Invalid Input");
                                        break;
                                }
                            }
                            break;
                        case 3:
                            h = false;
                            return;

                        default:
                            Console.WriteLine("Invalid Input");
                            break;


                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                };




            }
        }
    }
}