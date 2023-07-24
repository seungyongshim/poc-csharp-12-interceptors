using System;
using System.Runtime.CompilerServices;
using ConsoleApp1;

var b = FileName.Add(1, 1);

Console.WriteLine(b);


static class D
{
    [InterceptsLocation("""C:\2023\poc-csharp-12-interceptors\src\ConsoleApp1\Program.cs""", line: 5, character: 18)]
    public static int AddInterceptor(int param, int p2)
    {
        Console.WriteLine($"interceptor {param}");
        return 3;
    }
}

