using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOET.Domain.Entities
{
    public class PostItem : EntityBase
    {
        [Required(ErrorMessage = "Заполни название поста!")]
        [Display(Name = "Название поста")]
        public override string Title { get; set; }

        [Display(Name = "Содержание поста")]
        public override string Text { get; set; }
    }

}
