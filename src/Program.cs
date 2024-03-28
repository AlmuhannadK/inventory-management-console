class Program
{
    private static void Main(string[] args)
    {

        // Item instances
        var waterBottle = new Item("Water Bottle", 10, new DateTime(2023, 1, 1));
        var chocolateBar = new Item("Chocolate Bar", 15, new DateTime(2023, 2, 1));
        var notebook = new Item("Notebook", 5, new DateTime(2023, 3, 1));
        var pen = new Item("Pen", 20, new DateTime(1997, 4, 1));
        var tissuePack = new Item("Tissue Pack", 30, new DateTime(2023, 5, 1));
        var chipsBag = new Item("Chips Bag", 25, new DateTime(2023, 6, 1));
        var sodaCan = new Item("Soda Can", 8, new DateTime(2023, 7, 1));
        var soap = new Item("Soap", 12, new DateTime(2023, 8, 1));
        var shampoo = new Item("Shampoo", 40, new DateTime(2023, 9, 1));
        var toothbrush = new Item("Toothbrush", 50, new DateTime(2023, 10, 1));
        var coffee = new Item("Coffee", 20);
        var sandwich = new Item("Sandwich", 15);
        var batteries = new Item("Batteries", 10);
        var umbrella = new Item("Umbrella", 5);
        var sunscreen = new Item("Sunscreen", 8);
        var milk = new Item("Milk", 12, new DateTime(2022, 12, 12));
        var eggs = new Item("Eggs", 34, new DateTime(2024, 2, 2));

        // Store instance
        Store myStore = new("Ada's Shop", 450);

        // AddItem method
        myStore.AddItem(waterBottle);
        myStore.AddItem(pen);
        myStore.AddItem(soap);
        myStore.AddItem(coffee);
        myStore.AddItem(batteries);
        myStore.AddItem(umbrella);
        myStore.AddItem(sodaCan);
        myStore.AddItem(notebook);
        myStore.AddItem(toothbrush);
        myStore.AddItem(chocolateBar);
        myStore.AddItem(milk);
        myStore.AddItem(eggs);

        // Get Number of Items in Store 
        Console.WriteLine(myStore.GetStorageItems());
        Console.WriteLine("============================================");

        // Retrieve Item Names in Store
        myStore.GetStorageItemNames();
        Console.WriteLine("============================================");

        // DeleteItem method
        myStore.DeleteItem(waterBottle);
        myStore.DeleteItem(milk);
        Console.WriteLine("**AFTER DELETE");
        myStore.GetStorageItemNames();
        Console.WriteLine(myStore.GetStorageItems());
        Console.WriteLine("============================================");

        // FindItemByName method
        var targetItem = myStore.FindItemByName("Toothbrush");
        Console.WriteLine($"Here's your search result: {targetItem.GetName()}");
        Console.WriteLine("============================================");

        // SortByName method (pass ASC or DESC)
        List<Item> sortedList = myStore.SortByName(SortOrder.DESC);
        Console.WriteLine("**AFTER SORTING BY NAME");
        sortedList.ForEach(item => Console.WriteLine(item.GetName()));
        Console.WriteLine("============================================");

        // GetCurrentVolume method (each item's quantity)
        int totalVolume = myStore.GetCurrentVolume();
        Console.WriteLine($"total items volume: {totalVolume}");
        Console.WriteLine("============================================");


        // GetMaxCapacity and item addition
        Console.WriteLine($"Storage Maximum Capacity is {myStore.GetMaxCapacity()}");
        // var testCapacity = new Item("Test", 1000);
        // myStore.AddItem(testCapacity);
        Console.WriteLine("============================================");


        // Generated id field
        Console.WriteLine(notebook.GetId());
        Console.WriteLine(milk.GetId());
        Console.WriteLine("============================================");


        // SortByDate method
        List<Item> sortByDateList = myStore.SortByDate(SortOrder.DESC);
        Console.WriteLine("**SORTING BY DATE");

        sortByDateList.ForEach(item => Console.WriteLine($"Item: {item.GetName()}, Date: {item.GetCreatedAt()}"));
        Console.WriteLine("============================================");


        // GroupByDate method
        var groupByDate = myStore.GroupByDate();
        foreach (var group in groupByDate)
        {
            Console.WriteLine($"{group.Key} Items: ");
            foreach (var item in group)
            {
                Console.WriteLine($" - {item.GetName()}, Created: {item.GetCreatedAt().ToShortDateString()}");
            }
        }

    }
}