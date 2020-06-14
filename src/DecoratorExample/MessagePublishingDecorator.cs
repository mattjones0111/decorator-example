namespace DecoratorExample
{
    using System.Threading.Tasks;

    public class MessagePublishingDecorator : IDatabase
    {
        readonly IDatabase innerDatabase;
        readonly IMessagePublisher messageBus;

        public MessagePublishingDecorator(
            IDatabase innerDatabase,
            IMessagePublisher messageBus)
        {
            this.innerDatabase = innerDatabase;
            this.messageBus = messageBus;
        }

        public async Task SaveAsync(Widget toSave)
        {
            await innerDatabase.SaveAsync(toSave);

            await messageBus.SendAsync(new Message());
        }
    }
}
