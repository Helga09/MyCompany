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

        public IQueryable<News> GetNotPublishNews()
        {
            return context.News.Where(x => x.Publish == false);
        }

        public News GetNewsById(Guid id)
        {
            return context.News.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<News> GetPublishNews()
        {
            return context.News.Where(x => x.Publish == true);
        }

        public void SaveNews(News entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public IQueryable<News> GetAllNews()
        {
            return context.News;
        }
    }
}

