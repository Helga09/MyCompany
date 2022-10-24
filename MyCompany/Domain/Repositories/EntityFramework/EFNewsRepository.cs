using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain.Repositories.EntityFramework
{

    public class EFNewsRepository : INewsRepository
    {
        private readonly AppDbContext context;

        public EFNewsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteNews(Guid id)
        {
            context.News.Remove(new News() { Id = id });
            context.SaveChanges();
        }

        public IQueryable<News> GetNews()
        {
            return context.News;
        }

        public News GetNewsById(Guid id)
        {
            return context.News.FirstOrDefault(x => x.Id == id);
        }

        public void SaveNews(News entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

