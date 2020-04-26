using Arch.Domain.Absract.IEntity;
using Arch.Domain.Absract.ILogic;
using Arch.Domain.Absract.Repositories.Abstract;
using System;
using System.Collections.Generic;

namespace Arch.Domain.Implementations.Logic
{
    public class ContactLogic : IContactLogic
    {
        readonly IContactRepository _contactRepository;
        readonly IGroupRepository _groupRepository;
        public ContactLogic(
                IContactRepository contactRepository,
                IGroupRepository groupRepository
            )
        {
            _contactRepository = contactRepository;
            _groupRepository = groupRepository;
        }

        public IContact GetContact(int contactId)
        {
            var contact = _contactRepository.Get(contactId);

            return contact;
        }

        public IList<IContact> GetContacts()
        {
            return _contactRepository.GetAll();
        }

        public bool SaveContact(IContact contact)
        {
            return _contactRepository.Save(contact);
        }
    }
}
