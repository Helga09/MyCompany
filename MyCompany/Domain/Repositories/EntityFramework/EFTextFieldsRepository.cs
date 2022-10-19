using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Repositories.Abstract;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFTextFieldsRepository : ITextFieldsRepository
    {
        private readonly AppDbContext context;
        public EFTextFieldsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<TextField> GetTextFields()
        {
            return context.TextField;
        }

        public TextField GetTextFieldById(Guid id)
        {
            return context.TextField.FirstOrDefault(x => x.Id == id);
        }

        public TextField GetTextFieldByCodeWords(string codeWord)
        {
            return context.TextField.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public void SaveTextField(TextField entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteTextField(Guid id)
        {
            context.TextField.Remove(new TextField() { Id = id });
            context.SaveChanges();
        }
    }
}
