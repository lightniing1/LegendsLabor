namespace LegendsLabor.Core.Domain
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }

}
