using System.Net.WebSockets;

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
        // @TODO: validations
        _storage.Add(item);
    }

    public string DeleteItem(Item item)
    {
        // @TODO: validations
        bool result = _storage.Remove(item);
        if (result)
        {
            return "Removed item successfully";
        }
        else
        {
            return "Item doesn't exist";
        }
    }

    public string GetCurrentVolume()
    {
        return $"There are {_storage.Count()} items in the store";
    }

    public void GetStorageItemNames()
    {
        foreach (var item in _storage)
        {
            Console.WriteLine($"Name: {item.GetName()}");
        }
    }


    public Item FindItemByName(string name)
    {
        Item? searchedItem = _storage.Find(elem => elem.GetName() == name);
        return searchedItem;
    }

    // Method SortByNameAscto get the sorted collection by name in ascending order.

    public void SortByNameAsc()
    {
        List<Item> sortedList = _storage.OrderBy(item => item.GetName()).ToList();

    }


}