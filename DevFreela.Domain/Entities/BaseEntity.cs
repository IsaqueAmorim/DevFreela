namespace DevFreela.Domain.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            
        }

        public Guid ID { get; private set; }
    }
}
    