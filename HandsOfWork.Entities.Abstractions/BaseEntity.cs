namespace HandsOfWork.Entities.Abstractions
{
    public abstract class BaseEntity<TEntityKey>
        where TEntityKey : struct
    {
        public TEntityKey Id { get; set; }
    }
}