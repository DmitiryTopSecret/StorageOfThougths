using SOET.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOET.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IPostItemsRepository PostItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IPostItemsRepository postItemsRepository)
        {
            TextFields = textFieldsRepository;
            PostItems = postItemsRepository;
        }
    }
}
