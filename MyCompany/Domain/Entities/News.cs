using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace MyCompany.Domain.Entities
{

    public class News : EntityBase
    {
        [Required(ErrorMessage = "Заповніть заголовок новини")]
        [Display(Name = "Заголовок новини")]
        [Remote(action: "CheckTitle", controller: "News", ErrorMessage = "Новина з такою назвою уже існує")]
        public override string Title { get; set; }

        [Display(Name = "Короткий опис новини")]
        public override string Subtitle { get; set; }


        [Display(Name = "Повний опис новини")]
        public override string Text { get; set; }

        public bool Publish { get; set; }
        [Required(ErrorMessage = "Заповніть пошту")]
        public string Email { get; set; }
    }
}
