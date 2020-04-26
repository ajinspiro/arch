namespace Arch.Domain.Absract.IEntity
{
    public interface IContact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Number { get; set; }
    }
}
