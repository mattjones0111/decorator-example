namespace DecoratorExample
{
    using System.Threading.Tasks;

    public interface IDatabase
    {
        Task SaveAsync(Widget toSave);
    }
}
