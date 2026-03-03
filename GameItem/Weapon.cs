class Weapon : Item
{
    public int Damage;

    public Weapon(string name, int price, int damage) : base(name, price)
    {

    }

    public override string ToString()
    {
        return $"Weapon {{ Name = {Name}, Price = {Price}, Damage = {Damage} }} [Weapon]";
    }
}