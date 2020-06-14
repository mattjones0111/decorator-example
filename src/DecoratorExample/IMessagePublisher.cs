namespace DecoratorExample
{
    using System.Threading.Tasks;

    public interface IMessagePublisher
    {
        Task SendAsync(Message message);
    }
}
