using System;

// README.md를 읽고 코드를 작성하세요.
object[] data = { 42, 3.14, "Hello", true, 100, "World", false, 2.718 };
int[] counts = new int[4];

Console.WriteLine("=== 데이터 출력기 ===");
Console.WriteLine("\n[전체 데이터 출력]");

PrintAll(data);

Console.WriteLine();
Console.WriteLine("[타입별 통계]");
Console.WriteLine($"정수: {counts[0]}");
Console.WriteLine($"실수: {counts[1]}");
Console.WriteLine($"문자열: {counts[2]}");
Console.WriteLine($"논리값: {counts[3]}");

void PrintData(object data)
{
    switch (data.GetType().Name)
    {
        case "Int32":
            Console.WriteLine($"정수: {data}");
            counts[0]++;
            break;
        case "Double":
            Console.WriteLine($"실수: {data:F2}");
            counts[1]++;
            break;
        case "String":
            string s = (string)data;
            Console.WriteLine($"{data} (길이: {s.Length})");
            counts[2]++;
            break;
        case "Boolean":
            bool b = (bool)data;
            string boolText = b ? "참" : "거짓";
            Console.WriteLine($"논리값: {data} -> {boolText}");
            counts[3]++;
            break;
    }
}



void PrintAll(object[] data)
{
    foreach (var item in data)
    {
        PrintData(item);
    }
}
