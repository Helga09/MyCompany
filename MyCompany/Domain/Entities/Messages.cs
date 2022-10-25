using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class Messages
    {
        public Messages() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Заповніть повідомлення")]
        public string textMessage { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
