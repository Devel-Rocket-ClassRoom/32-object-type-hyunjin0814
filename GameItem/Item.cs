class Item
{
    public string Name;
    public int Price;

    protected Item(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"Item {{ Name = {Name}, Price = {Price} }} [Item]";
    }
}