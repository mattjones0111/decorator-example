namespace DecoratorExample
{
    using System;
    using System.Threading.Tasks;

    public class ConsoleMessagePublisher : IMessagePublisher
    {
        public Task SendAsync(Message message)
        {
            Console.WriteLine("Published message...");
            return Task.CompletedTask;
        }
    }
}