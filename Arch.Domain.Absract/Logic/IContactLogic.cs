using Arch.Domain.Absract.DomainObjects;
using System.Collections.Generic;

namespace Arch.Domain.Absract.Logic
{
    public interface IContactLogic
    {
        public IContact GetContact(int contactId);
        public IList<IContact> GetContacts();
        public bool SaveContact(IContact contact);
    }
}
