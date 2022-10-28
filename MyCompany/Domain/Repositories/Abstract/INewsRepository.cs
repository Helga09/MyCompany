using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain.Entities;
namespace MyCompany.Domain.Repositories.Abstract
{
    public interface INewsRepository
    {
        IQueryable<News> GetNotPublishNews();
        IQueryable<News> GetPublishNews();
        IQueryable<News> GetAllNews();
        News GetNewsById(Guid id);
        void SaveNews(News entity);
        void DeleteNews(Guid id);
    }
}
