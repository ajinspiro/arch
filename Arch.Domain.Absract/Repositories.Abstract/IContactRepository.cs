using Arch.Domain.Absract.DomainObjects;
using System.Collections.Generic;

namespace Arch.Domain.Absract.Repositories.Abstract
{
    public interface IContactRepository
    {
        IContact Get(int id);
        IList<IContact> GetAll();
        bool Save(IContact contact);
    }
}
