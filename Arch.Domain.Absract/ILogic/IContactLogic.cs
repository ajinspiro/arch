using Arch.Domain.Absract.IEntity;
using System.Collections.Generic;

namespace Arch.Domain.Absract.ILogic
{
    public interface IContactLogic
    {
        public IContact GetContact(int contactId);
        public IList<IContact> GetContacts();
        public bool SaveContact(IContact contact);
    }
}
