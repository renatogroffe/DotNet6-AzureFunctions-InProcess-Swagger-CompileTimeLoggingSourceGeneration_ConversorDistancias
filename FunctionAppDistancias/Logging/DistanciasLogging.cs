using Microsoft.Extensions.Logging;

namespace FunctionAppDistancias.Logging;

public static partial class DistanciasLogging
{
    [LoggerMessage(EventId = 1, Level = LogLevel.Information,
        Message = "{milhas} milhas = {km} Km")]
    public static partial void LogConversaoDistancias(
        this ILogger logger, double milhas, double km);
}