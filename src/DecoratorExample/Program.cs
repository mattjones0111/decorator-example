namespace DecoratorExample
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();

            services.AddTransient<IDatabase, SqlDatabase>();
            services.AddTransient<IMessagePublisher, ConsoleMessagePublisher>();

            services.Decorate<IDatabase, MessagePublishingDecorator>();

            IServiceProvider provider = services.BuildServiceProvider();

            IDatabase database = provider.GetRequiredService<IDatabase>();

            database.SaveAsync(new Widget());
        }
    }
}
