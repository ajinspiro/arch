using Arch.Domain.Absract.IEntity;

namespace Arch.Domain.Implementations.Entity
{
    public class Contact : IContact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Number { get; set; }
    }
}
