using PTMKTestTask.Interfaces.DAL;

namespace PTMKTestTask.DAL.Entities.Base
{
    public abstract class Entity : IEntity
    {
        public int ID { get; set; }
    }
}
