namespace Template.API.Extensions;

public static class LoggerConfiguration
{
    public static void ConfigureLoggerService(this IServiceCollection services)
    {
        services.AddSingleton<ILoggerManager, LoggerManager>();
        services.AddSingleton<ILoggerFactory, LoggerFactory>();
    }
}