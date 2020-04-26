using Arch.Domain.Absract.IEntity;
using Arch.Domain.Absract.Repositories.Abstract;
using Arch.Domain.Implementations.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Arch.DataAccess.Repository
{
    public class ContactRepository : IContactRepository
    {
        readonly ArchDB _archDB;

        public ContactRepository(ArchDB archDB)
        {
            _archDB = archDB;
            _archDB.Database.Migrate();
        }

        public IContact Get(int id)
        {
            return _archDB.Contacts.FirstOrDefault(_ => _.Id == id);
        }

        public IList<IContact> GetAll()
        {
            return _archDB.Contacts.Select(x => x as IContact).ToList();
        }

        public bool Save(IContact contact)
        {
            _archDB.Contacts.Add(contact as Contact);
            _archDB.SaveChanges();
            return true;
        }

    }
}
