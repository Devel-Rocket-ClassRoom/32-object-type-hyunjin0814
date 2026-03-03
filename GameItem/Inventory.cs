using System;

class Inventory
{
    private object[] items = new object[10];
    private int count;

    public void AddItem(object item)
    {
        items[count++] = item; 
    }

    public void ShowInventory()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"슬롯 {i + 1}: {items[i].ToString()}");
        }
    }
}