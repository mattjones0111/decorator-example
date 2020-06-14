namespace DecoratorExample
{
    using System;
    using System.Threading.Tasks;

    public class SqlDatabase : IDatabase
    {
        public Task SaveAsync(Widget toSave)
        {
            Console.WriteLine("Database is saving Widget...");
            Console.WriteLine("Database is saved Widget...");

            return Task.CompletedTask;
        }
    }
}
