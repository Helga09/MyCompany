using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MyCompany.Domain.Entities
{
    public class News : EntityBase
    {       
        [Required(ErrorMessage = "Заповніть заголовок новини")]
        [Display(Name = "Заголовок новини")]
        public override string Title { get; set; }

        [Display(Name = "Короткий опис новини")]
        public override string Subtitle { get; set; }


        [Display(Name = "Повний опис новини")]
        public override string Text { get; set; }
    }
}
