public class Item
{
    private readonly string _name;
    private int _quantity;

    private DateTime _createdDate;

    public Item(string name, int quantity, DateTime createdDate)
    {
        _name = name;
        _quantity = quantity;
        _createdDate = createdDate;
    }
    public Item(string name, int quantity)
    {
        _name = name;
        _quantity = quantity;
        _createdDate = DateTime.Now;
    }

    public string GetName()
    {
        return _name;
    }

    public DateTime GetDateTime()
    {
        return _createdDate;
    }

}