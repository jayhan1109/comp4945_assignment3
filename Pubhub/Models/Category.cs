using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pubhub.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [DisplayName("Price")]
        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="Price must be greater than 0")]
        public int DisplayOrder { get; set; }
    }
}
