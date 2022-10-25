using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain.Entities;


namespace MyCompany.Domain.Repositories.Abstract
{
    public interface IMessagesRepository
    {
        IQueryable<Messages> GetMessages();
        Messages GetMessagesById(Guid id);
        void SaveMessages(Messages entity);
        void DeleteMessages(Guid id);
    }
}
