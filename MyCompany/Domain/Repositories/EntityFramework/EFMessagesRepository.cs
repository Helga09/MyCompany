using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFMessagesRepository : IMessagesRepository
    {
        private readonly AppDbContext context;

        public EFMessagesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteMessages(Guid id)
        {
            context.Messages.Remove(new Messages() { Id = id });
            context.SaveChanges();
        }

        public IQueryable<Messages> GetMessages()
        {
            return context.Messages;
        }

        public Messages GetMessagesById(Guid id)
        {
            return context.Messages.FirstOrDefault(x => x.Id == id);
        }

        public void SaveMessages(Messages entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
