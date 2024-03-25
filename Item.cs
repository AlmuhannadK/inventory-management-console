public class Item
{
    private readonly string _name;
    private int _quantity;

    private DateTime _createdAt;

    public Item(string name, int quantity, DateTime createdAt)
    {
        _name = name;
        _quantity = quantity;
        _createdAt = createdAt;
    }
    public Item(string name, int quantity)
    {
        _name = name;
        _quantity = quantity;
        _createdAt = DateTime.Now;
    }

    public string GetName()
    {
        return _name;
    }

    public DateTime GetDateTime()
    {
        return _createdAt;
    }

}