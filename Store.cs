
public class Store
{
    private List<Item> _storage;

    public Store()
    {
        _storage = [];
    }


    //methods
    public void AddItem(Item item)
    {
        bool foundItem = _storage.Contains(item);
        if (!foundItem)
        {
            _storage.Add(item);
        }
    }

    public bool DeleteItem(Item item)
    {
        bool result = _storage.Remove(item);
        if (result)
        {
            return true;
        }
        return false;
    }

    public int GetCurrentVolume()
    {
        return _storage.Count();
    }

    public void GetStorageItemNames()
    {
        foreach (Item item in _storage)
        {
            Console.WriteLine($"Name: {item.GetName()}");
        }
    }


    public Item FindItemByName(string name)
    {
        Item? searchedItem = _storage.Find(item => item.GetName() == name);
        if (searchedItem is null)
        {
            Console.WriteLine("item not in stock");


        }
        return searchedItem;
    }

    // Method SortByNameAscto get the sorted collection by name in ascending order.

    public List<Item> SortByNameAsc()
    {
        List<Item> sortedList = _storage.OrderBy(item => item.GetName()).ToList();
        return sortedList;
    }

}