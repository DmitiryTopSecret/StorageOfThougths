using SOET.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOET.Domain.Repositories.Abstract
{
    public interface IPostItemsRepository
    {
        IQueryable<PostItem> GetPostItems();
        PostItem GetPostItemById(Guid id);
        void SavePosteItem(PostItem entity);
        void DeletePostItem(Guid id);
    }
}
