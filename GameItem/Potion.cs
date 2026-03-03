using static System.Net.Mime.MediaTypeNames;

class Potion : Item
{
    public int HealAmount;

    public Potion(string name, int price, int healAmount) : base(name, price)
    {
        HealAmount = healAmount;
    }

    public override string ToString()
    {
        return $"Potion {{ Name = {Name}, Price = {Price}, HealAmount = {HealAmount} }} [Potion]";
    }
}