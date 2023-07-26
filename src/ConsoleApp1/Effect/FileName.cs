using Microsoft.Extensions.Logging;

namespace ConsoleApp1.Effect;

public interface IHasLogger<RT> : IHas<RT, ILogger> where RT : struct, IHasLogger<RT>
{
    public static Eff<RT, Unit> LogInfomation(string? message, params object?[] args) => Eff.Map(x =>
    {
        x.LogInformation(message, args);
        return unit;
    });
}
