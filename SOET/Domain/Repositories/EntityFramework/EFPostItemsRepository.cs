using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SOET.Domain.Entities;
using SOET.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOET.Domain.Repositories.EntityFramework
{
    public class EFPostItemsRepository : IPostItemsRepository
    {
        private readonly AppDbContext context;
        public EFPostItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<PostItem> GetPostItems()
        {
            return context.PostItems;
        }

        public PostItem GetPostItemById(Guid id)
        {
            return context.PostItems.FirstOrDefault(x => x.Id == id);
        }

      
        public void SavePosteItem(PostItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeletePostItem(Guid id)
        {
            context.PostItems.Remove(new PostItem() { Id = id });
            context.SaveChanges();
        }
    }
}
