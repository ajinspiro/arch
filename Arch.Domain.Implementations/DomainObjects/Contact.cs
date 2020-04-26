using Arch.Domain.Absract.DomainObjects;

namespace Arch.Domain.Implementations.DomainObjects
{
    public class Contact : IContact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Number { get; set; }
    }
}
