using System;

// README.md를 읽고 코드를 작성하세요.
object ob1 = 42;
object ob2 = 3.14;
object ob3 = "Hello";
object ob4 = true;

Console.WriteLine(ob1);
Console.WriteLine(ob2);
Console.WriteLine(ob3);
Console.WriteLine(ob4);

Stack stack = new Stack();

stack.Push("sausage");
string s = (string)stack.Pop();
Console.WriteLine(s);

stack.Push(3);
int three = (int)stack.Pop();
Console.WriteLine(three);

int i = 1234;
object o = i;
Console.WriteLine(o);

object o2 = 1234;
int i2 = (int)o2;
Console.WriteLine(i2);

int i3 = 42;
object o3 = i3;
Console.WriteLine(o3);

Point p = new Point { X = 10, Y = 20 };
IDisplayable d = p; 
Console.WriteLine(d.GetType().Name);

int i4 = 3;
object o4 = i4;
i4 = 5;

Console.WriteLine($"원본: {i4}");
Console.WriteLine($"박싱된 값: {o4}");

object o5 = 42;
int i5 = (int)o5;
Console.WriteLine($"언박싱 성공: {i5}")  ;

try
{
    long l = (long)o5;
}
catch (InvalidCastException)
{
    Console.WriteLine("잘못된 타입으로 언박싱 시도");
}

int temp = (int)o5;
long correct = temp;
Console.WriteLine($"올바른 변환: {correct}");

int sum1 = 0;
for (int j = 0; j < 1000; j++)
{
    object boxed = j;
    sum1 += (int)boxed;
}
Console.WriteLine($"박싱 사용: {sum1}");

int sum2 = 0;
for (int j = 0; j < 1000; j++)
{
    sum2 += j;
}
Console.WriteLine($"직접 처리: {sum2}");

GenericStack<int> intStack = new GenericStack<int>();
intStack.Push(42);
int value = intStack.Pop();
Console.WriteLine(value);

int aa = 1;
string bb = "ABCD";
char cc = 'A';
double dd = 1.1;
object obj = new object();

Console.WriteLine(aa.GetType());
Console.WriteLine(bb.GetType());
Console.WriteLine(cc.GetType());
Console.WriteLine(dd.GetType());
Console.WriteLine(obj.GetType());

Console.WriteLine(typeof(int));
Console.WriteLine(typeof(string));
Console.WriteLine(typeof(double));

Console.WriteLine(p.GetType().Name);
Console.WriteLine(typeof(Point).Name);
Console.WriteLine(p.GetType() == typeof(Point));
Console.WriteLine(p.X.GetType().Name);
Console.WriteLine(p.Y.GetType().FullName);

int a1 = 42;
double b1 = 3.14;
bool c1 = true;

Console.WriteLine(a1.ToString());
Console.WriteLine(b1.ToString());
Console.WriteLine(c1.ToString());

Panda panda = new Panda();
panda.Name = "Petey";
Console.WriteLine(panda);
Console.WriteLine(panda.ToString());

Player player = new Player { Name = "Hero", Level = 10, Health = 100 };
Console.WriteLine(player);

string s1 = "Hello";
string s2 = "Hello";
string s3 = s1;

Console.WriteLine($"s1.Equals(s2): {s1.Equals(s2)}");
Console.WriteLine($"ReferenceEquals(s1, s2): {object.ReferenceEquals(s1, s2)}");
Console.WriteLine($"ReferenceEquals(s1, s3): {object.ReferenceEquals(s1, s3)}");

object obj1 = new object();
object obj2 = new object();
object obj3 = obj1;

Console.WriteLine($"obj1.Equals(obj1): {obj1.Equals(obj2)}");
Console.WriteLine($"ReferenceEquals(obj1, obj2): {object.ReferenceEquals(obj1, obj2)}");
Console.WriteLine($"ReferenceEquals(obj1, obj3): {object.ReferenceEquals(obj1, obj3)}");