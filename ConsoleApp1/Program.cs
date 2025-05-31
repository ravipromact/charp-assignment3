namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initial Dictionary of Prime ministers
           Dictionary<int, string> PrimeMinisters = new Dictionary<int, string>();
            PrimeMinisters[1998] = "Atal Bihari Vajpayee";
            PrimeMinisters[2014] = "Narendra Modi";
            PrimeMinisters[2004] = "Manmohan Singh";

            // Print each key,value pair of dictionary in console
            Console.WriteLine("Existing list of PM:");
            foreach (KeyValuePair<int, string> pm in PrimeMinisters)
            {
                Console.WriteLine($"Year: {pm.Key}, Prime Minister: {pm.Value}");
            }

            ListOfPrimeMinisters(PrimeMinisters);
        }

        public static void ListOfPrimeMinisters(Dictionary<int, string> PrimeMinisters)
        {
            Console.WriteLine(); //space
            Console.WriteLine("Enter details of current Prime Minister");
            int year = AddYear();
            string name = AddName();
            
            PrimeMinisters.Add(year, name); // Add current PM

            List<KeyValuePair<int, string>> SortedList = PrimeMinisters.OrderBy(pm => pm.Key).ToList(); // Order dictionary by year
            Console.WriteLine();
            Console.WriteLine("Sorted by year");
            foreach (var pm in SortedList)
            {
                Console.WriteLine($"Year: {pm.Key}, Prime Minister: {pm.Value}");
            }
        }

        // Method to prompt user input for year
        public static int AddYear()
        {
            while (true)
            {
                Console.WriteLine("Enter Year");
                var year = Console.ReadLine();
                if (int.TryParse(year, out int result))
                {
                    var currentYear = DateTime.Today.Year;
                    if(result == currentYear)
                    {
                        return result;
                    }
                }
                Console.WriteLine("Input not matching current year.");
            }
        }

        // Method to prompt user input for prime minister name
        public static string AddName()
        {
            while (true)
            {
                Console.WriteLine("Enter Name of PM");
                var name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name))
                {
                    return name;
                }
                Console.WriteLine("Name is required.");
            }

        }
    }
}
