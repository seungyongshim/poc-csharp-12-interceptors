using System;
using System.Runtime.CompilerServices;
using ConsoleApp1;

var b = FileName.Add(1, 3);

Console.WriteLine(b);


static class D
{
    [InterceptsLocation("""C:\2023\poc-csharp-12-interceptors\src\ConsoleApp1\Program.cs""", line: 5, character: 18)]
    public static int Add123123Interceptor(int p1, int p2)
    {
        Console.WriteLine($"interceptor {p1}");
        return p1 - p2;
    }

    
}

