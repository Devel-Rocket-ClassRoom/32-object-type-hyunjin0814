class Stack
{
    private int count;
    private object[] objects = new object[10];

    public void Push(object obj)
    {
        objects[count++] = obj; 
    }

    public object Pop()
    {
        return objects[--count];
    }
}